using System;
using System.Runtime.CompilerServices;

namespace GGI.Ads
{
	public class BannerAd : AdBase
	{
		public Action<float> OnAdShown;

		public Action OnAdClicked;

		protected bool _isShowing;

		public Action initializeNextAdUnit;

		public bool isBannerInitialized;

		public static event Action OnBannerShowing
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnBannerHiding
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BannerAd(string adUnit, bool autoFetch)
			: base(null, autoFetch: false)
		{
		}

		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		public virtual void Destroy()
		{
		}

		protected virtual void RegisterEvents()
		{
		}

		protected virtual void UnregisterEvents()
		{
		}

		protected void OnAdFailedCallback(string errorMsg)
		{
		}

		protected void OnAdLoadedCallback(float height)
		{
		}

		protected void OnAdClickedCallback()
		{
		}

		private void DebugLog(string message)
		{
		}
	}
}
