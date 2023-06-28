using UnityEngine;

public class MegaGlobeWarp : MegaWarp
{
	public float dir;

	public float dir1;

	public MegaAxis axis;

	public MegaAxis axis1;

	private Matrix4x4 mat;

	public bool twoaxis;

	private Matrix4x4 tm1;

	private Matrix4x4 invtm1;

	public float r;

	public float r1;

	public float radius;

	public bool linkRadii;

	public float radius1;

	public override string WarpName()
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

	private void Calc()
	{
	}

	public override bool Prepare(float decay)
	{
		return false;
	}
}
