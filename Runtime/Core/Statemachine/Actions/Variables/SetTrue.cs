// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Actions
{
	/// <summary>
	///     Sets a bool variable to true.
	/// </summary>
	public sealed class SetTrue : IAction
	{
		private readonly BoolVar m_Variable;

		private SetTrue() {} // forbidden default ctor
		public SetTrue(BoolVar variable) => m_Variable = variable;

		public void Execute(FSM sm) => m_Variable.Value = true;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = true";
	}
}
