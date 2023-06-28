using System.Collections.Generic;
using UnityEngine;

public class MegaRubber : MegaModifier
{
	public MegaRubberType Presets;

	public MegaWeightChannel channel;

	public MegaWeightChannel stiffchannel;

	public Vector3 Intensity;

	public float gravity;

	public float mass;

	public Vector3 stiffness;

	public Vector3 damping;

	public float threshold;

	public float size;

	public bool showweights;

	private float oomass;

	private float grav;

	private bool defined;

	public VertexRubber[] vr;

	private int[] notmoved;

	public Transform target;

	private bool weightsChanged;

	private MegaModifiers mods;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void ResetPhysics()
	{
	}

	private int[] FindVerts(Vector3[] vts, Vector3 p)
	{
		return null;
	}

	private bool HavePoint(Vector3[] vts, List<int> points, Vector3 p)
	{
		return false;
	}

	private void Init(MegaModifiers mod)
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

	public override void Modify(MegaModifiers mc)
	{
	}

	public void SetTarget(Transform target)
	{
	}

	private void InitVerts(int start, int end)
	{
	}

	private void UpdateVerts(int start, int end)
	{
	}

	public void ChangeMaterial()
	{
	}

	public void ChangeChannel()
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public void ModifyCompressedMT(MegaModifiers mc, int tindex, int cores)
	{
	}

	private MegaModifiers GetMod()
	{
		return null;
	}

	public void UpdateCols(int first, Color[] newcols)
	{
	}

	public void UpdateCol(int i, Color col)
	{
	}

	public void UpdateCols(Color[] newcols)
	{
	}
}
