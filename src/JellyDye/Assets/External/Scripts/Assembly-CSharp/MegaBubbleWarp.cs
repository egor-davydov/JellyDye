using UnityEngine;

public class MegaBubbleWarp : MegaWarp
{
	public float radius;

	public float falloff;

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
