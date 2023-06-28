using UnityEngine;

namespace Obi
{
	public class BIH
	{
		public static BIHNode[] Build(ref IBounded[] elements, int maxDepth = 10, float maxOverlap = 0.7f)
		{
			return null;
		}

		public static int HoarePartition(IBounded[] elements, int start, int end, float pivot, ref BIHNode node, int axis)
		{
			return 0;
		}

		public static float DistanceToSurface(Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in BIHNode node, in Vector3 point)
		{
			return 0f;
		}

		public static float DistanceToSurface(BIHNode[] nodes, Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in Vector3 point)
		{
			return 0f;
		}

		public static float DistanceToSurface(BIHNode[] nodes, Triangle[] triangles, Vector3[] vertices, Vector3[] normals, in BIHNode node, in Vector3 point)
		{
			return 0f;
		}
	}
}
