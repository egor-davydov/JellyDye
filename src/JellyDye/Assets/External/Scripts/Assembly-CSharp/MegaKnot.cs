using System;
using UnityEngine;

[Serializable]
public class MegaKnot
{
	public Vector3 p;

	public Vector3 invec;

	public Vector3 outvec;

	public float seglength;

	public float length;

	public bool notlocked;

	public float twist;

	public int id;

	public float[] lengths;

	public Vector3[] points;

	public Vector3 Interpolate(float t, MegaKnot k)
	{
		return default(Vector3);
	}

	public Vector3 InterpolateCS(float t, MegaKnot k)
	{
		return default(Vector3);
	}

	public Vector3 Tangent(float t, MegaKnot k)
	{
		return default(Vector3);
	}
}
