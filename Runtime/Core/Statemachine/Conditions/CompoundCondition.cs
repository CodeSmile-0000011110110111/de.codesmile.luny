// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Conditions
{
	/// <summary>
	///     Used to combine multiple FSM conditions into a single, named condition.
	/// </summary>
	public sealed class CompoundCondition : ICondition
	{
		private readonly String m_Name;
		private readonly ICondition[] m_Conditions;

		private CompoundCondition() {}

		/// <summary>
		///     Create a combined condition from one or more conditions.
		/// </summary>
		/// <param name="conditions"></param>
		public CompoundCondition(params ICondition[] conditions)
			: this(null, conditions) {}

		/// <summary>
		///     Create a named combined condition from one or more conditions.
		/// </summary>
		/// <param name="name">Meaningful display/debug name.</param>
		/// <param name="conditions"></param>
		/// <exception cref="ArgumentException"></exception>
		public CompoundCondition(String name, params ICondition[] conditions)
		{
			if (conditions == null || conditions.Length == 0)
				throw new ArgumentException("conditions null or empty");

			m_Name = name;
			m_Conditions = conditions;
		}

		public Boolean IsSatisfied(FSM sm) => FSM.Transition.ConditionsSatisfied(sm, null, m_Conditions, sm.ActiveState.Logging);

		public String ToDebugString(FSM sm)
		{
			if (String.IsNullOrWhiteSpace(m_Name) == false)
				return m_Name;

			var sb = new StringBuilder();
			foreach (var condition in m_Conditions)
				sb.AppendLine(condition.ToDebugString(sm));

			return sb.ToString();
		}
	}
}
