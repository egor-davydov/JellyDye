using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
	public float updateInterval;

	public bool showMedian;

	public float medianLearnrate;

	private float accum;

	private int frames;

	private float timeleft;

	private float currentFPS;

	private float median;

	private float average;

	private Text uguiText;

	public float CurrentFPS => 0f;

	public float FPSMedian => 0f;

	public float FPSAverage => 0f;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ResetMedianAndAverage()
	{
	}
}
