using System;
using System.Collections.Generic;

[Serializable]
public class MegaSplineAnim
{
	public bool Enabled;

	public List<MegaKnotAnimCurve> knots;

	public void SetState(MegaSpline spline, float t)
	{
	}

	public void GetState1(MegaSpline spline, float t)
	{
	}

	private int FindKey(float t)
	{
		return 0;
	}

	public void AddState(MegaSpline spline, float t)
	{
	}

	public void Remove(float t)
	{
	}

	public void RemoveKey(int k)
	{
	}

	public void Init(MegaSpline spline)
	{
	}

	public int NumKeys()
	{
		return 0;
	}

	public float GetKeyTime(int k)
	{
		return 0f;
	}

	public void SetKeyTime(MegaSpline spline, int k, float t)
	{
	}

	public void GetKey(MegaSpline spline, int k)
	{
	}

	public void UpdateKey(MegaSpline spline, int k)
	{
	}
}
