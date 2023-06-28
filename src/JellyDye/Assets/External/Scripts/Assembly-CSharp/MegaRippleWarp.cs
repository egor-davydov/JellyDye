using UnityEngine;

public class MegaRippleWarp : MegaWarp
{
	public float amp;

	public float amp2;

	public float flex;

	public float wave;

	public float phase;

	public bool animate;

	public float Speed;

	public float radius;

	public int segments;

	public int circles;

	private float time;

	private float dy;

	private float t;

	public override string WarpName()
	{
		return null;
	}

	public override string GetIcon()
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

	private void Update()
	{
	}

	public override bool Prepare(float decay)
	{
		return false;
	}

	private Vector3 GetPos(float u, float rad)
	{
		return default(Vector3);
	}

	private void MakeCircle(float t, float rad, float r1, float a1, float a2, float w, float s, float d, int numCircleSegs)
	{
	}

	public override void DrawGizmo(Color col)
	{
	}
}
