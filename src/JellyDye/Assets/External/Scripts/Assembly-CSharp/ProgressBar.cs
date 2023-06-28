using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine.UI;

public class ProgressBar : MonoSingleton<ProgressBar>
{
	public ProgressBarFill BarPrefab;

	public Image DotPrefab;

	public float ScaleUp;

	private List<ProgressBarFill> Fills;

	private Image Dot;

	private int count;

	private void Start()
	{
	}

	[Button]
	public void OnLevelStart(int test = -1)
	{
	}

	public void OnNextPiece(int index)
	{
	}

	private void DestroyGarbage()
	{
	}

	public ProgressBar()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
