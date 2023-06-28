using UnityEngine;

public class MegaHump : MegaModifier
{
	public float amount;

	public float cycles;

	public float phase;

	public bool animate;

	public float speed;

	public MegaAxis axis;

	private float amt;

	private Vector3 size;

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
}
