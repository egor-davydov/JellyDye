using System.Collections.Generic;
using System.IO;
using UnityEngine;

[ExecuteInEditMode]
public class MegaCacheOBJ : MonoBehaviour
{
	public List<Mesh> meshes;

	public int frame;

	public bool animate;

	public float time;

	public float speed;

	public float looptime;

	public float fps;

	public MegaCacheRepeatMode loopmode;

	public int firstframe;

	public int lastframe;

	public int skip;

	public string lastpath;

	public string cachefile;

	public int framevertcount;

	public int frametricount;

	public float scale;

	public bool adjustcoord;

	public bool buildtangents;

	public bool updatecollider;

	public bool saveuvs;

	public bool savenormals;

	public bool savetangents;

	public bool optimize;

	public bool recalcnormals;

	public bool update;

	public bool loadmtls;

	public MegaCacheData datasource;

	public MegaCacheImage cacheimage;

	public MeshFilter mf;

	public int framecount;

	public Vector3[] vertcache;

	public Vector3[] normcache;

	public Vector4[] tangentcache;

	public Vector2[] uvcache;

	public MegaCacheImageFace[] subs;

	public int decformat;

	public bool shownormals;

	public bool showextras;

	public float normallen;

	public bool showdataimport;

	public bool showanimation;

	public bool showdata;

	public string runtimefolder;

	private bool optimized;

	private int lastreadframe;

	private Mesh lastmesh;

	private int maxv;

	private int maxsm;

	private int[] maxsmfc;

	private FileStream fs;

	private BinaryReader br;

	private long[] meshoffs;

	public Mesh imagemesh;

	private static byte[] buffer;

	public bool meshchanged;

	private MeshCollider meshCol;

	public void Help()
	{
	}

	private void Start()
	{
	}

	public void ChangeSource(MegaCacheData src)
	{
	}

	private void Update()
	{
	}

	private void Reset()
	{
	}

	public void AddMesh(Mesh ms)
	{
	}

	public void DestroyMeshes()
	{
	}

	public void DestroyImage()
	{
	}

	public void ClearMesh()
	{
	}

	public void InitImport()
	{
	}

	public Mesh LoadFrame(string filename, int frame)
	{
		return null;
	}

	public void LoadMtl(string filename, int frame)
	{
	}

	public void LoadMtl(string filename)
	{
	}

	public Mesh LoadFrame(string filename)
	{
		return null;
	}

	public void MountImage(MegaCacheImage image)
	{
	}

	public void OpenCache(string filename)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void GetFrame(int fnum)
	{
	}

	public void GetFrameRef(int fnum, Mesh _mesh)
	{
	}

	public void GetFrame(int fnum, Mesh mesh)
	{
	}

	public void MakeMeshFromFrame(int fnum, Mesh mesh)
	{
	}

	public void CloseCache()
	{
	}

	public void CreateImageFromCacheFile()
	{
	}
}
