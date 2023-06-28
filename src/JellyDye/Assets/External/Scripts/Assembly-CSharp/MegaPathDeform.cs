using UnityEngine;

public class MegaPathDeform : MegaModifier
{
	public float percent;

	public float stretch;

	public float twist;

	public float rotate;

	public MegaAxis axis;

	public bool flip;

	public MegaShape path;

	public bool animate;

	public float speed;

	public bool drawpath;

	public float tangent;

	[HideInInspector]
	public Matrix4x4 mat;

	public bool UseTwistCurve;

	public AnimationCurve twistCurve;

	public bool UseStretchCurve;

	public AnimationCurve stretchCurve;

	public Vector3 Up;

	public int curve;

	public bool usedist;

	public float distance;

	public MegaLoopMode loopmode;

	private Vector3 start;

	private Quaternion tw;

	private float usepercent;

	private float usetan;

	private float ovlen;

	public override string ModName()
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

	public override void ModStart(MegaModifiers mc)
	{
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public void OnDrawGizmos()
	{
	}

	private void Display(MegaPathDeform pd)
	{
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
