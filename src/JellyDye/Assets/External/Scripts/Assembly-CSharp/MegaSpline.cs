using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MegaSpline
{
	public float length;

	public bool closed;

	public List<MegaKnot> knots;

	public List<MegaKnotAnim> animations;

	public Vector3 offset;

	public Vector3 rotate;

	public Vector3 scale;

	public bool reverse;

	public int outlineSpline;

	public float outline;

	public bool constantSpeed;

	public int subdivs;

	public MegaShapeEase twistmode;

	public MegaSplineAnim splineanim;

	public static MegaSpline Copy(MegaSpline src)
	{
		return null;
	}

	public float KnotDistance(int k, int k1)
	{
		return 0f;
	}

	public void AddKnot(Vector3 p, Vector3 invec, Vector3 outvec)
	{
	}

	public void AddKnot(Vector3 p, Vector3 invec, Vector3 outvec, Matrix4x4 tm)
	{
	}

	public bool Contains(Vector3 p)
	{
		return false;
	}

	public float Area()
	{
		return 0f;
	}

	public float CalcLength(int steps)
	{
		return 0f;
	}

	public float CalcLength()
	{
		return 0f;
	}

	public float GetTwist(float alpha)
	{
		return 0f;
	}

	public Vector3 Interpolate(float alpha, bool type, ref int k)
	{
		return default(Vector3);
	}

	public Vector3 InterpolateCS(float alpha, bool type, ref int k)
	{
		return default(Vector3);
	}

	private float easeInOutSine(float start, float end, float value)
	{
		return 0f;
	}

	private float TwistVal(float v1, float v2, float alpha)
	{
		return 0f;
	}

	public Vector3 Interpolate(float alpha, bool type, ref int k, ref float twist)
	{
		return default(Vector3);
	}

	public Vector3 InterpolateCS(float alpha, bool type, ref int k, ref float twist)
	{
		return default(Vector3);
	}

	public Vector3 InterpCurve3D(float alpha, bool type, ref int k)
	{
		return default(Vector3);
	}

	public Vector3 InterpBezier3D(int knot, float a)
	{
		return default(Vector3);
	}

	public void Centre(float scale)
	{
	}

	public void Reverse()
	{
	}

	public void SetHeight(float y)
	{
	}

	public void SetTwist(float twist)
	{
	}
}
