using UnityEngine;

namespace Obi
{
	public class ObiMeshShapeTracker : ObiShapeTracker
	{
		private ObiTriangleMeshHandle handle;

		public ObiMeshShapeTracker(ObiCollider source, MeshCollider collider)
		{
		}

		public void UpdateMeshData()
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
