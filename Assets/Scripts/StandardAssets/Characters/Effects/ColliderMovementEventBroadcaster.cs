﻿using UnityEngine;

namespace StandardAssets.Characters.Effects
{
	/// <summary>
	/// Uses ColliderMovementDetection objects to broadcast movement events. i.e. footfalls
	/// </summary>
	public class ColliderMovementEventBroadcaster : MovementEventBroadcaster
	{
		/// <summary>
		/// The movement detections
		/// </summary>
		[SerializeField]
		protected ColliderMovementDetection[] movementDetections;

		/// <summary>
		/// Subscribe to the movement detection events
		/// </summary>
		private void Awake()
		{
			foreach (ColliderMovementDetection colliderMovementDetection in movementDetections)
			{
				colliderMovementDetection.detection += BroadcastMovementEvent;
			}
		}
	}
}