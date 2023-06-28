using UnityEngine;

[ExecuteInEditMode]
public class MegaWrapRef : MonoBehaviour
{
	public float gap;

	public float shrink;

	public Vector3[] skinnedVerts;

	public Mesh mesh;

	public Vector3 offset;

	public bool targetIsSkin;

	public bool sourceIsSkin;

	public int nomapcount;

	public Matrix4x4[] bindposes;

	public Transform[] bones;

	public float size;

	public int vertindex;

	public Vector3[] verts;

	public MegaModifyObject target;

	public float maxdist;

	public int maxpoints;

	public bool WrapEnabled;

	public MegaWrap source;

	public MegaNormalMethod NormalMethod;

	[HideInInspector]
	public MegaNormMap[] mapping;

	[HideInInspector]
	public int[] tris;

	[HideInInspector]
	public Vector3[] facenorms;

	[HideInInspector]
	public Vector3[] norms;

	public void Help()
	{
	}

	private Vector4 Plane(Vector3 v1, Vector3 v2, Vector3 v3)
	{
		return default(Vector4);
	}

	private float PlaneDist(Vector3 p, Vector4 plane)
	{
		return 0f;
	}

	private float GetDistance(Vector3 p, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	private float GetPlaneDistance(Vector3 p, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	public Vector3 MyBary(Vector3 p, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	public Vector3 MyBary1(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
	{
		return default(Vector3);
	}

	public Vector3 CalcBary(Vector3 p, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	public float CalcArea(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	public Vector3 FaceNormal(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	private static void CopyBlendShapes(Mesh mesh1, Mesh clonemesh)
	{
	}

	private Mesh CloneMesh(Mesh m)
	{
		return null;
	}

	public void ResetMesh()
	{
	}

	public void Attach(MegaModifyObject modobj)
	{
	}

	private void LateUpdate()
	{
	}

	private Vector3 GetSkinPos(MegaWrap src, int i)
	{
		return default(Vector3);
	}

	public Vector3 GetCoordMine(Vector3 A, Vector3 B, Vector3 C, Vector3 bary)
	{
		return default(Vector3);
	}

	private void DoUpdate()
	{
	}

	private int[] FindFacesUsing(Vector3 p, Vector3 n)
	{
		return null;
	}

	public void BuildNormalMapping(Mesh mesh, bool force)
	{
	}

	public void RecalcNormals()
	{
	}

	public void RecalcNormals(Mesh ms, Vector3[] _verts)
	{
	}
}
