using System.Collections.Generic;
using UnityEngine;

public class MegaMorphRef : MegaMorphBase
{
	public MegaMorph source;

	public bool UseLimit;

	public float Max;

	public float Min;

	public int[] mapping;

	public float importScale;

	public bool flipyz;

	public bool negx;

	[HideInInspector]
	public float tolerance;

	public bool showmapping;

	public float mappingSize;

	public int mapStart;

	public int mapEnd;

	private Vector3[] dif;

	private static Vector3[] endpoint;

	private static Vector3[] splinepoint;

	private static Vector3[] temppoint;

	private Vector3[] p1;

	private Vector3[] p2;

	private Vector3[] p3;

	private Vector3[] p4;

	public List<float> pers;

	[HideInInspector]
	public int compressedmem;

	[HideInInspector]
	public int compressedmem1;

	[HideInInspector]
	public int memuse;

	public bool animate;

	public float atime;

	public float animtime;

	public float looptime;

	public MegaRepeatMode repeatMode;

	public float speed;

	private static int framenum;

	private Vector3[] _verts;

	private Vector3[] _sverts;

	private bool mtmorphed;

	private int[] setStart;

	private int[] setEnd;

	private int[] copyStart;

	private int[] copyEnd;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void SetSource(MegaMorph src)
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

	private void SetVerts(int j, Vector3[] p)
	{
	}

	private void SetVerts(MegaMorphChan chan, int j, Vector3[] p)
	{
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	private bool Changed(int v, int c)
	{
		return false;
	}

	public void ModifyCompressed(MegaModifiers mc)
	{
	}

	public override void PrepareMT(MegaModifiers mc, int cores)
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public void PrepareForMT(MegaModifiers mc, int cores)
	{
	}

	public void ModifyCompressedMT(MegaModifiers mc, int tindex, int cores)
	{
	}

	private int Find(int index)
	{
		return 0;
	}

	private void BuildMorphVertInfo(int cores)
	{
	}

	public void SetAnimTime(float t)
	{
	}
}
