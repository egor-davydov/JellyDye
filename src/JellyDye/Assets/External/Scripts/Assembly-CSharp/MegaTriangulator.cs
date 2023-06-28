using System.Collections.Generic;
using UnityEngine;

public class MegaTriangulator
{
	public static List<Vector3> m_points;

	public static List<int> Triangulate(MegaShape shape, MegaSpline spline, float dist, ref List<Vector3> verts, ref List<Vector2> uvs, ref List<int> indices, Vector3 pivot, ref Vector3 size)
	{
		return null;
	}

	public static List<int> Triangulate(List<int> indices)
	{
		return null;
	}

	private static float Area()
	{
		return 0f;
	}

	private static bool Snip(int u, int v, int w, int n, int[] V)
	{
		return false;
	}

	private static bool InsideTriangle(Vector2 A, Vector2 B, Vector2 C, Vector2 P)
	{
		return false;
	}
}
