using UnityEngine;

public class MegaZStretchWarp : MegaWarp
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

	private void CalcBulge(MegaAxis axis, float stretch, float amplify)
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
