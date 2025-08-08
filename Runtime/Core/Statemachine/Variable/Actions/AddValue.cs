// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Variable.Actions
{
	/// <summary>
	///     Adds a value to a variable.
	/// </summary>
	public sealed class AddValue : IAction
	{
		private readonly VariableBase m_Variable;
		private readonly VariableBase m_Operand;

		private AddValue() {} // forbidden default ctor

		/// <summary>
		///     Will add the value to the variable.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="value"></param>
		public AddValue(IntVar variable, Int32 value)
			: this(variable, new IntVar(value)) {}

		/// <summary>
		///     Will add another variable's value to the variable.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public AddValue(IntVar variable, IntVar operand)
			: this((VariableBase)variable, operand) {}

		/// <summary>
		///     Will add an int value to the variable.
		/// </summary>
		/// <remarks>Convenience because not everyone is disciplined in suffixing integral float values with f (eg "1f").</remarks>
		/// <param name="variable"></param>
		/// <param name="value"></param>
		public AddValue(FloatVar variable, Int32 value)
			: this(variable, new FloatVar(value)) {}

		/// <summary>
		///     Will add a value to the variable.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="value"></param>
		public AddValue(FloatVar variable, Single value)
			: this(variable, new FloatVar(value)) {}

		/// <summary>
		///     Will add another variable's value to the variable.
		/// </summary>
		/// <param name="variable"></param>
		/// <param name="operand"></param>
		public AddValue(FloatVar variable, FloatVar operand)
			: this((VariableBase)variable, operand) {}

		private AddValue(VariableBase variable, VariableBase operand)
		{
			m_Variable = variable;
			m_Operand = operand;
		}

		public void Execute(FSM sm) => m_Variable.AddValue(m_Operand);

		public String ToDebugString(FSM sm) => $"{sm.GetDebugVarName(m_Variable)} = {m_Operand}";
	}
}
