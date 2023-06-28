using UnityEngine;

namespace Obi
{
	public class ObiEdgeShapeTracker2D : ObiShapeTracker
	{
		private ObiEdgeMeshHandle handle;

		public ObiEdgeShapeTracker2D(ObiCollider2D source, EdgeCollider2D collider)
		{
		}

		public void UpdateEdgeData()
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
