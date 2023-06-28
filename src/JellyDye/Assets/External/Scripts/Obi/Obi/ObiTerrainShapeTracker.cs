using UnityEngine;

namespace Obi
{
	public class ObiTerrainShapeTracker : ObiShapeTracker
	{
		private bool heightmapDataHasChanged;

		private ObiHeightFieldHandle handle;

		public ObiTerrainShapeTracker(ObiCollider source, TerrainCollider collider)
		{
		}

		public void UpdateHeightData()
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
