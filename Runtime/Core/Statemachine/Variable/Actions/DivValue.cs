// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine.Variable.Actions
{
	/// <summary>
	///     Divides the variable by a value.
	/// </summary>
	public sealed class DivValue : IAction
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Operand;

		private DivValue() {} // forbidden default ctor

		/// <summary>
		///     Divide variable by value.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="value"></param>
		public DivValue(IntVar variable, Int32 value)
			: this(variable, new IntVar(value)) {}

		/// <summary>
		///     Divide variable by another variable's value.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public DivValue(IntVar variable, IntVar operand)
			: this((VariableBase)variable, operand) {}

		/// <summary>
		///     Divide variable by value.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public DivValue(FloatVar variable, Int32 value)
			: this(variable, new FloatVar(value)) {}

		/// <summary>
		///     Divide variable by value.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public DivValue(FloatVar variable, Single value)
			: this(variable, new FloatVar(value)) {}

		/// <summary>
		///     Divide variable by another variable's value.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public DivValue(FloatVar variable, FloatVar operand)
			: this((VariableBase)variable, operand) {}

		private DivValue(VariableBase variable, VariableBase operand)
		{
			m_Variable = variable;
			m_Operand = operand;
		}

		public void Execute(FSM sm) => m_Variable.DivideValue(m_Operand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = {m_Operand}";
	}
}
