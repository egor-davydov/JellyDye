using UnityEngine;

public class MegaMorphOMatic : MegaMorphBase
{
	public bool UseLimit;

	public float Max;

	public float Min;

	public float importScale;

	public bool flipyz;

	public bool negx;

	public bool glUseLimit;

	public float glMin;

	public float glMax;

	public float tolerance;

	public bool animate;

	public float atime;

	public float animtime;

	public float looptime;

	public MegaRepeatMode repeatMode;

	public float speed;

	public Vector3[] oPoints;

	public MegaMomVertMap[] mapping;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	private Vector3 Cubic(MegaMorphTarget t, int pointnum, float alpha)
	{
		return default(Vector3);
	}

	public static void Bez3D(out Vector3 b, ref Vector3[] p, float u)
	{
		b = default(Vector3);
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public override void PrepareMT(MegaModifiers mc, int cores)
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}
}
