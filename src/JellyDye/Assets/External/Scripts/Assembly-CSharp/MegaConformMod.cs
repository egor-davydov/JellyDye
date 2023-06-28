using UnityEngine;

public class MegaConformMod : MegaModifier
{
	public GameObject target;

	public float[] offsets;

	public Collider conformCollider;

	public Bounds bounds;

	public float[] last;

	public Vector3[] last1;

	public Vector3[] conformedVerts;

	public float conformAmount;

	public float raystartoff;

	public float offset;

	public float raydist;

	public MegaAxis axis;

	private Matrix4x4 loctoworld;

	private Matrix4x4 ctm;

	private Matrix4x4 cinvtm;

	private Ray ray;

	private RaycastHit hit;

	public bool useLocalDown;

	public bool flipDown;

	public MegaAxis downAxis;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void SetTarget(GameObject targ)
	{
	}

	public override Vector3 Map(int i, Vector3 p)
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

	public void ChangeAxis()
	{
	}
}
