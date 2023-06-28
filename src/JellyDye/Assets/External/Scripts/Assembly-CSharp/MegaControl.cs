using System;
using UnityEngine;

[Serializable]
public class MegaControl
{
	public float[] Times;

	[HideInInspector]
	public int lastkey;

	[HideInInspector]
	public float lasttime;

	public virtual float GetFloat(float time)
	{
		return 0f;
	}

	public virtual Vector3 GetVector3(float time)
	{
		return default(Vector3);
	}

	private int BinSearch(float t, int low, int high)
	{
		return 0;
	}

	public int GetKey(float t)
	{
		return 0;
	}
}
