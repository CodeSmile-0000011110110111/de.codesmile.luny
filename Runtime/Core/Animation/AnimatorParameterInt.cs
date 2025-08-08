// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core
{
	public sealed class AnimatorParameterInt
	{
		private readonly Animator m_Animator;
		private readonly Int32 m_ParameterHash;

		public Int32 Value
		{
			get => m_Animator.GetInteger(m_ParameterHash);
			set => m_Animator.SetInteger(m_ParameterHash, value);
		}

		private AnimatorParameterInt() {}

		public AnimatorParameterInt(Animator animator, String paramName)
		{
			m_Animator = animator;
			m_ParameterHash = Animator.StringToHash(paramName);
		}
	}
}
