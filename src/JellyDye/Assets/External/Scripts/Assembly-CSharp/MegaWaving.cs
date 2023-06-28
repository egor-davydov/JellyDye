using UnityEngine;

public class MegaWaving : MegaModifier
{
	public float amp;

	public float flex;

	public float wave;

	public float phase;

	public float Decay;

	public bool animate;

	public float Speed;

	public MegaAxis waveaxis;

	private float time;

	private float dy;

	private int ix;

	private int iz;

	private float t;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public static float WaveFunc(float radius, float t, float amp, float waveLen, float phase, float decay)
	{
		return 0f;
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
