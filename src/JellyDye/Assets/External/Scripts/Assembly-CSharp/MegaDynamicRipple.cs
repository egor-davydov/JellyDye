using UnityEngine;

public class MegaDynamicRipple : MegaModifier
{
	public MegaAxis axis;

	public int cols;

	public int rows;

	[HideInInspector]
	public float[] buffer1;

	[HideInInspector]
	public float[] buffer2;

	[HideInInspector]
	public int[] vertexIndices;

	public float damping;

	public float WaveHeight;

	public float Force;

	public float DropsPerSec;

	public float speed;

	public float[] input;

	public float inputdamp;

	public float InputForce;

	public bool Obstructions;

	public float[] blockers;

	private float time;

	public float scale;

	private bool swapMe;

	public bool bilinearSample;

	public Texture2D obTexture;

	private Collider mycollider;

	private float[] currentBuffer;

	public int vertcomponent;

	public int wakesize;

	public float wakefalloff;

	public float wakeforce;

	private float lastcol;

	private float lastrow;

	private bool lastdown;

	private int xc;

	private int yc;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void ResetGrid()
	{
	}

	public void SetObstructions(Texture2D obtex)
	{
	}

	public override void Modify(MegaModifiers mc)
	{
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

	private void Setup()
	{
	}

	private void splashAtPoint(int x, int y, float force)
	{
	}

	private void splashAtPoint1(int x, int y, float force)
	{
	}

	private int ipart(float x)
	{
		return 0;
	}

	private int round(float x)
	{
		return 0;
	}

	private float fpart(float x)
	{
		return 0f;
	}

	private float rfpart(float x)
	{
		return 0f;
	}

	private void swap(ref float v1, ref float v2)
	{
	}

	private void plot(int x, int y, float force)
	{
	}

	private void drawLine(float x1, float y1, float x2, float y2, float force)
	{
	}

	private void wakeAtPointWu(float x, float y, float force)
	{
	}

	public void wakeAtPointAdd1(float x, float y, float force)
	{
	}

	private void wakeAtPointAdd(int x, int y, float force)
	{
	}

	private void wakeAtPoint(int x, int y, float force)
	{
	}

	private void processRipples(float[] source, float[] dest)
	{
	}

	private void Update()
	{
	}

	public float GetWaterHeight(Vector3 lpos)
	{
		return 0f;
	}

	private void checkInput()
	{
	}

	private void checkInput1()
	{
	}

	private void Line(float x0, float y0, float x1, float y1)
	{
	}

	public void Line(float x0, float y0, float x1, float y1, float force)
	{
	}

	public void ForceAt(float x, float y, float force)
	{
	}

	public void ForceAt(Vector3 p, float force)
	{
	}

	private void BuildMesh()
	{
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
