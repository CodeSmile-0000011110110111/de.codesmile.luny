// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace CodeSmile.Animation
{
	public sealed class AnimatorParameterFloat
	{
		private readonly Animator m_Animator;
		private readonly Int32 m_ParameterHash;

		public Single Value
		{
			get => m_Animator.GetFloat(m_ParameterHash);
			set => m_Animator.SetFloat(m_ParameterHash, value);
		}

		private AnimatorParameterFloat() {}

		public AnimatorParameterFloat(Animator animator, String paramName)
		{
			m_Animator = animator;
			m_ParameterHash = Animator.StringToHash(paramName);
		}
	}
}
