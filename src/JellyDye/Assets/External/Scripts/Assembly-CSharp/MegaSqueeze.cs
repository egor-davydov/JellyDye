using UnityEngine;

public class MegaSqueeze : MegaModifier
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
