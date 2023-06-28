using UnityEngine;

public class MegaRolled : MegaModifier
{
	public float radius;

	public Transform roller;

	public float splurge;

	public MegaAxis fwdaxis;

	private Matrix4x4 mat;

	private Vector3[] offsets;

	private Plane plane;

	private float height;

	private Vector3 rpos;

	public bool clearoffsets;

	private float delta;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
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
}
