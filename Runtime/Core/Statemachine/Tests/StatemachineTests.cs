// Copyright (C) 2021-2024 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;
using Task = System.Threading.Tasks.Task;

namespace Luny.Statemachine.Tests
{
	public class StatemachineTests
	{
		[TestCase(null)] [TestCase("")]
		public void FSM_InvalidStatemachineName_Throws(String fsmName)
		{
#if DEBUG || DEVELOPMENT_BUILD
			Assert.Throws<ArgumentException>(() => new FSM(fsmName).WithStates("state").Start());
#endif
		}

		[TestCase(null)] [TestCase("")]
		public void FSM_InvalidStateName_Throws(String stateName)
		{
#if DEBUG || DEVELOPMENT_BUILD
			Assert.Throws<ArgumentException>(() => new FSM("FSM").WithStates(stateName).Start());
#endif
		}

		[Test]
		public async Task FSM_StartNotCalledBeforeEvaluate_Throws()
		{
#if DEBUG || DEVELOPMENT_BUILD
			var didThrow = false;
			var fsm = new FSM("FSM").WithStates("X");
			try
			{
				await fsm.Update();
			}
			catch (InvalidOperationException)
			{
				didThrow = true;
			}

			if (didThrow)
				Assert.Pass();
			else
				Assert.Fail();
#endif
		}

		[Test]
		public void FSM_NonExistingGotoState_Throws()
		{
#if DEBUG || DEVELOPMENT_BUILD
			Assert.Throws<ArgumentException>(() =>
			{
				var state = FSM.CreateState("X");
				state.AddTransition().ToState(FSM.CreateState("?"));
				new FSM("FSM").WithStates(state).Start();
			});
#endif
		}

		[Test]
		public void FSM_StartEndStates_RunsToEndAndRaisesStateChangeEvent()
		{
			var didExecuteActions = false;

			var sm = new FSM("FSM").WithStates("START", "END");
			sm.States[0].AddTransition().ToState(sm.States[1]).WithActions(FSM.Action(() => didExecuteActions = true));

			sm.Start().Update();

			Assert.AreEqual(sm.States[1], sm.ActiveState);
			Assert.IsTrue(sm.IsStopped);
			Assert.IsTrue(didExecuteActions);
		}

		[Test]
		public void FSM_StateChange_InvokesStateChangeEvent()
		{
			var sm = new FSM("FSM").WithStates("START", "END");
			sm.States[0].AddTransition().ToState(sm.States[1]);

			var didInvokeStateChangedEvent = false;
			sm.OnStateChange += args =>
			{
				didInvokeStateChangedEvent = true;
				Assert.AreEqual(args.PreviousState, sm.States[0]);
				Assert.AreEqual(args.ActiveState, sm.States[1]);
			};

			sm.Start().Update();

			Assert.IsTrue(didInvokeStateChangedEvent);
		}

		[TestCase(false, false, false)]
		[TestCase(true, false, true)]
		[TestCase(false, true, true)]
		[TestCase(true, true, true)]
		public void FSM_LogicalOrCondition_ExpectedOutcome(Boolean condition1, Boolean condition2, Boolean expected)
		{
			var actual = false;
			var state = FSM.CreateState("START");
			state.AddTransition()
				.WithConditions(FSM.OR(
					FSM.Condition(() => condition1),
					FSM.Condition(() => condition2)))
				.WithActions(FSM.Action(() => actual = true));

			new FSM("Test FSM").WithStates(state).Start().Update();

			Assert.AreEqual(expected, actual);
		}
	}
}
