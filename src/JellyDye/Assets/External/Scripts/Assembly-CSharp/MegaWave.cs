using UnityEngine;

public class MegaWave : MegaModifier
{
	public float amp;

	public float amp2;

	public float flex;

	public float wave;

	public float phase;

	public float Decay;

	public float dir;

	public bool animate;

	public float Speed;

	public int divs;

	public int numSegs;

	public int numSides;

	private float time;

	private float dy;

	private float dist;

	private float t;

	private Matrix4x4 mat;

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

	private void BuildMesh(float t)
	{
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
