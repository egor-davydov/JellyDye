using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class MeshVoxelizer
	{
		public enum Voxel
		{
			Inside = 0,
			Boundary = 1,
			Outside = 2
		}

		public Mesh input;

		public float voxelSize;

		public Voxel[,,] voxels;

		private Vector3Int origin;

		public Vector3Int Origin => default(Vector3Int);

		public MeshVoxelizer(Mesh input, float voxelSize)
		{
		}

		private Bounds GetTriangleBounds(Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Bounds);
		}

		private Vector3Int GetPointVoxel(Vector3 point)
		{
			return default(Vector3Int);
		}

		private bool VoxelExists(Vector3Int coords)
		{
			return false;
		}

		private void AppendOverlappingVoxels(Bounds bounds, Vector3 v1, Vector3 v2, Vector3 v3)
		{
		}

		public void Voxelize(Vector3 scale)
		{
		}

		private void FloodFill()
		{
		}

		public static bool IsIntersecting(Bounds box, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return false;
		}

		private static void Project(IEnumerable<Vector3> points, Vector3 axis, out double min, out double max)
		{
			min = default(double);
			max = default(double);
		}
	}
}
