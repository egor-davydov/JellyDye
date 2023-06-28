using UnityEngine;

namespace Obi
{
	public class ObiDistanceFieldShapeTracker : ObiShapeTracker
	{
		public ObiDistanceField distanceField;

		private ObiDistanceFieldHandle handle;

		public ObiDistanceFieldShapeTracker(ObiCollider source, Component collider, ObiDistanceField distanceField)
		{
		}

		public void UpdateDistanceFieldData()
		{
		}

		public override bool UpdateIfNeeded()
		{
			return false;
		}

		public override void Destroy()
		{
		}
	}
}
