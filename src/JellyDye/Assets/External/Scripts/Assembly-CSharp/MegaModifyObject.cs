using UnityEngine;

[ExecuteInEditMode]
public class MegaModifyObject : MegaModifiers
{
	[HideInInspector]
	public Mesh cachedMesh;

	public bool InvisibleUpdate;

	private bool visible;

	private int restorekeep;

	private static int CompareOrder(MegaModifier m1, MegaModifier m2)
	{
		return 0;
	}

	public virtual void Resort()
	{
	}

	public virtual void Help()
	{
	}

	public virtual void RemoveKeep()
	{
	}

	public virtual void RemoveRestore()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnRenderObject()
	{
	}

	public void GetMesh(bool force)
	{
	}

	private void SetMeshData()
	{
	}

	public void ModReset(MegaModifier m)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	public void Reset()
	{
	}

	public void ResetMeshInfo()
	{
	}

	public void MeshUpdated()
	{
	}

	public void MeshChanged(Mesh newmesh)
	{
	}

	public void SetMesh(GameObject go, Mesh mesh)
	{
	}

	public static Mesh FindMesh(GameObject go, out GameObject obj)
	{
		obj = null;
		return null;
	}

	public static Mesh FindMesh(GameObject go)
	{
		return null;
	}

	public static bool SetMeshNew(GameObject go, Mesh m)
	{
		return false;
	}
}
