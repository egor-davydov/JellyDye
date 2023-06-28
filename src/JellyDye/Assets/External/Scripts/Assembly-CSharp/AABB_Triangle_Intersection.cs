using UnityEngine;

internal static class AABB_Triangle_Intersection
{
	private static void FINDMINMAX(float x0, float x1, float x2, out float min, out float max)
	{
		min = default(float);
		max = default(float);
	}

	private static bool planeBoxOverlap(Vector3 normal, Vector3 vert, Vector3 maxbox)
	{
		return false;
	}

	public static bool TriangleBoxOverlap(Vector3 A, Vector3 B, Vector3 C, Bounds Box)
	{
		return false;
	}

	private static bool triBoxOverlap(Vector3 boxcenter, Vector3 boxhalfsize, Vector3[] triverts)
	{
		return false;
	}
}
