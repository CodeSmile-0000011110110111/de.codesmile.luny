// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Statemachine
{
	public sealed partial class FSM
	{
		/// <summary>
		///     Represents a transition in a statemachine. A transition can also be a self-transition that does not change state.
		/// </summary>
		public sealed class Transition
		{
			/// <summary>
			///     The transition's name.
			/// </summary>
			public String Name { get; }
			internal ICondition[] Conditions { get; private set; }
			internal IAction[] Actions { get; private set; }
			internal State GotoState { get; private set; }

			internal State ErrorGotoState { get; private set; }
			internal IAction[] ErrorActions { get; private set; }

			internal static Boolean ConditionsSatisfied(FSM sm, String transitionName, ICondition[] conditions, Boolean logging,
				Boolean useLogicalOr = false)
			{
				foreach (var condition in conditions)
				{
					var satisfied = condition.IsSatisfied(sm);

					if (logging)
						LogCondition(sm, transitionName, condition, satisfied);

					// early out checks
					if (useLogicalOr)
					{
						if (satisfied) // OR: if one is true
							return true;
					}
					else if (!satisfied) // AND: if none are false
						return false;
				}

				// if we get here: OR = all condition were false / AND = all conditions were true
				return useLogicalOr ? false : true;
			}

			internal static async Task ExecuteActions(FSM sm, String transitionName, IAction[] actions, Boolean logging = false)
			{
				if (actions == null)
					return;

				var actionCount = actions.Length;
				if (actionCount == 0)
					return;

				for (var i = 0; i < actionCount; i++)
				{
					var action = actions[i];

					if (logging)
						LogExecuteAction(sm, transitionName, action);

					if (action is IAsyncAction asyncAction)
						await asyncAction.ExecuteAsync(sm);
					else
						action.Execute(sm);
				}
			}

			/// <summary>
			///     Creates an unnamed transition that executes its actions if its conditions are satisfied.
			///     If GotoState is non-null will also change state if conditions are satisfied.
			/// </summary>
			public Transition()
				: this(null) {}

			/// <summary>
			///     Creates a named transition that executes its actions if its conditions are satisfied.
			///     If GotoState is non-null will also change state if conditions are satisfied.
			/// </summary>
			/// <remarks>
			///     The transition name should be used to annotate or summarize the purpose of the transition.
			///     The name is also instrumental for debugging and appears in diagrams.
			/// </remarks>
			/// <param name="transitionName"></param>
			public Transition(String transitionName) => Name = transitionName;

			public override String ToString() => $"Transition({Name})";

			/// <summary>
			///     Sets the destination state.
			/// </summary>
			/// <param name="gotoState"></param>
			/// <returns></returns>
			/// <exception cref="InvalidOperationException"></exception>
			public Transition ToState(State gotoState)
			{
				if (GotoState != null)
					throw new InvalidOperationException("GotoState already set");

				GotoState = gotoState;
				return this;
			}

			/// <summary>
			///     Sets the error state.
			/// </summary>
			/// <param name="errorState"></param>
			/// <returns></returns>
			/// <exception cref="InvalidOperationException"></exception>
			public Transition ToErrorState(State errorState)
			{
				if (ErrorGotoState != null)
					throw new InvalidOperationException("ErrorGotoState already set");

				ErrorGotoState = errorState;
				return this;
			}

			/// <summary>
			///     Adds a transition to multiple states (re-use).
			/// </summary>
			/// <remarks>
			///     This will not create copies of the transition or its actions/conditions.
			/// </remarks>
			/// <param name="states"></param>
			/// <returns></returns>
			/// <exception cref="ArgumentNullException"></exception>
			public Transition AddToStates(params State[] states)
			{
				if (states == null)
					throw new ArgumentNullException(nameof(states));

				foreach (var state in states)
					state.AddTransitions(this);

				return this;
			}

			/// <summary>
			///     Add conditions to the transition.
			/// </summary>
			/// <param name="conditions"></param>
			/// <returns></returns>
			/// <exception cref="InvalidOperationException"></exception>
			public Transition WithConditions(params ICondition[] conditions)
			{
				if (Conditions != null)
					throw new InvalidOperationException("Conditions already set");

				Conditions = conditions ?? new ICondition[0];
				return this;
			}

			/// <summary>
			///     Add actions to the transition.
			/// </summary>
			/// <param name="actions"></param>
			/// <returns></returns>
			/// <exception cref="InvalidOperationException"></exception>
			public Transition WithActions(params IAction[] actions)
			{
				if (Actions != null)
					throw new InvalidOperationException("Actions already set");

				Actions = actions ?? new IAction[0];
				return this;
			}

			/// <summary>
			///     Add error actions that run when an exception occurs.
			/// </summary>
			/// <param name="errorActions"></param>
			/// <returns></returns>
			/// <exception cref="InvalidOperationException"></exception>
			public Transition WithErrorActions(params IAction[] errorActions)
			{
				if (ErrorActions != null)
					throw new InvalidOperationException("ErrorActions already set");

				ErrorActions = errorActions ?? new IAction[0];
				return this;
			}

			internal async Task Update(FSM sm)
			{
				var logging = sm.ActiveState.Logging;
				if (ConditionsSatisfied(sm, Name, Conditions, logging))
				{
					await ExecuteActionsWithErrorHandling(sm, Actions, logging);

					if (GotoState != null)
					{
						if (logging)
							LogStateChange(sm, GotoState, Name);

						sm.SetActiveState(GotoState);
					}
				}
			}

			private async Task ExecuteActionsWithErrorHandling(FSM sm, IAction[] actions, Boolean logging)
			{
				try
				{
					await ExecuteActions(sm, Name, actions, logging);
				}
				catch (Exception e)
				{
					if (ErrorActions != null || ErrorGotoState != null)
					{
						Debug.LogWarning($"{sm.ActiveState.Name} [{Name}]: ERROR => {e}");

						await ExecuteActions(sm, Name, ErrorActions, logging);

						if (ErrorGotoState != null)
						{
							if (logging)
								LogStateChange(sm, ErrorGotoState, Name);

							sm.SetActiveState(ErrorGotoState);
						}
					}
					else
						throw;
				}
			}

			internal void OnStart(FSM sm)
			{
				if (Conditions == null)
					Conditions = new ICondition[0];
				if (Actions == null)
					Actions = new IAction[0];

				foreach (var condition in Conditions)
					condition.OnStart(sm);
				foreach (var action in Actions)
					action.OnStart(sm);
			}

			internal void OnStop(FSM sm)
			{
				foreach (var condition in Conditions)
					condition.OnStop(sm);
				foreach (var action in Actions)
					action.OnStop(sm);
			}

			internal void OnEnterState(FSM sm)
			{
				foreach (var condition in Conditions)
					condition.OnEnterState(sm);
				foreach (var action in Actions)
					action.OnEnterState(sm);
			}

			internal void OnExitState(FSM sm)
			{
				foreach (var condition in Conditions)
					condition.OnExitState(sm);
				foreach (var action in Actions)
					action.OnExitState(sm);
			}
		}
	}
}
