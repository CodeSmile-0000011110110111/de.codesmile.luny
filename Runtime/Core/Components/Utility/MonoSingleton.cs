// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Components
{
	/// <summary>
	///     Slim and safe MonoBehaviour Singleton with guaranteed lifetime from first instantiation to application quit.
	///     Safeguarded against instance duplication, instance re-assignment and premature destruction.
	/// </summary>
	/// <example>
	///     Create a singleton instance by subclassing:
	///     `public class MySingleton : MonoSingleton&lt;MySingleton&gt; {}`
	/// </example>
	/// <remarks>
	///     This singleton can be used in two ways:
	///     1) Classic: add singleton component to a GameObject in prefab or scene. Then override Awake and either call
	///     base.Awake() or SetSingletonInstance(this).
	///     2) Auto-Create: do NOT add the singleton component to a GameObject! The first time T.Singleton is accessed, a new
	///     GameObject with the T component gets created automatically.
	///     NOTE: in BOTH cases the singleton's GameObject gets marked as DontDestroyOnLoad(instance) to guarantee it persists
	///     throughout scene changes. Keep this in mind when adding additional components to the same GameObject (prefer not
	///     to do so).
	/// </remarks>
	/// <remarks>
	///     Classic (1) singleton is required if you need to assign singleton fields in the Inspector. You have to ensure that
	///     the GameObject has its base.Awake() method called before any script accesses its Singleton field, otherwise you get
	///     an "already instantiated" exception.
	///     Auto-Create (2) singleton is recommended otherwise. This guarantees that the Singleton is available as soon as its
	///     being accessed the first time. There is no need to test for 'if (T.Singleton != null)' anywhere for Auto-Create
	///     singletons.
	/// </remarks>
	/// <remarks>
	///     This singleton is not re-entrant on purpose. You cannot, and must not, destroy the singleton component or the
	///     GameObject it is added to once it has been created. That is the definition of a singleton. If you need to perform
	///     cleanup, do so by hooking into appropriate event methods such as scene load or network shutdown.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		private static T s_Instance;
		private static Boolean s_IsInstanceAssigned;

		/// <summary>
		///     Access the Singleton instance.
		/// </summary>
		/// <remarks>
		///     If the Singleton has not been assigned on first access to this property, a new GameObject will be instantiated
		///     with the T component on it which then becomes the singleton instance. This is the Auto-Create behaviour.
		/// </remarks>
		public static T Singleton
		{
			get
			{
				if (s_IsInstanceAssigned == false)
				{
					var instance = AutoCreateInstance();
					SetSingletonInstance(instance);
				}

				return s_Instance;
			}
		}

		/// <summary>
		///     Assigns the singleton instance.
		///     CAUTION: Only call this if you don't call base.Awake()!
		/// </summary>
		/// <remarks>
		///     Prefer to call base.Awake() over manually calling SetSingletonInstance(this).
		/// </remarks>
		/// <param name="instance"></param>
		/// <exception cref="ArgumentNullException">
		///     The instance parameter is null. The singleton cannot be set to null. This is by design.
		/// </exception>
		protected static void SetSingletonInstance(T instance)
		{
			if (instance == null)
				throw new ArgumentNullException("instance must not be null");

			s_Instance = instance;
			s_IsInstanceAssigned = true;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStaticFields()
		{
			Debug.Log("ResetStaticFields MS");
			s_Instance = null;
			s_IsInstanceAssigned = false;
		}

		private static T AutoCreateInstance() =>
			new GameObject($"{typeof(T).Name} (Auto-Created)", typeof(T)).GetComponent<T>();

		/// <summary>
		///     Call base.Awake() to automatically assign 'this' as the singleton instance.
		///     Otherwise you need to call SetSingletonInstance(this) yourself BEFORE the Singleton property gets accessed!
		/// </summary>
		protected virtual void Awake()
		{
			if (s_Instance != null)
				throw new ArgumentException($"{nameof(MonoSingleton<T>)}<{typeof(T).Name}> already instantiated!");

			SetSingletonInstance(this as T);
		}

		// must defer DDoL to Start to allow possible  Multiplayer Roles stripping during Awake
		protected virtual void Start()
		{
			// DDoL only works on root game objects
			transform.parent = null;
			DontDestroyOnLoad(gameObject);

#if DEBUG
			EnableCheckDestroyWithoutQuitCheck();
#endif
		}

		/// <summary>
		///     To support 'disabled domain reload' we need to null the instance in OnDestroy.
		///     CAUTION: you must call base.OnDestroy() when overriding this method!
		/// </summary>
		protected virtual void OnDestroy()
		{
#if DEBUG
			CheckDestroyWithoutQuit();
#endif

			s_Instance = null;
			s_IsInstanceAssigned = false;
		}

		/// <summary>
		///     CAUTION: you must call base.OnApplicationQuit() when overriding this method!
		/// </summary>
		protected virtual void OnApplicationQuit()
		{
#if DEBUG
			DisableCheckDestroyWithoutQuitCheck();
#endif
		}

#if DEBUG
		private static Boolean s_IsApplicationQuitting = true; // start true to allow for component stripping during Awake()
		private static void EnableCheckDestroyWithoutQuitCheck() => s_IsApplicationQuitting = false;
		private static void DisableCheckDestroyWithoutQuitCheck() => s_IsApplicationQuitting = true;
		private static void CheckDestroyWithoutQuit()
		{
			if (s_IsApplicationQuitting == false)
			{
				throw new InvalidOperationException("Destroy() on MonoSingleton<T> instance disallowed! " +
				                                    "MonoSingleton must remain instantiated until Application quits. " +
				                                    "To perform cleanup use appropriate event handlers (eg scene load).");
			}
		}
#endif
	}
}
