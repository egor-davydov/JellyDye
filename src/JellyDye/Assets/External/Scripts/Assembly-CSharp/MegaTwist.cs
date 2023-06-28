using UnityEngine;

public class MegaTwist : MegaModifier
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

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private void CalcHeight(MegaAxis axis, float angle, MegaBox3 bbx)
	{
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
