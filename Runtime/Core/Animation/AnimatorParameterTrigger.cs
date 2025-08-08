// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public sealed class AnimatorParameterTrigger
	{
		private readonly Animator m_Animator;
		private readonly Int32 m_ParameterHash;

		public Boolean Value
		{
			get => m_Animator.GetBool(m_ParameterHash);
			set
			{
				if (value) m_Animator.SetTrigger(m_ParameterHash);
				else m_Animator.ResetTrigger(m_ParameterHash);
			}
		}

		private AnimatorParameterTrigger() {}

		public AnimatorParameterTrigger(Animator animator, String paramName)
		{
			m_Animator = animator;
			m_ParameterHash = Animator.StringToHash(paramName);
		}
	}
}
