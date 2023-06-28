using UnityEngine;

namespace Obi
{
	public class ObiBoxShapeTracker2D : ObiShapeTracker
	{
		public ObiBoxShapeTracker2D(ObiCollider2D source, BoxCollider2D collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
