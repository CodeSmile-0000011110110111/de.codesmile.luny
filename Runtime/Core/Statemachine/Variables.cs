// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace CodeSmile.Statemachine
{
	/// <summary>
	///     FSM variables container.
	/// </summary>
	public class Variables
	{
		private readonly Dictionary<String, VariableBase> m_Variables = new();

		/// <summary>
		///     Return a variable by its name.
		/// </summary>
		/// <param name="variableName"></param>
		public VariableBase this[String variableName] => m_Variables[variableName];

		/// <summary>
		///     Removes all variables.
		/// </summary>
		public void Clear() => m_Variables.Clear();

		internal String FindVariableName(VariableBase variable) => m_Variables.FirstOrDefault(kvp => kvp.Value == variable).Key;

		private T AddVariable<T>(String name, T variable) where T : VariableBase
		{
			m_Variables.Add(name, variable);
			return variable;
		}

		/// <summary>
		///     Adds a variable with an optional initial value.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public BoolVar DefineBool(String name, Boolean value = default) => AddVariable(name, new BoolVar(value));

		/// <summary>
		///     Gets a bool variable by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public BoolVar GetBool(String name) => m_Variables[name] as BoolVar;

		/// <summary>
		///     Adds a variable with an optional initial value.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public IntVar DefineInt(String name, Int32 value = default) => AddVariable(name, new IntVar(value));

		/// <summary>
		///     Gets an int variable by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public IntVar GetInt(String name) => m_Variables[name] as IntVar;

		/// <summary>
		///     Adds a variable with an optional initial value.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FloatVar DefineFloat(String name, Single value = default) => AddVariable(name, new FloatVar(value));

		/// <summary>
		///     Adds a variable with an optional initial value.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public FloatVar DefineFloat(String name, Int32 value) => AddVariable(name, new FloatVar(value));

		/// <summary>
		///     Gets a float variable by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public FloatVar GetFloat(String name) => m_Variables[name] as FloatVar;

		/// <summary>
		///     Adds a generic variable with an optional initial value.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public Var<T> DefineVar<T>() where T : struct => AddVariable(typeof(T).Name, new Var<T>());

		/// <summary>
		///     Adds a generic variable with an optional initial value.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public Var<T> DefineVar<T>(String name, T value = default) where T : struct => AddVariable(name, new Var<T>(value));

		/// <summary>
		///     Gets a generic variable by its name.
		/// </summary>
		/// <param name="name"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public Var<T> GetVar<T>(String name) where T : struct => m_Variables[name] as Var<T>;
	}

	/// <summary>
	///     Base class for all FSM variables.
	/// </summary>
	public abstract class VariableBase
	{
		/// <summary>
		///     equality operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static Boolean operator ==(VariableBase left, VariableBase right) => Equals(left, right);

		/// <summary>
		///     inequality operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static Boolean operator !=(VariableBase left, VariableBase right) => !Equals(left, right);

		/// <summary>
		///     less operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public static Boolean operator <(VariableBase left, VariableBase right)
		{
			if (left is IntVar leftInt && right is IntVar rightInt)
				return leftInt < rightInt;
			if (left is FloatVar leftFloat && right is FloatVar rightFloat)
				return leftFloat < rightFloat;

			throw new InvalidOperationException(GetCompareExceptionMessage(left, right, "<"));
		}

		/// <summary>
		///     greater operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public static Boolean operator >(VariableBase left, VariableBase right)
		{
			if (left is IntVar leftInt && right is IntVar rightInt)
				return leftInt > rightInt;
			if (left is FloatVar leftFloat && right is FloatVar rightFloat)
				return leftFloat > rightFloat;

			throw new InvalidOperationException(GetCompareExceptionMessage(left, right, ">"));
		}

		/// <summary>
		///     less or equal operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public static Boolean operator <=(VariableBase left, VariableBase right)
		{
			if (left is IntVar leftInt && right is IntVar rightInt)
				return leftInt <= rightInt;
			if (left is FloatVar leftFloat && right is FloatVar rightFloat)
				return leftFloat <= rightFloat;

			throw new InvalidOperationException(GetCompareExceptionMessage(left, right, "<="));
		}

		/// <summary>
		///     greater or equal operator
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public static Boolean operator >=(VariableBase left, VariableBase right)
		{
			if (left is IntVar leftInt && right is IntVar rightInt)
				return leftInt >= rightInt;
			if (left is FloatVar leftFloat && right is FloatVar rightFloat)
				return leftFloat >= rightFloat;

			throw new InvalidOperationException(GetCompareExceptionMessage(left, right, ">="));
		}

		private static String GetCompareExceptionMessage(VariableBase left, VariableBase right, String op) =>
			$"cannot compare: {left?.GetType().Name}({left}) {op} {right?.GetType().Name}({right})";

		public override Boolean Equals(Object obj) => throw new NotImplementedException();
		public override Int32 GetHashCode() => throw new NotImplementedException();

		/// <summary>
		///     Assigns the variable's value.
		/// </summary>
		/// <param name="variable"></param>
		public abstract void SetValue(VariableBase variable);

		/// <summary>
		///     Adds the variable's value.
		/// </summary>
		/// <param name="variable"></param>
		public abstract void AddValue(VariableBase variable);

		/// <summary>
		///     Subtracts the variable's value.
		/// </summary>
		/// <param name="variable"></param>
		public abstract void SubtractValue(VariableBase variable);

		/// <summary>
		///     Multiplies with the variable's value.
		/// </summary>
		/// <param name="variable"></param>
		public abstract void MultiplyValue(VariableBase variable);

		/// <summary>
		///     Divides by the variable's value.
		/// </summary>
		/// <param name="variable"></param>
		public abstract void DivideValue(VariableBase variable);
	}

	/// <summary>
	///     Represents a boolean FSM variable.
	/// </summary>
	public sealed class BoolVar : VariableBase, IEquatable<BoolVar>
	{
		public Boolean Value { get; set; }
		public BoolVar(Boolean value = default) => Value = value;
		public Boolean Equals(BoolVar other) => !ReferenceEquals(null, other) && Value == other.Value;
		public override Boolean Equals(Object obj) => obj is BoolVar other && Equals(other);
		public override Int32 GetHashCode() => Value.GetHashCode();
		public override String ToString() => Value.ToString();

		public override void SetValue(VariableBase variable) => Value = ((BoolVar)variable).Value;
		public override void AddValue(VariableBase variable) => throw new NotSupportedException();
		public override void SubtractValue(VariableBase variable) => throw new NotSupportedException();
		public override void MultiplyValue(VariableBase variable) => throw new NotSupportedException();
		public override void DivideValue(VariableBase variable) => throw new NotSupportedException();
	}

	/// <summary>
	///     Represents an integer FSM variable.
	/// </summary>
	public sealed class IntVar : VariableBase, IEquatable<IntVar>
	{
		public Int32 Value { get; set; }
		public static Boolean operator <(IntVar left, IntVar right) => left.Value < right.Value;
		public static Boolean operator >(IntVar left, IntVar right) => left.Value > right.Value;
		public static Boolean operator <=(IntVar left, IntVar right) => left.Value <= right.Value;
		public static Boolean operator >=(IntVar left, IntVar right) => left.Value >= right.Value;
		public IntVar(Int32 value = default) => Value = value;
		public Boolean Equals(IntVar other) => !ReferenceEquals(null, other) && Value.Equals(other.Value);
		public override Boolean Equals(Object obj) => obj is IntVar other && Equals(other);
		public override Int32 GetHashCode() => Value;
		public override String ToString() => Value.ToString();

		public override void SetValue(VariableBase variable) => Value = ((IntVar)variable).Value;
		public override void AddValue(VariableBase variable) => Value += ((IntVar)variable).Value;
		public override void SubtractValue(VariableBase variable) => Value -= ((IntVar)variable).Value;
		public override void MultiplyValue(VariableBase variable) => Value *= ((IntVar)variable).Value;
		public override void DivideValue(VariableBase variable) => Value /= ((IntVar)variable).Value;
	}

	/// <summary>
	///     Represents a float FSM variable.
	/// </summary>
	public sealed class FloatVar : VariableBase, IEquatable<FloatVar>
	{
		public Single Value { get; set; }
		public static Boolean operator <(FloatVar left, FloatVar right) => left.Value < right.Value;
		public static Boolean operator >(FloatVar left, FloatVar right) => left.Value > right.Value;
		public static Boolean operator <=(FloatVar left, FloatVar right) => left.Value <= right.Value;
		public static Boolean operator >=(FloatVar left, FloatVar right) => left.Value >= right.Value;
		public FloatVar(Single value = default) => Value = value;
		public Boolean Equals(FloatVar other) => !ReferenceEquals(null, other) && Value.Equals(other.Value);
		public override Boolean Equals(Object obj) => obj is FloatVar other && Equals(other);
		public override Int32 GetHashCode() => Value.GetHashCode();
		public override String ToString() => Value.ToString();

		public override void SetValue(VariableBase variable) => Value = ((FloatVar)variable).Value;
		public override void AddValue(VariableBase variable) => Value += ((FloatVar)variable).Value;
		public override void SubtractValue(VariableBase variable) => Value -= ((FloatVar)variable).Value;
		public override void MultiplyValue(VariableBase variable) => Value *= ((FloatVar)variable).Value;
		public override void DivideValue(VariableBase variable) => Value /= ((FloatVar)variable).Value;
	}

	/// <summary>
	///     Represents a generic (struct) FSM variable.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class Var<T> : VariableBase, IEquatable<Var<T>> where T : struct
	{
		public T Value { get; set; }
		public Var(T value = default) => Value = value;
		public Boolean Equals(Var<T> other) => !ReferenceEquals(null, other) && Value.Equals(other.Value);
		public override Boolean Equals(Object obj) => obj is Var<T> other && Equals(other);
		public override Int32 GetHashCode() => Value.GetHashCode();
		public override String ToString() => Value.ToString();

		public override void SetValue(VariableBase variable) => Value = ((Var<T>)variable).Value;
		public override void AddValue(VariableBase variable) => throw new NotSupportedException();
		public override void SubtractValue(VariableBase variable) => throw new NotSupportedException();
		public override void MultiplyValue(VariableBase variable) => throw new NotSupportedException();
		public override void DivideValue(VariableBase variable) => throw new NotSupportedException();
	}
}
