// Copyright (C) 2021-2025 Steffen Itterheim
// Refer to included LICENSE file for terms and conditions.

using System;
using UnityEditor;
using UnityEngine;

namespace Luny.Core.UnityEngine
{
	public static class PhysicsExt
	{
		// RaycastHit size is 44 bytes
		private static readonly RaycastHit[] s_RaycastHits = new RaycastHit[16];

		/// <summary>
		///     Returns the index of the closest (least distant) hit in the results array. Uses RaycastNonAlloc.
		/// </summary>
		/// <param name="ray">The ray to cast.</param>
		/// <param name="results">The pre-allocated array where results are stored.</param>
		/// <param name="closestHitIndex">Index in results of the closest hit. Is -1 if there are no hits.</param>
		/// <param name="maxDistance">Maximum raycast distance. Default: infinity.</param>
		/// <param name="layerMask">Layer mask. Default: Physics.DefaultRaycastLayers</param>
		/// <param name="triggerInteraction">How to interact with trigger colliders. Default: QueryTriggerInteraction.UseGlobal</param>
		/// <returns>The number of hits.</returns>
		public static Int32 RaycastNonAllocClosest(Ray ray, RaycastHit[] results, out Int32 closestHitIndex,
			Single maxDistance = Mathf.Infinity, Int32 layerMask = Physics.DefaultRaycastLayers,
			QueryTriggerInteraction triggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			closestHitIndex = -1;
			var numHits = Physics.RaycastNonAlloc(ray, results, maxDistance, layerMask, triggerInteraction);
			if (numHits != 0)
			{
				closestHitIndex = 0;
				for (var i = 1; i < numHits; i++)
				{
					if (results[i].distance < results[closestHitIndex].distance)
						closestHitIndex = i;
				}
			}

			return numHits;
		}

		public static Boolean ClosestHit(Ray ray, out RaycastHit hit, Single maxDistance, LayerMask layerMask,
			QueryTriggerInteraction triggerInteraction)
		{
			var hitCount = RaycastNonAllocClosest(ray, s_RaycastHits, out var closestHitIndex, maxDistance, layerMask,
				triggerInteraction);
			hit = hitCount > 0 ? s_RaycastHits[closestHitIndex] : default;
			return hitCount > 0;
		}
	}
}
