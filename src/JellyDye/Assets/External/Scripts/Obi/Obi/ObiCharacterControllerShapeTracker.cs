using UnityEngine;

namespace Obi
{
	public class ObiCharacterControllerShapeTracker : ObiShapeTracker
	{
		public ObiCharacterControllerShapeTracker(ObiCollider source, CharacterController collider)
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}
	}
}
