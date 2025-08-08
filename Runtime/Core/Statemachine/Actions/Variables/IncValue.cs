// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Actions
{
	/// <summary>
	///     Increments an integer value by 1.
	/// </summary>
	public sealed class IncValue : IAction
	{
		private readonly IntVar m_Variable;

		private IncValue() {} // forbidden default ctor

		private IncValue(IntVar variable) => m_Variable = variable;

		public void Execute(FSM sm) => m_Variable.Value++;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)}++";
	}
}
