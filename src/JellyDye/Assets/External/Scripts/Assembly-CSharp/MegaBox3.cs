using System;
using UnityEngine;

[Serializable]
public class MegaBox3
{
	public Vector3 center;

	public Vector3 min;

	public Vector3 max;

	public float radius;

	public Vector3[] verts;

	public Vector3 Item
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Size()
	{
		return default(Vector3);
	}

	public void SetSize(Vector3 size)
	{
	}

	public float Radius()
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}

	private Vector3 GetVert(int i)
	{
		return default(Vector3);
	}

	private void CalcVerts()
	{
	}

	public static Vector3 GetVert(Bounds bounds, int i)
	{
		return default(Vector3);
	}
}
