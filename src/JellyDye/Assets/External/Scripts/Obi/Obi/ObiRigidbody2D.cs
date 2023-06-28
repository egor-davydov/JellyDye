using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiRigidbody2D : ObiRigidbodyBase
	{
		private Rigidbody2D unityRigidbody;

		private Quaternion prevRotation;

		private Vector3 prevPosition;

		public override void Awake()
		{
		}

		private void UpdateKinematicVelocities(float stepTime)
		{
		}

		public override void UpdateIfNeeded(float stepTime)
		{
		}

		public override void UpdateVelocities(Vector3 linearDelta, Vector3 angularDelta)
		{
		}
	}
}
