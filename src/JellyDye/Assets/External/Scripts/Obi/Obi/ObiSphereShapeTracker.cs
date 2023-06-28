using UnityEngine;

namespace Obi
{
	public class ObiSphereShapeTracker : ObiShapeTracker
	{
		public ObiSphereShapeTracker(ObiCollider source, SphereCollider collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
