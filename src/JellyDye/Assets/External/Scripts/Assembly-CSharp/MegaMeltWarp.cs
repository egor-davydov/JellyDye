using UnityEngine;

public class MegaMeltWarp : MegaWarp
{
	public float Amount;

	public float Spread;

	public MegaMeltMat MaterialType;

	public float Solidity;

	public MegaAxis axis;

	public bool FlipAxis;

	private float zba;

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

	public float flatness;

	private Vector3 max;

	private Vector3 min;

	public override string WarpName()
	{
		return null;
	}

	public override string GetIcon()
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

	public override bool Prepare(float decay)
	{
		return false;
	}
}
