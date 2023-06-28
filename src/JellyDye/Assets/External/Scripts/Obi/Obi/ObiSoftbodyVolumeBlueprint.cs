using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[CreateAssetMenu]
	public class ObiSoftbodyVolumeBlueprint : ObiSoftbodyBlueprintBase
	{
		public float particleRadius;

		public float particleOverlap;

		public float shapeSmoothing;

		public float anisotropyNeighborhood;

		public float maxAnisotropy;

		public float softClusterRadius;

		public bool oneSided;

		[HideInInspector]
		public float[] areaContribution;

		public const float DEFAULT_PARTICLE_MASS = 0.1f;

		protected override IEnumerator Initialize()
		{
			return null;
		}

		protected virtual IEnumerator CreateShapeMatchingConstraints(List<Vector3> particles)
		{
			return null;
		}
	}
}
