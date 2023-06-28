using UnityEngine;

public class MegaSkew : MegaModifier
{
	public float amount;

	public bool doRegion;

	public float to;

	public float from;

	public float dir;

	public MegaAxis axis;

	private Matrix4x4 mat;

	private float amountOverLength;

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

	public override void ExtraGizmo(MegaModContext mc)
	{
	}
}
