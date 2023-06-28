using UnityEngine;

public class MegaMelt : MegaModifier
{
	public float Amount;

	public float Spread;

	public MegaMeltMat MaterialType;

	public float Solidity;

	public MegaAxis axis;

	public bool FlipAxis;

	private float zba;

	public float flatness;

	private float size;

	private float bulger;

	private float ybr;

	private float zbr;

	private float visvaluea;

	private int confiner;

	private int vistypea;

	private float cx;

	private float cy;

	private float cz;

	private float xsize;

	private float ysize;

	private float zsize;

	private float ooxsize;

	private float ooysize;

	private float oozsize;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private float hypot(float x, float y)
	{
		return 0f;
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
