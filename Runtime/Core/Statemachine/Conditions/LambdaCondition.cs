// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Conditions
{
	/// <summary>
	///     Generic Condition that simply executes a lambda (System.Func&lt;bool&gt;).
	/// </summary>
	/// <remarks>
	///     This allows for quick and dirty tests but should be avoided for production code, as using a custom ICondition
	///     implementation will provide re-usability and make the intent of the Condition clear, specifically in logs.
	/// </remarks>
	public sealed class LambdaCondition : ICondition
	{
		private readonly String m_Name;
		private readonly Func<Boolean> m_Callback;

		private LambdaCondition() {} // forbidden default ctor

		/// <summary>
		///     Creates a LambdaCondition with a callback returning a bool.
		/// </summary>
		/// <param name="callback"></param>
		public LambdaCondition(Func<Boolean> callback)
			: this(null, callback) {}

		/// <summary>
		///     Creates a named LambdaCondition with a callback returning a bool.
		/// </summary>
		/// <param name="name">Meaningful display/debug name.</param>
		/// <param name="callback"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public LambdaCondition(String name, Func<Boolean> callback)
		{
			if (callback == null)
				throw new ArgumentNullException(nameof(callback));

			m_Name = name;
			m_Callback = callback;
		}

		public Boolean IsSatisfied(FSM sm) => m_Callback.Invoke();

		public String ToDebugString(FSM sm) => String.IsNullOrWhiteSpace(m_Name) ? GetType().Name : m_Name;
	}
}
