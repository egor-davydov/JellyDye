using UnityEngine;

namespace Obi
{
	public class ObiCircleShapeTracker2D : ObiShapeTracker
	{
		public ObiCircleShapeTracker2D(ObiCollider2D source, CircleCollider2D collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
