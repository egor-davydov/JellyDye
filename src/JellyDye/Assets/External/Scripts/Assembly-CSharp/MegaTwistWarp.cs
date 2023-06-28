using UnityEngine;

public class MegaTwistWarp : MegaWarp
{
	public float angle;

	public bool doRegion;

	public float from;

	public float to;

	public float Bias;

	public MegaAxis axis;

	private bool doBias;

	private float height;

	private float angleOverHeight;

	private float theAngle;

	private float bias;

	private Matrix4x4 mat;

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

	private void CalcHeight(MegaAxis axis, float angle)
	{
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
