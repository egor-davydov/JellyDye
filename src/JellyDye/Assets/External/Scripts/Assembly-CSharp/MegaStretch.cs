using UnityEngine;

public class MegaStretch : MegaModifier
{
	public float amount;

	public bool doRegion;

	public float to;

	public float from;

	public float amplify;

	public MegaAxis axis;

	private float heightMax;

	private float heightMin;

	private float amplifier;

	private Matrix4x4 mat;

	public bool useheightaxis;

	public MegaAxis axis1;

	private float ovh;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private void CalcBulge(MegaAxis axis, float stretch, float amplify)
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
