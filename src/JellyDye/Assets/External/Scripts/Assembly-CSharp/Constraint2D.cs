using System;
using UnityEngine;

[Serializable]
public class Constraint2D
{
	public bool active;

	public int p1;

	public int p2;

	public float length;

	public Vector2 pos;

	public int contype;

	public Transform obj;

	public static Constraint2D CreatePointTargetCon(int _p1, Transform trans)
	{
		return null;
	}

	public static Constraint2D CreateLenCon(int _p1, int _p2, float _len)
	{
		return null;
	}

	public static Constraint2D CreatePointCon(int _p1, Vector2 _pos)
	{
		return null;
	}

	public void Apply(MegaSoft2D soft)
	{
	}

	public void ApplyLengthConstraint2D(MegaSoft2D soft)
	{
	}

	public void ApplyPointConstraint2D(MegaSoft2D soft)
	{
	}

	public void ApplyAngleConstraint(MegaSoft2D soft)
	{
	}
}
