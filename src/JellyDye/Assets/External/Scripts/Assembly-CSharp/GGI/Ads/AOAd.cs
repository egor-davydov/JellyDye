using System;

namespace GGI.Ads
{
	public class AOAd : AdBase
	{
		public Action OnAdClicked;

		public Action OnComplete;

		public Action OnShowing;

		public AOAd(string adUnit, bool autoFetch)
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

		public virtual bool IsLoaded()
		{
			return false;
		}

		public virtual bool IsShowing()
		{
			return false;
		}

		protected void Complete()
		{
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

		protected void OnAdClickedCallback()
		{
		}

		protected void OnAdClosedCallback()
		{
		}

		protected void OnAdExpiredCallback()
		{
		}

		protected void OnAdFailedCallback()
		{
		}

		protected void DebugLog(string message)
		{
		}
	}
}
