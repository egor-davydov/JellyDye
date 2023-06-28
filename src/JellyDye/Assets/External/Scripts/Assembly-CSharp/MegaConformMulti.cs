using System.Collections.Generic;
using UnityEngine;

public class MegaConformMulti : MegaModifier
{
	public List<MegaConformTarget> targets;

	public List<Collider> conformColliders;

	public float[] offsets;

	public Bounds bounds;

	public float[] last;

	public Vector3[] conformedVerts;

	public float conformAmount;

	public float raystartoff;

	public float offset;

	public float raydist;

	public MegaAxis axis;

	private Matrix4x4 loctoworld;

	private Matrix4x4 ctm;

	private Matrix4x4 cinvtm;

	private Ray ray;

	private RaycastHit hit;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void BuildColliderList()
	{
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	private bool DoRayCast(Ray ray, ref Vector3 pos, float raydist)
	{
		return false;
	}

	public override void Modify(MegaModifiers mc)
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
}
