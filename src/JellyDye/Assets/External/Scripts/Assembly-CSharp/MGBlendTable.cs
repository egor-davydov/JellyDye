using System;
using UnityEngine;

public class MGBlendTable
{
	private int mTableSzX;

	private int mTableSzY;

	private int mnToBlend;

	private int mTableSzXY;

	private int mTotalSz;

	private float[] mpTable;

	private System.Random mRandom;

	private int LayerIndex(int nImage)
	{
		return 0;
	}

	private int PixelIndex(int x, int y)
	{
		return 0;
	}

	private int RowIndex(int y)
	{
		return 0;
	}

	private int TileX(int x)
	{
		return 0;
	}

	private int TileY(int y)
	{
		return 0;
	}

	private int Index(int nImage, int x, int y)
	{
		return 0;
	}

	private float[] GetTable()
	{
		return null;
	}

	private float GetWeight(int nImage, int x, int y)
	{
		return 0f;
	}

	private void SetWeight(int nImage, int x, int y, float w)
	{
	}

	private void GetTileSz(out int xSz, out int ySz)
	{
		xSz = default(int);
		ySz = default(int);
	}

	private float dummyNoise()
	{
		return 0f;
	}

	private float RandomNoise()
	{
		return 0f;
	}

	public MGBlendTable(int tableX, int tableY, int nToBlend, float ditherAmt, bool normalizeTable)
	{
	}

	public void BlendImages(Color[,] pDstBM, Color[,] pSrcBM, int width, int height, int nImage)
	{
	}
}
