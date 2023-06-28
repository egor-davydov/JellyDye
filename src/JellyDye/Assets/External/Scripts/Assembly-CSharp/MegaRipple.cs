using UnityEngine;

public class MegaRipple : MegaModifier
{
	public float amp;

	public float amp2;

	public float flex;

	public float wave;

	public float phase;

	public float Decay;

	public bool animate;

	public float Speed;

	public float radius;

	public int segments;

	public int circles;

	private float time;

	private float dy;

	private float t;

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

	private Vector3 GetPos(float u, float radius)
	{
		return default(Vector3);
	}

	private void MakeCircle(float t, float radius, float r1, float a1, float a2, float w, float s, float d, int numCircleSegs)
	{
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
