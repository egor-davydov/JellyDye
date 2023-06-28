using System.Collections.Generic;
using UnityEngine;

public class MegaUtils
{
	public static void Bez3D(out Vector3 b, ref Vector3[] p, float u)
	{
		b = default(Vector3);
	}

	public static float WaveFunc(float radius, float t, float amp, float waveLen, float phase, float decay)
	{
		return 0f;
	}

	public static int LargestComponent(Vector3 p)
	{
		return 0;
	}

	public static float LargestValue(Vector3 p)
	{
		return 0f;
	}

	public static float LargestValue1(Vector3 p)
	{
		return 0f;
	}

	public static int SmallestComponent(Vector3 p)
	{
		return 0;
	}

	public static float SmallestValue(Vector3 p)
	{
		return 0f;
	}

	public static float SmallestLargestValueAbs(Vector3 p)
	{
		return 0f;
	}

	public static Vector3 Extents(Vector3[] verts, out Vector3 min, out Vector3 max)
	{
		min = default(Vector3);
		max = default(Vector3);
		return default(Vector3);
	}

	public static Vector3 Extents(List<Vector3> verts, out Vector3 min, out Vector3 max)
	{
		min = default(Vector3);
		max = default(Vector3);
		return default(Vector3);
	}

	public static int FindVert(Vector3 vert, List<Vector3> verts, float tolerance, float scl, bool flipyz, bool negx, int vn)
	{
		return 0;
	}

	public static void BuildTangents(Mesh mesh)
	{
	}

	public static Mesh GetMesh(GameObject go)
	{
		return null;
	}

	public static Mesh GetSharedMesh(GameObject go)
	{
		return null;
	}
}
