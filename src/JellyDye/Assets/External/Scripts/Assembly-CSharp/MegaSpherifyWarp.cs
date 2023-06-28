using UnityEngine;

public class MegaSpherifyWarp : MegaWarp
{
	public float percent;

	public float FallOff;

	private float per;

	private float xsize;

	private float ysize;

	private float zsize;

	private float size;

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
