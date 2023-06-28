using UnityEngine;

public class MegaCurveDeform : MegaModifier
{
	public MegaAxis axis;

	public AnimationCurve defCurve;

	public float MaxDeviation;

	private float width;

	private int ax;

	public float Pos;

	public bool UsePos;

	private Keyframe key;

	private static object resourceLock;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public override void DoWorkWeighted(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public Vector3 MapMT(int i, Vector3 p)
	{
		return default(Vector3);
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

	public float GetPos(float alpha)
	{
		return 0f;
	}

	public void SetKey(int index, float t, float v, float intan, float outtan)
	{
	}
}
