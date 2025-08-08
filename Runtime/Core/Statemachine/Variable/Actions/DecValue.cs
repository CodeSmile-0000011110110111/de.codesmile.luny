// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Variable.Actions
{
	/// <summary>
	///     Decrements an integer variable by 1.
	/// </summary>
	public sealed class DecValue : IAction
	{
		private readonly IntVar m_Variable;

		private DecValue() {} // forbidden default ctor

		private DecValue(IntVar variable) => m_Variable = variable;

		public void Execute(FSM sm) => m_Variable.Value--;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)}--";
	}
}
