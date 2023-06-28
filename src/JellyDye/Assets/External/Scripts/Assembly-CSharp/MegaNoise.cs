using UnityEngine;

public class MegaNoise : MegaModifier
{
	public float Scale;

	public bool Fractal;

	public float Freq;

	public float Iterations;

	public bool Animate;

	public float Phase;

	public float Rough;

	public Vector3 Strength;

	private MegaPerlin iperlin;

	private float time;

	private float scale;

	private float rt;

	private Vector3 sp;

	private Vector3 d;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public override void ModStart(MegaModifiers mc)
	{
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
