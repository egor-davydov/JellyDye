using System;
using UnityEngine;

[Serializable]
public class DoubleSlab
{
	public RenderTexture Read;

	public RenderTexture Write;

	public DoubleSlab(int width, int height, RenderTextureFormat format, FilterMode filter)
	{
	}

	public void Swap()
	{
	}
}
