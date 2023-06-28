using System;
using UnityEngine;

[Serializable]
public class MegaBezVector3KeyControl : MegaControl
{
	public MegaBezVector3Key[] Keys;

	private const float SCALE = 4800f;

	public Vector3 f;

	public void Scale(float scl)
	{
	}

	public void Scale(Vector3 scl)
	{
	}

	public void Move(Vector3 scl)
	{
	}

	public void Rotate(Matrix4x4 tm)
	{
	}

	public void InitKeys()
	{
	}

	public void Interp(float alpha, int key)
	{
	}

	public override Vector3 GetVector3(float t)
	{
		return default(Vector3);
	}
}
