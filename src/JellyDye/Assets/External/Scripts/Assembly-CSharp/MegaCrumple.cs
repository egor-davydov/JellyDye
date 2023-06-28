using UnityEngine;

public class MegaCrumple : MegaModifier
{
	public float scale;

	public float speed;

	public float phase;

	public bool animate;

	private Matrix4x4 mat;

	private MegaPerlin iperlin;

	private float timex;

	private float timey;

	private float timez;

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
