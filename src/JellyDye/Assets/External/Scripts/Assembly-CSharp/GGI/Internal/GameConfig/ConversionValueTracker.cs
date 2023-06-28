using System.Runtime.CompilerServices;
using GGI.Ads;
using GGI.Analytics.Events;
using GGI.Components;

namespace GGI.Internal.GameConfig
{
	public class ConversionValueTracker : AutoSingleton<ConversionValueTracker>
	{
		private class CPAEvent
		{
			public bool Sent
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public string Name
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private readonly string _iapCurrencyKey;

		private readonly string _sumBannerImpressionsKey;

		private readonly string _sumBannerRevenueKey;

		private readonly string _sumIAPRevenueKey;

		private readonly string _sumInterstitialImpressionsKey;

		private readonly string _sumInterstitialRevenueKey;

		private readonly string _sumLevelEventsKey;

		private readonly string _sumRevenueKey;

		private readonly string _sumRewardedImpressionsKey;

		private readonly string _sumRewardedRevenueKey;

		private readonly string _sumSuccessfulLevelEventsKey;

		private string _iapCurrency;

		private int _sumBannerImpressions;

		private float _sumBannerRevenue;

		private double _sumIAPRevenue;

		private int _sumInterstitialImpressions;

		private float _sumInterstitialRevenue;

		private int _sumLevelEvents;

		private float _sumRevenue;

		private int _sumRewardedImpressions;

		private float _sumRewardedRevenue;

		private int _sumSuccessfulLevelEvents;

		public void Init()
		{
		}

		public void OnImpression(AdUnitType type, float revenue)
		{
		}

		public void OnLevel(LevelStatus status)
		{
		}

		public void OnInAppPurchase(double revenue, string currency)
		{
		}

		public void OnSessionChange()
		{
		}

		private void TrySendCPAEvents()
		{
		}

		public float GetSumRevenue()
		{
			return 0f;
		}

		public float GetSumBannerRevenue()
		{
			return 0f;
		}

		public float GetSumInterstitialRevenue()
		{
			return 0f;
		}

		public float GetSumRewardedRevenue()
		{
			return 0f;
		}

		public int GetSumLevelEvents()
		{
			return 0;
		}

		public int GetSumSuccessfulLevelEvents()
		{
			return 0;
		}

		public int GetBannerImpressions()
		{
			return 0;
		}

		public int GetInterstitialImpressions()
		{
			return 0;
		}

		public int GetRewardedImpressions()
		{
			return 0;
		}

		public string GetIAPCurrency()
		{
			return null;
		}

		public double GetIAPRevenue()
		{
			return 0.0;
		}

		public ConversionValueTracker()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
