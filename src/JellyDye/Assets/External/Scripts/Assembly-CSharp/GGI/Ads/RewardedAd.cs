using System;

namespace GGI.Ads
{
	public class RewardedAd : AdBase
	{
		public Action<bool> OnComplete;

		public static Action OnRewardedLoaded;

		protected bool IsFetching;

		protected bool _isShowing;

		protected RewardedAd(string adUnit, bool autoFetch)
			: base(null, autoFetch: false)
		{
		}

		protected override void Request()
		{
		}

		protected virtual void AutoRequest()
		{
		}

		public virtual void Show()
		{
		}

		public virtual bool IsShowing()
		{
			return false;
		}

		protected void Complete(bool complete)
		{
		}

		public virtual bool IsLoaded()
		{
			return false;
		}

		public void Destroy()
		{
		}

		protected virtual void RegisterEvents()
		{
		}

		protected virtual void UnregisterEvents()
		{
		}

		protected void OnAdLoadedCallback()
		{
		}

		protected void OnAdFailedCallback(string errorMsg)
		{
		}

		protected void OnAdFailedToPlayCallback(string errorMsg)
		{
		}

		protected void OnAdExpiredCallback()
		{
		}

		protected void OnAdHidden()
		{
		}

		protected void OnAdReceivedRewardCallback()
		{
		}

		protected void DebugLog(string message)
		{
		}
	}
}
