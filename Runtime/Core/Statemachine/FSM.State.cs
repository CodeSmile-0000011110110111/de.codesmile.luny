// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

namespace Luny.Statemachine
{
	public sealed partial class FSM
	{
		/// <summary>
		///     Represents a state in a statemachine.
		/// </summary>
		public sealed class State : IEquatable<State>
		{
			private Transition[] m_Transitions;

			internal Transition[] Transitions => m_Transitions;

			/// <summary>
			///     The State's name.
			/// </summary>
			public String Name { get; }
			/// <summary>
			///     Whether this state has logging enabled.
			/// </summary>
			public Boolean Logging { get; set; }

			/// <summary>
			///     Equality operator
			/// </summary>
			/// <param name="left"></param>
			/// <param name="right"></param>
			/// <returns></returns>
			public static Boolean operator ==(State left, State right) => Equals(left, right);

			/// <summary>
			///     Inequality operator
			/// </summary>
			/// <param name="left"></param>
			/// <param name="right"></param>
			/// <returns></returns>
			public static Boolean operator !=(State left, State right) => !Equals(left, right);

			private State() {} // forbidden default ctor

			/// <summary>
			///     Create a new named state.
			/// </summary>
			/// <param name="stateName"></param>
			public State(String stateName) => Name = stateName;

			public Boolean Equals(State other)
			{
				if (ReferenceEquals(null, other))
					return false;
				if (ReferenceEquals(this, other))
					return true;

				return Name == other.Name;
			}

			public override String ToString() => $"State({Name})";

			/// <summary>
			///     Add an empty transition to this state.
			/// </summary>
			/// <returns></returns>
			public Transition AddTransition() => AddTransition(new Transition());

			/// <summary>
			///     Add a named transition to this state.
			/// </summary>
			/// <param name="transitionName"></param>
			/// <returns></returns>
			public Transition AddTransition(String transitionName) => AddTransition(new Transition(transitionName));

			/// <summary>
			///     Add the given transition.
			/// </summary>
			/// <param name="transition"></param>
			/// <returns></returns>
			public Transition AddTransition(Transition transition)
			{
				AddTransitions(transition);
				return transition;
			}

			/// <summary>
			///     Add multiple transitions.
			/// </summary>
			/// <param name="transitions"></param>
			/// <returns></returns>
			/// <exception cref="ArgumentException"></exception>
			public State AddTransitions(params Transition[] transitions)
			{
				if (transitions == null || transitions.Length == 0)
					throw new ArgumentException("transitions null or empty");

				if (m_Transitions == null)
					m_Transitions = transitions;
				else
				{
					var startIndex = m_Transitions.Length;
					var addCount = transitions.Length;
					Array.Resize(ref m_Transitions, startIndex + addCount);

					for (var i = 0; i < addCount; i++)
						m_Transitions[startIndex + i] = transitions[i];
				}

				return this;
			}

			/// <summary>
			///     Is true if the State has no conditions. It is a so-called final state from which there is no return.
			///     Such a state ends the statemachine.
			/// </summary>
			/// <returns></returns>
			public Boolean IsFinalState() => Transitions.Length == 0;

			/// <summary>
			///     Updating the state will update all its transitions.
			/// </summary>
			/// <param name="sm"></param>
			public async Task Update(FSM sm)
			{
				foreach (var transition in Transitions)
				{
					await transition.Update(sm);

					// stop evaluating further transitions if the current transition caused a state change
					if (sm.DidChangeState)
						break;
				}
			}

			internal void OnStart(FSM sm)
			{
				if (m_Transitions == null)
					m_Transitions = new Transition[0];

				foreach (var transition in Transitions)
					transition.OnStart(sm);
			}

			internal void OnStop(FSM sm)
			{
				foreach (var transition in Transitions)
					transition.OnStop(sm);
			}

			internal void OnExitState(FSM sm)
			{
				foreach (var transition in Transitions)
					transition.OnExitState(sm);
			}

			internal void OnEnterState(FSM sm)
			{
				foreach (var transition in Transitions)
					transition.OnEnterState(sm);
			}

			public override Boolean Equals(Object obj) => ReferenceEquals(this, obj) || obj is State other && Equals(other);

			public override Int32 GetHashCode() => Name.GetHashCode();
		}
	}
}
