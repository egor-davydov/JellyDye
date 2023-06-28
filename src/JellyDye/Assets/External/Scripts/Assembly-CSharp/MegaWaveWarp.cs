using UnityEngine;

public class MegaWaveWarp : MegaWarp
{
	public float amp;

	public float amp2;

	public float flex;

	public float wave;

	public float phase;

	public bool animate;

	public float Speed;

	public int divs;

	public int numSegs;

	public int numSides;

	private float time;

	private float dy;

	private float dist;

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

	private void BuildMesh(float t)
	{
	}

	public override void DrawGizmo(Color col)
	{
	}
}
