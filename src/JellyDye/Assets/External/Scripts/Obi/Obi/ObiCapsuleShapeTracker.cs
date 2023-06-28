using UnityEngine;

namespace Obi
{
	public class ObiCapsuleShapeTracker : ObiShapeTracker
	{
		public ObiCapsuleShapeTracker(ObiCollider source, CapsuleCollider collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
