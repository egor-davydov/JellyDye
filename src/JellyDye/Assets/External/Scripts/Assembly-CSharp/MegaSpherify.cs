using UnityEngine;

public class MegaSpherify : MegaModifier
{
	public float percent;

	public float FallOff;

	private float per;

	private float xsize;

	private float ysize;

	private float zsize;

	private float size;

	private float cx;

	private float cy;

	private float cz;

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

	public override void ModStart(MegaModifiers mc)
	{
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
