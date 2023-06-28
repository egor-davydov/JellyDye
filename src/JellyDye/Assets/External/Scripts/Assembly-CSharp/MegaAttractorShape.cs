using UnityEngine;

public class MegaAttractorShape : MegaModifier
{
	public MegaShape shape;

	public int curve;

	public MegaAttractType attractType;

	public float distance;

	public float rotate;

	public float force;

	public float slide;

	public AnimationCurve crv;

	public int itercount;

	private int k;

	private Vector3 tangent;

	private float alpha;

	private Vector3 delta;

	private Vector3 nvp;

	private Vector3 dir;

	private Matrix4x4 rottm;

	private float slidealpha;

	private Matrix4x4 swtm;

	private Matrix4x4 swltm;

	private Matrix4x4 lwtm;

	private Matrix4x4 wltm;

	public float limit;

	private float limit2;

	private Vector3 shapepos;

	public bool flat;

	public bool splinechanged;

	private float positiveInfinity;

	private float num2;

	public Vector3[] points;

	private Vector3 tp;

	private Vector3 qc;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public Vector3 FindNearestPointWorld(Vector3 p, int iterations, ref float alpha)
	{
		return default(Vector3);
	}

	private void Start()
	{
	}

	private void PrepareShape()
	{
	}

	private void Find(Vector3 p)
	{
	}

	public Vector3 FindNearestPoint(Vector3 p, int iterations, ref float alpha)
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
