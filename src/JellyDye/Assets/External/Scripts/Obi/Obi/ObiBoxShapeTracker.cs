using UnityEngine;

namespace Obi
{
	public class ObiBoxShapeTracker : ObiShapeTracker
	{
		public ObiBoxShapeTracker(ObiCollider source, BoxCollider collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
