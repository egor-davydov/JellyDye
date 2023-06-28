using UnityEngine;

public class MegaBendWarp : MegaWarp
{
	public float angle;

	public float dir;

	public MegaAxis axis;

	public bool doRegion;

	public float from;

	public float to;

	private Matrix4x4 mat;

	private Matrix4x4 tmAbove;

	private Matrix4x4 tmBelow;

	private float r;

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

	private void CalcR(MegaAxis axis, float ang)
	{
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	private void Calc()
	{
	}

	public override bool Prepare(float decay)
	{
		return false;
	}

	public override void ExtraGizmo()
	{
	}
}
