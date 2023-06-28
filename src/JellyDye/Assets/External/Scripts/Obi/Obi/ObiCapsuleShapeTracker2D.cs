using UnityEngine;

namespace Obi
{
	public class ObiCapsuleShapeTracker2D : ObiShapeTracker
	{
		public ObiCapsuleShapeTracker2D(ObiCollider2D source, CapsuleCollider2D collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
