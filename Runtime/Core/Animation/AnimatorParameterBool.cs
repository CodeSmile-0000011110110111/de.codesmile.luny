// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public sealed class AnimatorParameterBool
	{
		private readonly Animator m_Animator;
		private readonly Int32 m_ParameterHash;

		public Boolean Value
		{
			get => m_Animator.GetBool(m_ParameterHash);
			set => m_Animator.SetBool(m_ParameterHash, value);
		}

		private AnimatorParameterBool() {}

		public AnimatorParameterBool(Animator animator, String paramName)
		{
			m_Animator = animator;
			m_ParameterHash = Animator.StringToHash(paramName);
		}
	}
}
