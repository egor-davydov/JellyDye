using System;
using UnityEngine;

[Serializable]
public class MegaSculptCurve
{
	public AnimationCurve curve;

	public Vector3 offamount;

	public Vector3 sclamount;

	public MegaAxis axis;

	public MegaAffect affectOffset;

	public MegaAffect affectScale;

	public bool enabled;

	public float weight;

	public string name;

	public Color regcol;

	public Vector3 origin;

	public Vector3 boxsize;

	public bool uselimits;

	public Vector3 size;

	public static MegaSculptCurve Create()
	{
		return null;
	}
}
