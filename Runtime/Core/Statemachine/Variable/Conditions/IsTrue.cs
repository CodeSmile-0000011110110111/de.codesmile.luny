// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Variable.Conditions
{
	/// <summary>
	///     Tests if a bool variable is true.
	/// </summary>
	public sealed class IsTrue : ICondition
	{
		private readonly BoolVar m_Variable;

		private IsTrue() {} // forbidden default ctor
		public IsTrue(BoolVar variable) => m_Variable = variable;

		public Boolean IsSatisfied(FSM sm) => m_Variable.Value;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} == true";
	}
}
