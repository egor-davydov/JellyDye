using UnityEngine;

public class MegaTaper : MegaModifier
{
	public float amount;

	public bool doRegion;

	public float to;

	public float from;

	public float dir;

	public MegaAxis axis;

	public MegaEffectAxis EAxis;

	private Matrix4x4 mat;

	public float crv;

	public bool sym;

	private bool doX;

	private bool doY;

	private float k1;

	private float k2;

	private float l;

	private float ovl;

	private void SetK(float K1, float K2)
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
