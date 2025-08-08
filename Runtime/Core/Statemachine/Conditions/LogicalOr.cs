// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Conditions
{
	/// <summary>
	///     Logically combines the contained conditions with OR.
	/// </summary>
	public sealed class LogicalOr : ICondition
	{
		private readonly ICondition[] m_InnerConditions;
		internal ICondition[] InnerConditions => m_InnerConditions;

		private static void VerifyParameters(ICondition[] orConditions)
		{
#if DEBUG || DEVELOPMENT_BUILD
			if (orConditions == null)
				throw new ArgumentNullException(nameof(orConditions));
			if (orConditions.Length < 2)
				throw new ArgumentException("OR: at least two conditions required!");

			foreach (var cond in orConditions)
			{
				if (cond == null)
					throw new ArgumentNullException($"{nameof(orConditions)} contains null");
			}
#endif
		}

		private LogicalOr() {} // forbidden default ctor

		internal LogicalOr(params ICondition[] orConditions)
		{
			VerifyParameters(orConditions);
			m_InnerConditions = orConditions;
		}

		public Boolean IsSatisfied(FSM sm) => FSM.Transition.ConditionsSatisfied(sm, null, InnerConditions, sm.ActiveState.Logging, true);

		public void OnStart(FSM sm)
		{
			foreach (var condition in InnerConditions)
				condition.OnStart(sm);
		}

		public void OnStop(FSM sm)
		{
			foreach (var condition in InnerConditions)
				condition.OnStop(sm);
		}

		public void OnEnterState(FSM sm)
		{
			foreach (var condition in InnerConditions)
				condition.OnEnterState(sm);
		}

		public void OnExitState(FSM sm)
		{
			foreach (var condition in InnerConditions)
				condition.OnExitState(sm);
		}

		public String ToDebugString(FSM sm)
		{
			var sb = new StringBuilder("OR(");
			for (var i = 0; i < m_InnerConditions.Length; i++)
			{
				if (i > 0)
					sb.Append("\\n      ");
				sb.Append(m_InnerConditions[i].ToDebugString(sm));
			}
			sb.Append(")");
			return sb.ToString();
		}
	}
}
