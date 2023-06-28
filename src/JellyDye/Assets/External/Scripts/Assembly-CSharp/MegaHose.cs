using System;
using UnityEngine;

[ExecuteInEditMode]
public class MegaHose : MonoBehaviour
{
	public bool freecreate;

	public bool updatemesh;

	private Matrix4x4 S;

	private const float HalfIntMax = 16383.5f;

	private const float PIover2 = (float)Math.PI / 2f;

	private const float EPSILON = 0.0001f;

	public MegaSpline hosespline;

	private Mesh mesh;

	public Vector3[] verts;

	public Vector2[] uvs;

	public int[] faces;

	public Vector3[] normals;

	public bool optimize;

	public bool calctangents;

	public bool recalcCollider;

	public bool calcnormals;

	public bool capends;

	public GameObject custnode2;

	public GameObject custnode;

	public Vector3 offset;

	public Vector3 offset1;

	public Vector3 rotate;

	public Vector3 rotate1;

	public Vector3 scale;

	public Vector3 scale1;

	public int endsmethod;

	public float noreflength;

	public int segments;

	public MegaHoseSmooth smooth;

	public MegaHoseType wiretype;

	public float rnddia;

	public int rndsides;

	public float rndrot;

	public float rectwidth;

	public float rectdepth;

	public float rectfillet;

	public int rectfilletsides;

	public float rectrotangle;

	public float dsecwidth;

	public float dsecdepth;

	public float dsecfillet;

	public int dsecfilletsides;

	public int dsecrndsides;

	public float dsecrotangle;

	public bool mapmemapme;

	public bool flexon;

	public float flexstart;

	public float flexstop;

	public int flexcycles;

	public float flexdiameter;

	public float tension1;

	public float tension2;

	public bool usebulgecurve;

	public AnimationCurve bulge;

	public float bulgeamount;

	public float bulgeoffset;

	public Vector2 uvscale;

	public bool animatebulge;

	public float bulgespeed;

	public float minbulge;

	public float maxbulge;

	public bool displayspline;

	private bool visible;

	public bool InvisibleUpdate;

	public bool dolateupdate;

	private Vector3 endp1;

	private Vector3 endp2;

	private Vector3 endr1;

	private Vector3 endr2;

	public Vector3[] SaveVertex;

	public Vector2[] SaveUV;

	public Vector3[] SaveNormals;

	public bool rebuildcross;

	public int NvertsPerRing;

	public int Nverts;

	public Vector3 up;

	private Vector3 starty;

	private Vector3 roty;

	private float yangle;

	public Matrix4x4 Tlocal;

	private MeshCollider meshCol;

	public void Help()
	{
	}

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	public void SetEndTarget(int end, GameObject target)
	{
	}

	public void Rebuild()
	{
	}

	private void MakeSaveVertex(int NvertsPerRing, int nfillets, int nsides, MegaHoseType wtype)
	{
	}

	private void FixHoseFillet()
	{
	}

	private float RND11()
	{
		return 0f;
	}

	private void Mult1X3(Vector3 A, Matrix4x4 B, ref Vector3 C)
	{
	}

	private void Mult1X4(Vector4 A, Matrix4x4 B, ref Vector4 C)
	{
	}

	private void SetUpRotation(Vector3 Q, Vector3 W, float Theta, ref Matrix4x4 Rq)
	{
	}

	private void RotateOnePoint(ref Vector3 Pin, Vector3 Q, Vector3 W, float Theta)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void BuildMesh()
	{
	}

	public void CalcMatrix(ref Matrix4x4 mat, float incr)
	{
	}

	private static float findmappos(float curpos)
	{
		return 0f;
	}

	private void DisplayNormals()
	{
	}

	public Vector3 GetPosition(float alpha)
	{
		return default(Vector3);
	}
}
