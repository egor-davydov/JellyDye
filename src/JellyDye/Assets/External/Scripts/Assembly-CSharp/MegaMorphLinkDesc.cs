using System;
using UnityEngine;

[Serializable]
public class MegaMorphLinkDesc
{
	public string name;

	public Transform target;

	public int channel;

	public MegaAxis axis;

	public MegaLinkSrc src;

	public float min;

	public float max;

	public bool useCurve;

	public AnimationCurve curve;

	public bool late;

	public bool active;

	public Quaternion rot;

	public float low;

	public float high;

	private float Ang(Quaternion rotationA, Quaternion rotationB, MegaLinkSrc t)
	{
		return 0f;
	}

	public float GetVal()
	{
		return 0f;
	}

	public void Update(MegaMorph morph, bool islate)
	{
	}
}
