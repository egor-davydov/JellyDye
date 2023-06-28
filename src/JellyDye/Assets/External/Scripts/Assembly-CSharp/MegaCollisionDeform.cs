using System.Collections.Generic;
using UnityEngine;

public class MegaCollisionDeform : MegaModifier
{
	public GameObject obj;

	public float decay;

	public bool usedecay;

	public Vector3 normal;

	private List<int> affected;

	private List<float> distances;

	private Matrix4x4 mat;

	private Vector3[] offsets;

	private Vector3[] normals;

	public MegaColliderMesh colmesh;

	public MegaDeformType method;

	public float distance;

	public float bulgeExtendValue;

	public float bulgeValue;

	public bool bulge;

	public AnimationCurve bulgeCrv;

	private float[] vertdist;

	private Vector3[] vertoffsets;

	private Vector3[] nearest;

	private Vector3[] vels;

	public float btime;

	public float retspd;

	private Collider col;

	private float[] penetration;

	public GameObject hitObject;

	private const float EPSILON = 1E-06f;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private void DeformMeshMine()
	{
	}

	private void DeformMesh()
	{
	}

	public void ResetOffsets()
	{
	}

	private void DeformMeshNew()
	{
	}

	private Vector3 FaceNormal(Vector3[] verts, int[] tris, int f)
	{
		return default(Vector3);
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public override void PrepareMT(MegaModifiers mc, int cores)
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	private int intersect_triangle(Vector3 orig, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, out float t, out float u, out float v)
	{
		t = default(float);
		u = default(float);
		v = default(float);
		return 0;
	}
}
