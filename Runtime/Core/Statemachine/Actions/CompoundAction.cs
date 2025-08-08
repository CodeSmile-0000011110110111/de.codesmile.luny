// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Luny.Statemachine.Actions
{
	/// <summary>
	///     Used to combine multiple FSM actions into a single, named action.
	/// </summary>
	public sealed class CompoundAction : IAction
	{
		private readonly String m_Name;
		private readonly IAction[] m_Actions;

		private CompoundAction() {}

		/// <summary>
		///     Create a combined action from one or more actions.
		/// </summary>
		/// <param name="actions"></param>
		public CompoundAction(params IAction[] actions)
			: this(null, actions) {}

		/// <summary>
		///     Create a combined action from one or more actions.
		/// </summary>
		/// <param name="name">The display/debug name of the combined action.</param>
		/// <param name="actions"></param>
		/// <exception cref="ArgumentException">Thrown if no actions provided.</exception>
		public CompoundAction(String name, params IAction[] actions)
		{
			if (actions == null || actions.Length == 0)
				throw new ArgumentException("actions null or empty");

			m_Name = name;
			m_Actions = actions;
		}

#pragma warning disable CS4014
		public void Execute(FSM sm) => FSM.Transition.ExecuteActions(sm, null, m_Actions, sm.ActiveState.Logging);
#pragma warning restore

		public String ToDebugString(FSM sm)
		{
			if (String.IsNullOrWhiteSpace(m_Name) == false)
				return m_Name;

			var sb = new StringBuilder();
			foreach (var action in m_Actions)
				sb.AppendLine(action.ToDebugString(sm));

			return sb.ToString();
		}
	}
}
