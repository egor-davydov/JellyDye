using UnityEngine;

public class MegaSkewWarp : MegaWarp
{
	public float amount;

	public bool doRegion;

	public float to;

	public float from;

	public float dir;

	public MegaAxis axis;

	private Matrix4x4 mat;

	private float amountOverLength;

	public override string WarpName()
	{
		return null;
	}

	public override string GetIcon()
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

	public override bool Prepare(float decay)
	{
		return false;
	}

	public override void ExtraGizmo()
	{
	}
}
