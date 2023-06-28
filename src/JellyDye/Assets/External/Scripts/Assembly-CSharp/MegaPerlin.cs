using UnityEngine;

public class MegaPerlin
{
	private static MegaPerlin instance;

	private static int[] p;

	private static int[] permutation;

	public static MegaPerlin Instance => null;

	public int Perm(int i)
	{
		return 0;
	}

	public float Noise(float x)
	{
		return 0f;
	}

	public float Noise(float x, float y)
	{
		return 0f;
	}

	public float Noise(float x, float y, float z)
	{
		return 0f;
	}

	private float fade(float t)
	{
		return 0f;
	}

	private float lerp(float t, float a, float b)
	{
		return 0f;
	}

	private static float grad(int hash, float x)
	{
		return 0f;
	}

	private float grad(int hash, float x, float y)
	{
		return 0f;
	}

	private float grad(int hash, float x, float y, float z)
	{
		return 0f;
	}

	public float fBm1(float x, float H, float lacunarity, float octaves)
	{
		return 0f;
	}

	public float fBm1(Vector3 vertex, float H, float lacunarity, float octaves)
	{
		return 0f;
	}

	public float fBm1(float x, float y, float z, float H, float lacunarity, float octaves)
	{
		return 0f;
	}
}
