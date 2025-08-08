// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Actions
{
	/// <summary>
	///     Subtracts variable by a value.
	/// </summary>
	public sealed class SubValue : IAction
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Operand;

		private SubValue() {} // forbidden default ctor

		public SubValue(IntVar variable, Int32 value)
			: this(variable, new IntVar(value)) {}

		public SubValue(IntVar variable, IntVar operand)
			: this((VariableBase)variable, operand) {}

		public SubValue(FloatVar variable, Int32 value)
			: this(variable, new FloatVar(value)) {}

		public SubValue(FloatVar variable, Single value)
			: this(variable, new FloatVar(value)) {}

		public SubValue(FloatVar variable, FloatVar operand)
			: this((VariableBase)variable, operand) {}

		private SubValue(VariableBase variable, VariableBase operand)
		{
			m_Variable = variable;
			m_Operand = operand;
		}

		public void Execute(FSM sm) => m_Variable.SubtractValue(m_Operand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = {m_Operand}";
	}
}
