using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public abstract class ObiRigidbodyBase : MonoBehaviour
	{
		public bool kinematicForParticles;

		public ObiRigidbodyHandle handle;

		public virtual void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public abstract void UpdateIfNeeded(float stepTime);

		public abstract void UpdateVelocities(Vector3 linearDelta, Vector3 angularDelta);
	}
}
