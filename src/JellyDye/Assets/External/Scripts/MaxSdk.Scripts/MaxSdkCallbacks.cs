using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaxSdkCallbacks : MonoBehaviour
{
	public class Interstitial
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdHiddenEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class AppOpen
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdHiddenEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class Rewarded
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.Reward, MaxSdkBase.AdInfo> OnAdReceivedRewardEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdHiddenEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class RewardedInterstitial
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdDisplayedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> OnAdDisplayFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.Reward, MaxSdkBase.AdInfo> OnAdReceivedRewardEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdHiddenEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class Banner
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdExpandedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdCollapsedEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class MRec
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdExpandedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdCollapsedEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	public class CrossPromo
	{
		public static event Action<string, MaxSdkBase.AdInfo> OnAdLoadedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.ErrorInfo> OnAdLoadFailedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdClickedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdRevenuePaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdExpandedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string, MaxSdkBase.AdInfo> OnAdCollapsedEvent
		{
			add
			{
			}
			remove
			{
			}
		}
	}

	private static Action<MaxSdkBase.SdkConfiguration> _onSdkInitializedEvent;

	private static Action _onVariablesUpdatedEvent;

	private static Action _onSdkConsentDialogDismissedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onInterstitialAdLoadedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo> _onInterstitialAdLoadFailedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onInterstitialAdDisplayedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> _onInterstitialAdFailedToDisplayEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onInterstitialAdClickedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onInterstitialAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onInterstitialAdHiddenEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onAppOpenAdLoadedEvent;

	private static Action<string, MaxSdkBase.ErrorInfo> _onAppOpenAdLoadFailedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onAppOpenAdDisplayedEvent;

	private static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> _onAppOpenAdFailedToDisplayEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onAppOpenAdClickedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onAppOpenAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onAppOpenAdHiddenEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedAdLoadedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo> _onRewardedAdLoadFailedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedAdDisplayedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> _onRewardedAdFailedToDisplayEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedAdClickedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.Reward, MaxSdkBase.AdInfo> _onRewardedAdReceivedRewardEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedAdHiddenEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedInterstitialAdLoadedEvent;

	private static Action<string, MaxSdkBase.ErrorInfo> _onRewardedInterstitialAdLoadFailedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedInterstitialAdDisplayedEvent;

	private static Action<string, MaxSdkBase.ErrorInfo, MaxSdkBase.AdInfo> _onRewardedInterstitialAdFailedToDisplayEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedInterstitialAdClickedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedInterstitialAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.Reward, MaxSdkBase.AdInfo> _onRewardedInterstitialAdReceivedRewardEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onRewardedInterstitialAdHiddenEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onBannerAdLoadedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo> _onBannerAdLoadFailedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onBannerAdClickedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onBannerAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onBannerAdExpandedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onBannerAdCollapsedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onMRecAdLoadedEventV2;

	private static Action<string, MaxSdkBase.ErrorInfo> _onMRecAdLoadFailedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onMRecAdClickedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onMRecAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onMRecAdExpandedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onMRecAdCollapsedEventV2;

	private static Action<string, MaxSdkBase.AdInfo> _onCrossPromoAdLoadedEvent;

	private static Action<string, MaxSdkBase.ErrorInfo> _onCrossPromoAdLoadFailedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onCrossPromoAdClickedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onCrossPromoAdRevenuePaidEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onCrossPromoAdExpandedEvent;

	private static Action<string, MaxSdkBase.AdInfo> _onCrossPromoAdCollapsedEvent;

	private static Action<string> _onBannerAdLoadedEvent;

	private static Action<string, int> _onBannerAdLoadFailedEvent;

	private static Action<string> _onBannerAdClickedEvent;

	private static Action<string> _onBannerAdExpandedEvent;

	private static Action<string> _onBannerAdCollapsedEvent;

	private static Action<string> _onMRecAdLoadedEvent;

	private static Action<string, int> _onMRecAdLoadFailedEvent;

	private static Action<string> _onMRecAdClickedEvent;

	private static Action<string> _onMRecAdExpandedEvent;

	private static Action<string> _onMRecAdCollapsedEvent;

	private static Action<string> _onInterstitialAdLoadedEvent;

	private static Action<string, int> _onInterstitialLoadFailedEvent;

	private static Action<string> _onInterstitialAdDisplayedEvent;

	private static Action<string, int> _onInterstitialAdFailedToDisplayEvent;

	private static Action<string> _onInterstitialAdClickedEvent;

	private static Action<string> _onInterstitialAdHiddenEvent;

	private static Action<string> _onRewardedAdLoadedEvent;

	private static Action<string, int> _onRewardedAdLoadFailedEvent;

	private static Action<string> _onRewardedAdDisplayedEvent;

	private static Action<string, int> _onRewardedAdFailedToDisplayEvent;

	private static Action<string> _onRewardedAdClickedEvent;

	private static Action<string, MaxSdkBase.Reward> _onRewardedAdReceivedRewardEvent;

	private static Action<string> _onRewardedAdHiddenEvent;

	public static MaxSdkCallbacks Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static event Action<MaxSdkBase.SdkConfiguration> OnSdkInitializedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnVariablesUpdatedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnSdkConsentDialogDismissedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnBannerAdLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnBannerAdLoadFailedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnBannerAdClickedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnBannerAdExpandedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnBannerAdCollapsedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnMRecAdLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnMRecAdLoadFailedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnMRecAdClickedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnMRecAdExpandedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnMRecAdCollapsedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnInterstitialLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnInterstitialLoadFailedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnInterstitialHiddenEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnInterstitialDisplayedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnInterstitialAdFailedToDisplayEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnInterstitialClickedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnRewardedAdLoadedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnRewardedAdLoadFailedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnRewardedAdDisplayedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnRewardedAdHiddenEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string> OnRewardedAdClickedEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, int> OnRewardedAdFailedToDisplayEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	[Obsolete]
	public static event Action<string, MaxSdkBase.Reward> OnRewardedAdReceivedRewardEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void ForwardEvent(string eventPropsStr)
	{
	}

	private static void InvokeEvent(Action evt)
	{
	}

	private static void InvokeEvent<T>(Action<T> evt, T param)
	{
	}

	private static void InvokeEvent<T1, T2>(Action<T1, T2> evt, T1 param1, T2 param2)
	{
	}

	private static void InvokeEvent<T1, T2, T3>(Action<T1, T2, T3> evt, T1 param1, T2 param2, T3 param3)
	{
	}

	private static bool CanInvokeEvent(Delegate evt)
	{
		return false;
	}

	private static void LogSubscribedToEvent(string eventName)
	{
	}

	private static void LogUnsubscribedToEvent(string eventName)
	{
	}
}
