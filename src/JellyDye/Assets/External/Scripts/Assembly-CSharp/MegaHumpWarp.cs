using UnityEngine;

public class MegaHumpWarp : MegaWarp
{
	public float amount;

	public float cycles;

	public float phase;

	public bool animate;

	public float speed;

	public MegaAxis axis;

	private float amt;

	private Vector3 size;

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
