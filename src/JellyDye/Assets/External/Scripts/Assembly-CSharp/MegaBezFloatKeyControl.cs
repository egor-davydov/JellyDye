using System;
using UnityEngine;

[Serializable]
public class MegaBezFloatKeyControl : MegaControl
{
	public MegaBezFloatKey[] Keys;

	private const float SCALE = 4800f;

	public float f;

	public void InitKeys()
	{
	}

	public void InitKeys(float scale)
	{
	}

	public void InitKeysMaya()
	{
	}

	public float GetHermiteFloat(float tt)
	{
		return 0f;
	}

	public void MakeKey(MegaBezFloatKey key, Vector2 pco, Vector2 pleft, Vector2 pright, Vector2 co, Vector2 left, Vector2 right)
	{
	}

	public void Interp(float alpha, int key)
	{
	}

	public override float GetFloat(float t)
	{
		return 0f;
	}
}
