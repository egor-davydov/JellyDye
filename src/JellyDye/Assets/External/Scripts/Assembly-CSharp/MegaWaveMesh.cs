using UnityEngine;

[ExecuteInEditMode]
public class MegaWaveMesh : MonoBehaviour
{
	[HideInInspector]
	public float offset;

	public float Width;

	public float Height;

	public float Length;

	public int WidthSegs;

	public bool GenUVs;

	public bool recalcBounds;

	public bool recalcNormals;

	public bool recalcCollider;

	public float mspeed;

	public float flex;

	public float amp;

	public float wave;

	public float phase;

	public float mtime;

	public float speed;

	private float dist;

	private float time;

	public float flex1;

	public float amp1;

	public float wave1;

	public float phase1;

	public float mtime1;

	public float speed1;

	private float dist1;

	private float time1;

	public float flex2;

	public float amp2;

	public float wave2;

	public float phase2;

	public float mtime2;

	public float speed2;

	private float dist2;

	private float time2;

	public float amount;

	[HideInInspector]
	public int surfacestart;

	[HideInInspector]
	public int surfaceend;

	[HideInInspector]
	public Vector3[] verts;

	[HideInInspector]
	public Vector2[] uvs;

	[HideInInspector]
	public int[] tris;

	[HideInInspector]
	public float surface;

	public bool linkOffset;

	[HideInInspector]
	public bool rebuild;

	private Material mat;

	public Vector2 UVOffset;

	public Vector2 UVScale;

	[HideInInspector]
	public Mesh mesh;

	public MeshCollider meshCol;

	public Mesh colmesh;

	public bool smooth;

	private Vector3[] colverts;

	public float colwidth;

	private void Reset()
	{
	}

	public void Rebuild()
	{
	}

	private void Update()
	{
	}

	private void BuildCollider(Mesh cmesh)
	{
	}

	private void MakeQuad1(int f, int a, int b, int c, int d)
	{
	}

	private int MaxComponent(Vector3 v)
	{
		return 0;
	}

	public static float WaveFunc(float radius, float t, float amp, float waveLen, float phase)
	{
		return 0f;
	}

	public static float WaveFunc1(float radius, float t, float amp, float waveLen, float phase)
	{
		return 0f;
	}

	public float Map(Vector3 p)
	{
		return 0f;
	}

	private void UpdateSurface()
	{
	}

	private void BuildMesh(Mesh mesh)
	{
	}
}
