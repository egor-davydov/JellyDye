using System.Collections.Generic;
using UnityEngine;

public class MegaModifiers : MonoBehaviour
{
	public class MegaPS3Vert
	{
		public int[] indices;
	}

	[HideInInspector]
	public Bounds bbox;

	public bool recalcnorms;

	public MegaNormalMethod NormalMethod;

	public bool recalcbounds;

	public bool recalcCollider;

	public bool recalcTangents;

	public bool dynamicMesh;

	public bool Enabled;

	public MegaUpdateMode UpdateMode;

	public bool DrawGizmos;

	[HideInInspector]
	public Vector3[] verts;

	[HideInInspector]
	public Vector3[] sverts;

	[HideInInspector]
	public Vector2[] uvs;

	[HideInInspector]
	public Vector2[] suvs;

	[HideInInspector]
	public Mesh mesh;

	[HideInInspector]
	public MegaModifier[] mods;

	[HideInInspector]
	public int UpdateMesh;

	[HideInInspector]
	public MegaModChannel dirtyChannels;

	[HideInInspector]
	public GameObject sourceObj;

	[HideInInspector]
	public Color[] cols;

	[HideInInspector]
	public float[] selection;

	[HideInInspector]
	public List<GameObject> group;

	public static bool GlobalDisplay;

	private Vector4[] tangents;

	private Vector3[] tan1;

	private Vector3[] tan2;

	public MegaModContext modContext;

	private bool VertsSource;

	private bool UVsSource;

	private MeshCollider meshCol;

	public static bool ThreadingOn;

	public bool UseThreading;

	public static int Cores;

	private static MegaTaskInfo[] tasks;

	private static bool isRunning;

	public MegaNormMap[] mapping;

	public int[] tris;

	public Vector3[] facenorms;

	public Vector3[] norms;

	private Vector3[] ps3verts;

	private MegaPS3Vert[] ps3mapping;

	private static List<int> matches;

	public void InitVertSource()
	{
	}

	public Vector3[] GetSourceVerts(MegaModifierTarget target)
	{
		return null;
	}

	public Vector3[] GetDestVerts(MegaModifierTarget target)
	{
		return null;
	}

	public Vector3[] GetSourceVerts()
	{
		return null;
	}

	public void ChangeSourceVerts()
	{
	}

	public Vector3[] GetDestVerts()
	{
		return null;
	}

	public Vector2[] GetSourceUvs()
	{
		return null;
	}

	public Vector2[] GetDestUvs()
	{
		return null;
	}

	private static int CompareOrder(MegaModifier m1, MegaModifier m2)
	{
		return 0;
	}

	public void UpdateCols(int first, Color[] newcols)
	{
	}

	public void UpdateCol(int i, Color col)
	{
	}

	public void UpdateCols(Color[] newcols)
	{
	}

	public void ModifyObject()
	{
	}

	public void SetMesh(ref Vector3[] _verts)
	{
	}

	public void RecalcNormals()
	{
	}

	private void BuildTangents()
	{
	}

	private void BuildTangents(Mesh ms, Vector3[] _verts)
	{
	}

	public void Sort()
	{
	}

	public void BuildList()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void MakeThreads()
	{
	}

	public void ModifyObjectMT()
	{
	}

	private void PrepareForMT()
	{
	}

	private void DoWork(object info)
	{
	}

	private void DoWork1(int start, int end)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void Done()
	{
	}

	private int[] FindFacesUsing(Vector3 p, Vector3 n)
	{
		return null;
	}

	public void BuildNormalMapping(Mesh mesh, bool force)
	{
	}

	public void RecalcNormals(Mesh ms, Vector3[] _verts)
	{
	}

	public void RecalcFaceNormalsMT(MegaModifiers mod, int cnum, int cores)
	{
	}

	public void RecalcVertexNormalsMT(MegaModifiers mod, int cnum, int cores)
	{
	}

	private void WaitJobs()
	{
	}

	public void RecalcNormalsMT(Mesh ms, Vector3[] _verts)
	{
	}

	private void BuildTangentsMT(Mesh ms, Vector3[] _verts)
	{
	}

	private void BuildFaceTangentsMT(MegaModifiers mc, int cnum, int cores)
	{
	}

	private void BuildVertexTangentsMT(MegaModifiers mc, int cnum, int cores)
	{
	}

	private void Awake()
	{
	}

	private int[] FindMatches(Vector3 p, Vector3[] array)
	{
		return null;
	}

	public void BuildPS3Mapping(Vector3[] oldverts, Vector3[] newverts)
	{
	}

	public void SetPS3Mesh()
	{
	}
}
