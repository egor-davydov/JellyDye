using GGI.Components;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI
{
	public class BannerBackground : AutoSingletonMono<BannerBackground>
	{
		private Image _image;

		private RectTransform _rect;

		private float _calculatedBannerHeight;

		protected override void Awake()
		{
		}

		public void SetColor(Color color)
		{
		}

		private void Start()
		{
		}

		private void MoPubManagerOnOnAdLoadedEvent(string arg1, MaxSdkBase.AdInfo adInfo)
		{
		}

		public float CalculateBannerHeight()
		{
			return 0f;
		}

		private bool IsTablet()
		{
			return false;
		}

		public float GetBannerHeight()
		{
			return 0f;
		}

		public void SetBannerHeight(float height)
		{
		}

		private void OnDestroy()
		{
		}

		private void Hide()
		{
		}

		private void Show()
		{
		}

		public BannerBackground()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
