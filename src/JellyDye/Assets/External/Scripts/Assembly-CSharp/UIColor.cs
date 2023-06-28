using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class UIColor : MonoBehaviour
{
	public LevelColor Data;

	public Image ColorImage;

	public Image RewardedImage;

	public Image LoadingImage;

	public Sprite RewardedSprite;

	public Sprite RewardedInactiveSprite;

	public bool IsRewarded;

	public bool IsSelected;

	public float Scale;

	public AnimationCurve SelectAnimCurve;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void MoPubManagerOnRewardedVideoLoadedEvent(string obj, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void Update()
	{
	}

	public void SetData(LevelColor data)
	{
	}

	public void OnColorSelect()
	{
	}

	[Button]
	private void UpdateView()
	{
	}
}
