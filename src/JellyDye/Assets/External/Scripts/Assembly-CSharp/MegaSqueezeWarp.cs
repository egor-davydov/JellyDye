using UnityEngine;

public class MegaSqueezeWarp : MegaWarp
{
	public float amount;

	public float crv;

	public float radialamount;

	public float radialcrv;

	public bool doRegion;

	public float to;

	public float from;

	public MegaAxis axis;

	private Matrix4x4 mat;

	private float k1;

	private float k2;

	private float k3;

	private float k4;

	private float l;

	private float l2;

	private float ovl;

	private float ovl2;

	private void SetK(float K1, float K2, float K3, float K4)
	{
	}

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
