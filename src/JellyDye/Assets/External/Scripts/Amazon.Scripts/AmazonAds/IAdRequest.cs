using System.Collections;
using UnityEngine;

namespace AmazonAds
{
	public abstract class IAdRequest
	{
		protected static class Schedule
		{
			private class Runner : MonoBehaviour
			{
			}

			private static Runner _backer;

			private static float expiration;

			private static Runner Backer => null;

			public static void WaitForAdResponce(IFetchManager fetchManager, Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
			{
			}

			private static IEnumerator WaitForAdResponceCoroutine(IFetchManager fetchManager, Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
			{
				return null;
			}

			public static void Clear()
			{
			}
		}

		protected int refreshTime;

		protected string autoRefreshID;

		protected bool isAutoRefreshAdMob;

		protected bool isAutoRefreshMoPub;

		protected bool requestHasBeenUsed;

		protected IFetchManager fetchManager;

		public abstract void PutCustomTarget(string key, string value);

		public abstract void SetSizes(IAdSize sizes);

		public abstract void SetSizes(IInterstitialAdSize sizes);

		public abstract void SetSizes(IVideo sizes);

		public abstract void SetSlotGroup(string slotGroupName);

		public abstract void LoadAd(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success);

		public abstract void LoadAd(Amazon.OnFailureWithErrorDelegate failure, Amazon.OnSuccessDelegate success);

		public abstract void LoadSmartBanner(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success);

		public abstract void LoadSmartBanner(Amazon.OnFailureWithErrorDelegate failure, Amazon.OnSuccessDelegate success);

		public abstract void SetAutoRefreshAdMob(bool flag, bool isSmartBanner = false);

		public abstract void SetAutoRefreshMoPub(bool flag);

		public abstract void SetAutoRefreshMoPub(bool flag, int refreshTime);

		public abstract void SetAutoRefresh();

		public abstract void SetAutoRefresh(int secs);

		public abstract void ResumeAutoRefresh();

		public abstract void StopAutoRefresh();

		public abstract void PauseAutoRefresh();

		public bool IsAutoRefreshAdMob()
		{
			return false;
		}

		public bool IsAutoRefreshMoPub()
		{
			return false;
		}

		public string AutoRefreshID()
		{
			return null;
		}

		public abstract void DisposeAd();

		public abstract void CreateFetchManager(bool isSmartBanner = false);

		public abstract void DestroyFetchManager();

		public abstract void StopFetchManager();

		public abstract void StartFetchManager();

		public abstract void SetRefreshFlag(bool flag);
	}
}
