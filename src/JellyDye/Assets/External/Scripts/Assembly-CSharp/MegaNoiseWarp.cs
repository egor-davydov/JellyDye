using UnityEngine;

public class MegaNoiseWarp : MegaWarp
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

	private Vector3 d;

	private Vector3 sp;

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
