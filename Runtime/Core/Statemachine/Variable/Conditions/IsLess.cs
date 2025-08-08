// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Variable.Conditions
{
	/// <summary>
	///     Tests if a variable is less than a value or another variable.
	/// </summary>
	public sealed class IsLess : ICondition
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Comparand;

		private IsLess() {} // forbidden default ctor

		public IsLess(IntVar variable, Int32 compareValue)
			: this(variable, new IntVar(compareValue)) {}

		public IsLess(FloatVar variable, Single compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsLess(FloatVar variable, Int32 compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsLess(IntVar variable, IntVar comparand)
			: this((VariableBase)variable, comparand) {}

		public IsLess(FloatVar variable, FloatVar comparand)
			: this((VariableBase)variable, comparand) {}

		private IsLess(VariableBase variable, VariableBase comparand)
		{
			m_Variable = variable;
			m_Comparand = comparand;
		}

		public Boolean IsSatisfied(FSM sm) => m_Variable < m_Comparand;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} < {m_Comparand}";
	}
}
