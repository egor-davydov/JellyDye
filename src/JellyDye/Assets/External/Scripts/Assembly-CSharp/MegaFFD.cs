using UnityEngine;

public class MegaFFD : MegaModifier
{
	public float KnotSize;

	public bool inVol;

	public Vector3[] pt;

	[HideInInspector]
	public float EPSILON;

	[HideInInspector]
	public Vector3 lsize;

	[HideInInspector]
	public Vector3 bsize;

	[HideInInspector]
	public Vector3 bcenter;

	public virtual int GridSize()
	{
		return 0;
	}

	public virtual int GridIndex(int i, int j, int k)
	{
		return 0;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override void PostCopy(MegaModifier src)
	{
	}

	public Vector3 LatticeSize()
	{
		return default(Vector3);
	}

	private void Init()
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

	public Vector3 GetPoint(int i)
	{
		return default(Vector3);
	}

	public Vector3 GetPoint(int i, int j, int k)
	{
		return default(Vector3);
	}

	public void SetPoint(int i, int j, int k, Vector3 pos)
	{
	}

	public void SetPointLocal(int i, int j, int k, Vector3 lpos)
	{
	}

	public void SetPoint(int index, Vector3 pos)
	{
	}

	public void SetPointLocal(int index, Vector3 lpos)
	{
	}

	public void MovePoint(int x, int y, int z, Vector3 localmove)
	{
	}

	private void Reset()
	{
	}

	public void FitFFD()
	{
	}

	public void FitFFDToMesh()
	{
	}

	public override bool InitMod(MegaModifiers mc)
	{
		return false;
	}

	private static MegaFFD Create(GameObject go, int type)
	{
		return null;
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
