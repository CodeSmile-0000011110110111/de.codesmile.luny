// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Variable.Conditions
{
	/// <summary>
	///     Tests if a variable is greater than a value or another variable.
	/// </summary>
	public sealed class IsGreater : ICondition
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Comparand;

		private IsGreater() {} // forbidden default ctor

		public IsGreater(IntVar variable, Int32 compareValue)
			: this(variable, new IntVar(compareValue)) {}

		public IsGreater(FloatVar variable, Single compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsGreater(FloatVar variable, Int32 compareValue)
			: this(variable, new FloatVar(compareValue)) {}

		public IsGreater(IntVar variable, IntVar comparand)
			: this((VariableBase)variable, comparand) {}

		public IsGreater(FloatVar variable, FloatVar comparand)
			: this((VariableBase)variable, comparand) {}

		private IsGreater(VariableBase variable, VariableBase comparand)
		{
			m_Variable = variable;
			m_Comparand = comparand;
		}

		public Boolean IsSatisfied(FSM sm) => m_Variable > m_Comparand;

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} > {m_Comparand}";
	}
}
