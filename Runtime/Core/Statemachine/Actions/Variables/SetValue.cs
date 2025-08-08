// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Actions
{
	/// <summary>
	///     Assigns a value to the variable.
	/// </summary>
	public sealed class SetValue : IAction
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Operand;

		private SetValue() {} // forbidden default ctor

		public SetValue(IntVar variable, Int32 value)
			: this(variable, new IntVar(value)) {}

		public SetValue(IntVar variable, IntVar operand)
			: this((VariableBase)variable, operand) {}

		public SetValue(FloatVar variable, Int32 value)
			: this(variable, new FloatVar(value)) {}

		public SetValue(FloatVar variable, Single value)
			: this(variable, new FloatVar(value)) {}

		public SetValue(FloatVar variable, FloatVar operand)
			: this((VariableBase)variable, operand) {}

		public SetValue(VariableBase variable, VariableBase operand)
		{
			m_Variable = variable;
			m_Operand = operand;
		}

		public void Execute(FSM sm) => m_Variable.SetValue(m_Operand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = {m_Operand}";
	}
}
