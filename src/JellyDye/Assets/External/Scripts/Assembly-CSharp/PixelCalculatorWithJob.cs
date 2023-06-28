using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class PixelCalculatorWithJob : MonoSingleton<PixelCalculatorWithJob>
{
	private struct CalculateJob : IJob
	{
		public NativeArray<int> ColorInts;

		[ReadOnly]
		public NativeArray<Color32> colors;

		public void Execute()
		{
		}
	}

	public Material CompareMaterial;

	private CalculateJob _calculateJob;

	private JobHandle _calculateJobHandle;

	public RenderTexture _rt;

	public bool IsJobScheduled;

	public float Radius;

	public int Resolution;

	public int CompletedPixels;

	public int NotCompletedPixels;

	private NativeArray<Color32> pixels;

	private void Start()
	{
	}

	public void OnLevelStart()
	{
	}

	public void OnLevelEnd()
	{
	}

	private IEnumerator CalculateAll()
	{
		return null;
	}

	public void Compare(Texture tex, Texture2D border, Color targetColor)
	{
	}

	private IEnumerator<float> StartJob(Texture2D tex, Texture2D border, Color targetColor)
	{
		return null;
	}

	private void LateUpdate()
	{
	}

	public PixelCalculatorWithJob()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
