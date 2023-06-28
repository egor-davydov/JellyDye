using UnityEngine;

public class MegaVertNoise : MegaModifier
{
	public float Scale;

	public bool Fractal;

	public float Freq;

	public float Iterations;

	public bool Animate;

	public float Phase;

	public float Rough;

	public float Strength;

	private MegaPerlin iperlin;

	private float time;

	private float scale;

	private float rt;

	public float decay;

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
