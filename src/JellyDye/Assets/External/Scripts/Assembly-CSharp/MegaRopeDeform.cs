using UnityEngine;

public class MegaRopeDeform : MegaModifier
{
	public float floorOff;

	public int NumMasses;

	public MegaSoft2D soft;

	public float timeStep;

	public float Mass;

	public MegaAxis axis;

	public AnimationCurve stiffnessCrv;

	public float stiffspring;

	public float stiffdamp;

	public float spring;

	public float damp;

	public float off;

	public bool init;

	public float SpringCompress;

	public bool BendSprings;

	public bool Constraints;

	public float DampingRatio;

	public int pconl;

	public int pconr;

	public bool DisplayDebug;

	public int drawsteps;

	public float boxsize;

	public Transform left;

	public Transform right;

	public float weight;

	public float weightPos;

	public Vector2[] masspos;

	private int ax;

	private float minx;

	private float width;

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

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public void Build(MegaModContext mc)
	{
	}

	public void UpdateRope()
	{
	}

	public void Init()
	{
	}

	private void DrawSpline(int steps)
	{
	}

	public void OnDrawGizmos()
	{
	}

	private void Display()
	{
	}

	public Vector2 Interp1(float t)
	{
		return default(Vector2);
	}

	public Vector2 Interp1a(float t)
	{
		return default(Vector2);
	}

	private void AddWeight()
	{
	}

	public float GetPos(float alpha)
	{
		return 0f;
	}

	public Vector2 GetPos2(float alpha)
	{
		return default(Vector2);
	}

	public Vector2 GetPos3(float v)
	{
		return default(Vector2);
	}

	public Vector2 SetWeight(float v, float weight)
	{
		return default(Vector2);
	}
}
