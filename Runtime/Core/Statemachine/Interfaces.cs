// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine
{
	/// <summary>
	///     Event methods that the Statemachine calls at specific times.
	/// </summary>
	public interface IStatemachineEvents
	{
		/// <summary>
		///     Called before the first evaluation of the Statemachine. Similar to Start() in a MonoBehaviour.
		/// </summary>
		/// <remarks>Use this for once-only initialization.</remarks>
		/// <param name="sm"></param>
		void OnStart(FSM sm) {}

		/// <summary>
		///     Called when the Statemachine stops, meaning it reached a State that has no transitions.
		/// </summary>
		/// <remarks>Use this for final cleanup of the Action/Condition.</remarks>
		/// <remarks>
		///     Before OnStop the OnExitState event is raised even though there is no state change, and likely
		///     no Actions/Conditions anyway. But in case where a Statemachine is manually stopped this would ensure pairing
		///     of OnEnterState and OnExitState.
		/// </remarks>
		/// <param name="sm"></param>
		void OnStop(FSM sm) {}

		/// <summary>
		///     Called when the Statemachine enters a state to which the Action/Condition belongs.
		/// </summary>
		/// <remarks>Use this to set up the Action/Condition, such as registering an event.</remarks>
		/// <param name="sm"></param>
		void OnEnterState(FSM sm) {}

		/// <summary>
		///     Called when the Statemachine leaves the state to which the Action/Condition belongs.
		/// </summary>
		/// <remarks>Use this to deactivate the Action/Condition, eg unregister an event.</remarks>
		/// <remarks>
		///     Before a Statemachine stops it will also issue an OnExitState event to guarantee the pairing of
		///     Enter/Exit events, primarily in cases where the Statemachine is stopped manually.
		/// </remarks>
		/// <param name="sm"></param>
		void OnExitState(FSM sm) {}
	}

	/// <summary>
	///     Marks a class as a FSM Condition.
	/// </summary>
	public interface ICondition : IStatemachineEvents
	{
		/// <summary>
		///     Returns true or false to determine the "satisfied" state of the condition.
		/// </summary>
		/// <param name="sm"></param>
		/// <returns></returns>
		Boolean IsSatisfied(FSM sm);

		String ToDebugString(FSM sm) => GetType().Name;
	}

	/// <summary>
	///     Marks a class as a FSM Action.
	/// </summary>
	public interface IAction : IStatemachineEvents
	{
		/// <summary>
		///     Executes the action.
		/// </summary>
		/// <param name="sm"></param>
		void Execute(FSM sm) {}

		String ToDebugString(FSM sm) => GetType().Name;
	}

	/// <summary>
	///     Marks a class as an asynchronous (awaitable) FSM Action.
	/// </summary>
	public interface IAsyncAction : IAction
	{
		/// <summary>
		///     Executes an action asynchronously (awaitable).
		/// </summary>
		/// <param name="sm"></param>
		/// <returns></returns>
		Task ExecuteAsync(FSM sm);
	}
}
