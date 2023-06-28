using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaBezPatch : MonoBehaviour
{
	public float Width;

	public float Height;

	public int WidthSegs;

	public int HeightSegs;

	public bool GenUVs;

	public bool recalcBounds;

	public bool recalcTangents;

	public bool recalcCollider;

	public bool showgizmos;

	public bool showlatticepoints;

	public Color latticecol;

	public float handlesize;

	public bool positionhandles;

	public bool showlabels;

	public Vector2 snap;

	public List<Warp> warps;

	public int srcwarp;

	public int destwarp;

	[HideInInspector]
	public Vector3[] verts;

	[HideInInspector]
	public Vector2[] uvs;

	[HideInInspector]
	public int[] tris;

	[HideInInspector]
	public Vector3[] norms;

	[HideInInspector]
	public bool rebuild;

	public Vector2 UVOffset;

	public Vector2 UVScale;

	public int currentwarp;

	[HideInInspector]
	public Mesh mesh;

	public float switchtime;

	public float time;

	public Vector3 p11;

	public Vector3 p21;

	public Vector3 p31;

	public Vector3 p41;

	public Vector3 p12;

	public Vector3 p22;

	public Vector3 p32;

	public Vector3 p42;

	public Vector3 p13;

	public Vector3 p23;

	public Vector3 p33;

	public Vector3 p43;

	public Vector3 p14;

	public Vector3 p24;

	public Vector3 p34;

	public Vector3 p44;

	public bool animateWarps;

	public bool align;

	public float scale;

	public Vector2 offset;

	public Vector3[] lpoints;

	private float delay;

	private int currentDest;

	public void AddWarp()
	{
	}

	public void UpdateWarp(int i)
	{
	}

	public void SetDestWarp(int i)
	{
	}

	public void SetWarp(int i)
	{
	}

	private void Start()
	{
	}

	public void Reset()
	{
	}

	public void Rebuild()
	{
	}

	private void Update()
	{
	}

	private void MakeQuad1(int f, int a, int b, int c, int d)
	{
	}

	private int MaxComponent(Vector3 v)
	{
		return 0;
	}

	private void UpdateSurface()
	{
	}

	private void BuildMesh(Mesh mesh)
	{
	}

	public void InitLattice()
	{
	}

	public void AdjustLattice(float w, float h)
	{
	}

	public static void BuildTangents(Mesh mesh, Vector3[] verts, Vector3[] norms, int[] tris, Vector2[] uvs)
	{
	}

	private Vector3 bounce(Vector3 start, Vector3 end, float value)
	{
		return default(Vector3);
	}

	private Vector3 easeInOutSine(Vector3 start, Vector3 end, float value)
	{
		return default(Vector3);
	}

	public void CheckForChange()
	{
	}

	public void ChangeWarp(int f, int t)
	{
	}

	public void AlignPoints()
	{
	}

	private Vector3 LineIntersectionPoint(Vector3 ps1, Vector3 pe1, Vector3 ps2, Vector3 pe2)
	{
		return default(Vector3);
	}
}
