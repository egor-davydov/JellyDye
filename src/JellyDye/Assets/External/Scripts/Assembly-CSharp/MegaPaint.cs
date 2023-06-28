using System.Collections.Generic;
using UnityEngine;

public class MegaPaint : MegaModifier
{
	public float radius;

	public float amount;

	public float decay;

	public bool usedecay;

	public MegaFallOff fallOff;

	public float gaussc;

	public bool useAvgNorm;

	public Vector3 normal;

	public MegaPaintMode mode;

	private bool hadahit;

	private Vector3 relativePoint;

	private List<int> affected;

	private List<float> distances;

	private Matrix4x4 mat;

	private Vector3[] offsets;

	private Vector3[] normals;

	private Collider mycollider;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private static float LinearFalloff(float distance, float inRadius)
	{
		return 0f;
	}

	private static float PointFalloff(float dist, float inRadius)
	{
		return 0f;
	}

	public static float GaussFalloff(float v, float c)
	{
		return 0f;
	}

	private float Gaussian(float dist, float width)
	{
		return 0f;
	}

	private void DeformMesh(Vector3 position, float power, float inRadius)
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

	public override void PrepareMT(MegaModifiers mc, int cores)
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}
}
