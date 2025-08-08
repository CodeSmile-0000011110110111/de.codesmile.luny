// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Conditions
{
	/// <summary>
	///     Logically combines the contained conditions with NOR (NOT OR).
	/// </summary>
	public sealed class LogicalNor : ICondition
	{
		private readonly ICondition m_OrCondition;

		private LogicalNor() {} // forbidden default ctor

		internal LogicalNor(params ICondition[] norConditions) => m_OrCondition = new LogicalOr(norConditions);

		public Boolean IsSatisfied(FSM sm) => !m_OrCondition.IsSatisfied(sm);

		public String ToDebugString(FSM sm) => $"N{m_OrCondition.ToDebugString(sm)}";

		public void OnStart(FSM sm) => m_OrCondition.OnStart(sm);
		public void OnStop(FSM sm) => m_OrCondition.OnStop(sm);
		public void OnEnterState(FSM sm) => m_OrCondition.OnEnterState(sm);
		public void OnExitState(FSM sm) => m_OrCondition.OnExitState(sm);
	}
}
