using UnityEngine;

public class MegaTreeBend : MegaModifier
{
	public float fBendScale;

	public Vector3 vWind;

	public float WindDir;

	public float WindSpeed;

	private Vector2 waveIn;

	private Vector2 waves;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private float frac(float val)
	{
		return 0f;
	}

	private Vector2 smoothCurve(Vector2 x)
	{
		return default(Vector2);
	}

	private Vector2 triangleWave(Vector2 x)
	{
		return default(Vector2);
	}

	private Vector2 smoothTriangleWave(Vector2 x)
	{
		return default(Vector2);
	}

	private float windTurbulence(float bbPhase, float frequency, float strength)
	{
		return 0f;
	}

	private Vector2 windEffect(float bbPhase, Vector2 windDirection, float gustLength, float gustFrequency, float gustStrength, float turbFrequency, float turbStrength)
	{
		return default(Vector2);
	}

	public override void SetValues(MegaModifier mod)
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
