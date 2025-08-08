// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Conditions
{
	/// <summary>
	///     Logically combines the contained conditions with NAND (NOT AND).
	/// </summary>
	public sealed class LogicalNand : ICondition
	{
		private readonly ICondition m_AndCondition;

		private LogicalNand() {} // forbidden default ctor

		internal LogicalNand(params ICondition[] nandConditions) => m_AndCondition = new LogicalAnd(nandConditions);

		public Boolean IsSatisfied(FSM sm) => !m_AndCondition.IsSatisfied(sm);

		public String ToDebugString(FSM sm) => $"N{m_AndCondition.ToDebugString(sm)}";

		public void OnStart(FSM sm) => m_AndCondition.OnStart(sm);
		public void OnStop(FSM sm) => m_AndCondition.OnStop(sm);
		public void OnEnterState(FSM sm) => m_AndCondition.OnEnterState(sm);
		public void OnExitState(FSM sm) => m_AndCondition.OnExitState(sm);
	}
}
