using UnityEngine;

public class MegaBulge : MegaModifier
{
	public Vector3 Amount;

	public Vector3 FallOff;

	public bool LinkFallOff;

	private Vector3 per;

	private float xsize;

	private float ysize;

	private float zsize;

	private float size;

	private float cx;

	private float cy;

	private float cz;

	private Vector3 dcy;

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
