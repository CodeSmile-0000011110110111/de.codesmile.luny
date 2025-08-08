// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using UnityEditor;
using UnityEngine;

namespace Luny.Core.Utility
{
	/// <summary>
	///     Intended for complex child hierarchy as a way to quickly get the "root" object or component from a child object.
	/// </summary>
	/// <remarks>You have to make a specific subclass of QuickRef since generic MonoBehaviour are not allowed.</remarks>
	/// <remarks>
	///     Example use case: Put a QuickRef subclass like ProjectileImpactorRef : QuickRef&lt;ProjectileImpactor&gt; on each
	///     animated characters' bone collider. When any of these ragdoll colliders is hit by a raycast, you can avoid
	///     running GetComponentInParent on every hit as well as having to manually assign each a reference in the Inspector.
	///     Instead, a QuickRef can be used to get from the collider to, for instance, the target's ProjectileImpactor script.
	///     The intended reference can be automatically assigned via the OnValidate callback in the editor.
	/// </remarks>
	public abstract class QuickRef<T> : MonoBehaviour where T : Object
	{
		[field: SerializeField] public T Target { get; set; }
	}
}
