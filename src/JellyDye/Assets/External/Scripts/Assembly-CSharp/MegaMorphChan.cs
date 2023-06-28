using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MegaMorphChan
{
	public string mName;

	public float Percent;

	public bool mActiveOverride;

	public bool mUseLimit;

	public float mSpinmax;

	public float mSpinmin;

	public Vector3[] mDeltas;

	public float mCurvature;

	public bool showparams;

	public bool showtargets;

	public List<MegaMorphTarget> mTargetCache;

	public MegaBezFloatKeyControl control;

	public int[] mapping;

	public bool cubic;

	public int[] morphedVerts;

	public Vector3[] oPoints;

	private float speed;

	private float targetPercent;

	public float weight;

	public float fChannelPercent;

	public int targ;

	public float fProgression;

	public int segment;

	public Vector3[] p1;

	public Vector3[] p2;

	public Vector3[] p3;

	public Vector3[] p4;

	public Vector3[] diff;

	public static void Copy(MegaMorphChan from, MegaMorphChan to)
	{
	}

	public void SetTarget(float target, float spd)
	{
	}

	public void UpdatePercent()
	{
	}

	public float GetTargetPercent(int which)
	{
		return 0f;
	}

	public void CompressChannel()
	{
	}

	public void ResetPercent()
	{
	}

	public void Rebuild(MegaMorph mp)
	{
	}

	public MegaMorphTarget GetTarget(string name)
	{
		return null;
	}

	public void ChannelMapping(MegaMorph mr)
	{
	}
}
