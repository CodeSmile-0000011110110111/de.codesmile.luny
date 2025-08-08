// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Variable.Actions
{
	/// <summary>
	///     Sets a bool variable to false.
	/// </summary>
	public sealed class SetFalse : IAction
	{
		private readonly BoolVar m_Variable;

		private SetFalse() {} // forbidden default ctor
		public SetFalse(BoolVar variable) => m_Variable = variable;

		public void Execute(FSM sm) => m_Variable.Value = false;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = false";
	}
}
