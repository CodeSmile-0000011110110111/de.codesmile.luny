// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.Components
{
	[DisallowMultipleComponent]
	public sealed class FreeFlightCameraController : MonoBehaviour
	{
		[SerializeField] private Single m_Speed = 5f;
		[SerializeField] private Single m_MaxSpeed = 300f;
		[SerializeField] private Single m_FastSpeedMultiplier = 25f;
		[SerializeField] private Single m_Sensitivity = 0.05f;
		[SerializeField] private Boolean m_RightClickToLook = true;
		private Vector3 m_EulerAngles = Vector3.one;
		private Single m_FastSpeedTime = 1f;

		private void Update()
		{
			UpdateLook();
			UpdateMove();
		}

		private void UpdateMove()
		{
			var velocity = GetInputVelocity();
			if (velocity.sqrMagnitude > 0f)
			{
				var isFast = Input.GetKey(KeyCode.LeftShift);
				if (isFast)
				{
					m_FastSpeedTime += Time.deltaTime;
					velocity *= m_FastSpeedTime * m_FastSpeedMultiplier;
					velocity.x = Mathf.Clamp(velocity.x, -m_MaxSpeed, m_MaxSpeed);
					velocity.y = Mathf.Clamp(velocity.y, -m_MaxSpeed, m_MaxSpeed);
					velocity.z = Mathf.Clamp(velocity.z, -m_MaxSpeed, m_MaxSpeed);
				}
				else
				{
					m_FastSpeedTime = Mathf.Clamp(m_FastSpeedTime * 0.5f, 1f, m_MaxSpeed);
					velocity *= m_Speed;
				}

				velocity *= Time.deltaTime;
				var newPosition = transform.position;
				var moveOnlyAlongXZ = Input.GetKey(KeyCode.Space) || Input.GetMouseButton(2);
				if (moveOnlyAlongXZ)
				{
					transform.Translate(velocity);
					newPosition.x = transform.position.x;
					newPosition.z = transform.position.z;
					transform.position = newPosition;
				}
				else
					transform.Translate(velocity);
			}
		}

		private void UpdateLook()
		{
			if (m_RightClickToLook && Input.GetMouseButton(1) == false)
				return;

			m_EulerAngles = Input.mousePosition - m_EulerAngles;
			m_EulerAngles = new Vector3(-m_EulerAngles.y * m_Sensitivity, m_EulerAngles.x * m_Sensitivity, 0);
			m_EulerAngles = new Vector3(transform.eulerAngles.x + m_EulerAngles.x, transform.eulerAngles.y + m_EulerAngles.y,
				0);
			transform.eulerAngles = m_EulerAngles;
			m_EulerAngles = Input.mousePosition;
		}

		private Vector3 GetInputVelocity()
		{
			var velocity = Vector3.zero;

			if (Input.GetKey(KeyCode.W))
				velocity += Vector3.forward;
			if (Input.GetKey(KeyCode.S))
				velocity += Vector3.back;
			if (Input.GetKey(KeyCode.A))
				velocity += Vector3.left;
			if (Input.GetKey(KeyCode.D))
				velocity += Vector3.right;

			return velocity;
		}
	}
}
