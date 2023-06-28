using System.Collections.Generic;
using UnityEngine;

public class MegaCacheMeshConstructor
{
	public class MegaCacheFaceGrid
	{
		public List<int> verts;
	}

	public static List<Vector3> verts;

	public static List<Vector3> norms;

	public static List<Vector2> uvs;

	public static List<int> tris;

	public static List<MegaCacheMatFaces> matfaces;

	public static MegaCacheFaceGrid[,,] checkgrid;

	public static Vector3 min;

	public static Vector3 max;

	public static Vector3 size;

	public static int subdivs;

	public static void BuildGrid(Vector3[] verts)
	{
	}

	public static void BuildTangents(Mesh mesh)
	{
	}
}
