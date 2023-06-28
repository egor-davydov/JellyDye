using UnityEngine;

namespace Obi
{
	public class VoxelDistanceField
	{
		public Vector3Int[,,] distanceField;

		private MeshVoxelizer voxelizer;

		public VoxelDistanceField(MeshVoxelizer voxelizer)
		{
		}

		private bool VoxelExists(Vector3Int coords)
		{
			return false;
		}

		public void JumpFlood()
		{
		}

		private void JumpFloodPass(int stride, Vector3Int[,,] input, Vector3Int[,,] output)
		{
		}
	}
}
