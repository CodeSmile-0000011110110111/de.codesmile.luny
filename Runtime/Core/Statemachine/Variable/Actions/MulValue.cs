// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Variable.Actions
{
	/// <summary>
	///     Multiplies variable by a value.
	/// </summary>
	public sealed class MulValue : IAction
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Operand;

		private MulValue() {} // forbidden default ctor

		public MulValue(IntVar variable, Int32 value)
			: this(variable, new IntVar(value)) {}

		public MulValue(IntVar variable, IntVar operand)
			: this((VariableBase)variable, operand) {}

		public MulValue(FloatVar variable, Int32 value)
			: this(variable, new FloatVar(value)) {}

		public MulValue(FloatVar variable, Single value)
			: this(variable, new FloatVar(value)) {}

		public MulValue(FloatVar variable, FloatVar operand)
			: this((VariableBase)variable, operand) {}

		private MulValue(VariableBase variable, VariableBase operand)
		{
			m_Variable = variable;
			m_Operand = operand;
		}

		public void Execute(FSM sm) => m_Variable.MultiplyValue(m_Operand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = {m_Operand}";
	}
}
