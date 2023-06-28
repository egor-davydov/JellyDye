using UnityEngine;

public class MegaBend : MegaModifier
{
	[HideInInspector]
	public float angle;

	[HideInInspector]
	public float dir;

	[HideInInspector]
	public MegaAxis axis;

	[HideInInspector]
	public bool doRegion;

	[HideInInspector]
	public float from;

	[HideInInspector]
	public float to;

	private Matrix4x4 mat;

	private Matrix4x4 tmAbove;

	private Matrix4x4 tmBelow;

	private float r;

	private float oor;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override void SetValues(MegaModifier mod)
	{
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
