using UnityEngine;

namespace Obi
{
	public struct ColliderRigidbody
	{
		public Matrix4x4 inverseInertiaTensor;

		public Vector4 velocity;

		public Vector4 angularVelocity;

		public Vector4 com;

		public float inverseMass;

		private int pad0;

		private int pad1;

		private int pad2;

		public void FromRigidbody(Rigidbody rb, bool kinematicForParticles)
		{
		}

		public void FromRigidbody(Rigidbody2D rb, bool kinematicForParticles)
		{
		}
	}
}
