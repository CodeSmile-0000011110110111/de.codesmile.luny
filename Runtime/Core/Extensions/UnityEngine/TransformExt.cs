// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Luny.Core.UnityEngine
{
	/// <summary>
	///     UnityEngine.Transform extension methods
	/// </summary>
	public static class TransformExt
	{
		public static T GetOrAddComponent<T>(this Transform t) where T : Component =>
			t.TryGetComponent(out T result) ? result : t.gameObject.AddComponent<T>();

		/// <summary>
		///     Destroys (in any mode) all children of the transform.
		/// </summary>
		/// <param name="t"></param>
		public static void DestroyAllChildren(this Transform t)
		{
			for (var i = t.childCount - 1; i >= 0; i--)
				t.GetChild(i).gameObject.DestroyInAnyMode();
		}

		/// <summary>
		///     Destroys the transform's GameObject regardless of Edit or Play mode.
		///     Depending on editor vs play mode it calls either DestroyImmediate or Destroy.
		/// </summary>
		/// <remarks>
		///     In Builds this is a direct inlined call to Object.Destroy and no condition test.
		/// </remarks>
		/// <remarks>
		///     Transforms cannot be destroyed, Unity throws an error if you try.
		///     This extension works under the assumption that the intention is to destroy the
		///     GameObject so you don't have to remember to do: t.gameObject.Destroy();
		/// </remarks>
		/// <param name="self"></param>
#if UNITY_EDITOR
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyInAnyMode(this Transform self)
		{
			if (Application.isPlaying == false)
				Object.DestroyImmediate(self.gameObject);
			else
				Object.Destroy(self.gameObject);
		}
#else
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyInAnyMode(this Transform self) =>
			Object.Destroy(self.gameObject);
#endif

		// public static Transform FindOrCreateChild(this Transform parent, String name,
		// 	HideFlags hideFlags = HideFlags.None)
		// {
		// 	var t = parent.Find(name);
		// 	if (t != null)
		// 		return t;
		//
		// 	return new GameObject(name)
		// 	{
		// 		hideFlags = hideFlags,
		// 		transform = { parent = parent.transform },
		// 	}.transform;
		// }
	}
}
