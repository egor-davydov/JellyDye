using System.Collections.Generic;
using UnityEngine;

public class MegaMeshPage : MonoBehaviour
{
	public float Width;

	public float Length;

	public float Height;

	public int WidthSegs;

	public int LengthSegs;

	public int HeightSegs;

	public bool genUVs;

	public float rotate;

	public bool PivotBase;

	public bool PivotEdge;

	public bool tangents;

	public bool optimize;

	public void Help()
	{
	}

	private void Reset()
	{
	}

	public void Rebuild()
	{
	}

	private static void MakeQuad1(List<int> f, int a, int b, int c, int d)
	{
	}

	private int MaxComponent(Vector3 v)
	{
		return 0;
	}

	private void BuildMesh(Mesh mesh)
	{
	}

	private void BuildMeshOld(Mesh mesh)
	{
	}
}
