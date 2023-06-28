using UnityEngine;

public class MegaCurveSculpt : MegaModifier
{
	public AnimationCurve defCurveX;

	public AnimationCurve defCurveY;

	public AnimationCurve defCurveZ;

	public AnimationCurve defCurveSclX;

	public AnimationCurve defCurveSclY;

	public AnimationCurve defCurveSclZ;

	public Vector3 OffsetAmount;

	public Vector3 ScaleAmount;

	private Vector3 size;

	public MegaAxis offsetX;

	public MegaAxis offsetY;

	public MegaAxis offsetZ;

	public MegaAxis scaleX;

	public MegaAxis scaleY;

	public MegaAxis scaleZ;

	public bool symX;

	public bool symY;

	public bool symZ;

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
}
