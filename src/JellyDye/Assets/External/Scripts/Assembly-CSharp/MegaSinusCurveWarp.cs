using UnityEngine;

public class MegaSinusCurveWarp : MegaWarp
{
	public float scale;

	public float wave;

	public float speed;

	public float phase;

	public bool animate;

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
