// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Variable.Conditions
{
	/// <summary>
	///     Tests if a variable is not equal to a value or another variable.
	/// </summary>
	public sealed class IsNotEqual : ICondition
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Comparand;

		private IsNotEqual() {} // forbidden default ctor

		public IsNotEqual(BoolVar variable, Boolean compareValue)
			: this(variable, new BoolVar(compareValue)) {}

		public IsNotEqual(IntVar variable, Int32 compareValue)
			: this(variable, new IntVar(compareValue)) {}

		public IsNotEqual(FloatVar variable, Int32 compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsNotEqual(FloatVar variable, Single compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsNotEqual(BoolVar variable, BoolVar comparand)
			: this((VariableBase)variable, comparand) {}

		public IsNotEqual(IntVar variable, IntVar comparand)
			: this((VariableBase)variable, comparand) {}

		public IsNotEqual(FloatVar variable, FloatVar comparand)
			: this((VariableBase)variable, comparand) {}

		private IsNotEqual(VariableBase variable, VariableBase comparand)
		{
			m_Variable = variable;
			m_Comparand = comparand;
		}

		public Boolean IsSatisfied(FSM sm) => !m_Variable.Equals(m_Comparand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} != {m_Comparand}";
	}
}
