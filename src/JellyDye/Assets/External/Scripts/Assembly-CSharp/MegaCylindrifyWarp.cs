using UnityEngine;

public class MegaCylindrifyWarp : MegaWarp
{
	public float Percent;

	private float size1;

	private float per;

	public MegaAxis axis;

	private Matrix4x4 mat;

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

	private void Update()
	{
	}

	public override bool Prepare(float decay)
	{
		return false;
	}
}
