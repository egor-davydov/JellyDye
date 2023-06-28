using UnityEngine;

public class MegaTaperWarp : MegaWarp
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

	private void SetK(float K1, float K2)
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
