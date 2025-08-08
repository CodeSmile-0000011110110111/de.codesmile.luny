// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Variable.Conditions
{
	/// <summary>
	///     Tests if a bool variable is false.
	/// </summary>
	public sealed class IsFalse : ICondition
	{
		private readonly BoolVar m_Variable;

		private IsFalse() {} // forbidden default ctor
		public IsFalse(BoolVar variable) => m_Variable = variable;

		public Boolean IsSatisfied(FSM sm) => m_Variable.Value == false;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} == false";
	}
}
