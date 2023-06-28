using System;
using UnityEngine;

[Serializable]
public class MegaKnotAnimCurve
{
	public AnimationCurve px;

	public AnimationCurve py;

	public AnimationCurve pz;

	public AnimationCurve ix;

	public AnimationCurve iy;

	public AnimationCurve iz;

	public AnimationCurve ox;

	public AnimationCurve oy;

	public AnimationCurve oz;

	public void GetState(MegaKnot knot, float t)
	{
	}

	public void AddKey(MegaKnot knot, float t)
	{
	}

	public void MoveKey(MegaKnot knot, float t, int k)
	{
	}

	public void RemoveKey(int k)
	{
	}
}
