using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using GGI.Components;
using GGI.Data.Responses.Stepback;
using Gjg.Io.GameConfig.Proto.Config.V3.Resources;
using Gjg.Io.GameConfig.Proto.Config.V6.Resources;
using Gjg.Io.GameConfig.Proto.PostInit.V2.Services;
using Polly.CircuitBreaker;

namespace GGI.Internal.GameConfig
{
	public class GGIGameConfig : AutoSingleton<GGIGameConfig>
	{
		public class GlobalConfigKeys
		{
			public static string EnableSrDebugger
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string FirstInterstitialDelaySeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string InterstitialIntervalSeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedGraceSeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string StepbackConfigId
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ForceLogLevel
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LogLevel
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string UseCrossPromotion
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LTVConversionType
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LTVTrigger
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LTVTriggerDelay
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LTVPredictionFirstNSeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string EnableLTVPrediction
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LineItemSamplingPercentage
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string StepbackSamplingResetInSessions
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalConfigId
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalDaysConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalSessionsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalAdsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalSessionAdsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LoseInterConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedInterConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedLoseConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsTitleText
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsText
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsType
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsShowLevel
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsShowSession
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigWhere
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigID
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigIDExisting
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string FirebaseRemoteConfigCheck
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LowFPSThreshold
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ShowATT
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ATTiOSVersionCondition
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string EnableCVT
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DisableATTGDPRMechanism
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string UseRealtimeAdImpression
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ClientSideRevenueTracking
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ShowInterOnTheme
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerVersion
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerLogsEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		public class FirebaseRemoteConfigGlobalConfigKeys
		{
			public static string StepbackConfigId
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string FirstInterstitialDelaySeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string InterstitialIntervalSeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedGraceSeconds
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalConfigId
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalDaysConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalSessionsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalAdsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string AdIntervalSessionAdsConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string LoseInterConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedInterConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RewardedLoseConfig
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsTitleText
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsText
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsType
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsShowLevel
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string RateUsShowSession
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigWhere
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigID
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string OptinConfigIDExisting
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string FirebaseRemoteConfigCheck
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ShowATT
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ATTiOSVersionCondition
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string EnableCVT
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DisableATTGDPRMechanism
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string UseRealtimeAdImpression
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ClientSideRevenueTracking
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string ShowInterOnTheme
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerVersion
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerLogsEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerBannerStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerRewardedStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialEnabled
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStartMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialFirstSessionMode
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialResetStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public static string DiggerInterstitialStartStep
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		public Action GameConfigFetched;

		private Dictionary<string, string> _defaults;

		private Dictionary<string, string> _remoteData;

		public StepbackConfig CachedStepbackConfig;

		public List<Threshold> CachedTengryThresholds;

		public Optin CachedOptinConfig;

		public ConsentResponse CachedGDPRConsentResponse;

		private GameConfigGRPCClient _grpcClient;

		public bool GameConfigInitialized;

		private AsyncCircuitBreakerPolicy _circuitBreaker;

		private CancellationTokenSource _cancellation;

		public void Fetch()
		{
		}

		public void FindMe()
		{
		}

		public void ConvertCurrency(string currency, double rev, Action<double> response)
		{
		}

		public void GetAndSetConversionValue()
		{
		}

		public void PostInit()
		{
		}

		private void PostInitWithRetry(PostInitRequest request)
		{
		}

		public void GDPRSetConsent(bool consent)
		{
		}

		public void Init()
		{
		}

		public UniTaskVoid OnApplicationQuit()
		{
			return default(UniTaskVoid);
		}

		public string GetStringValue(string key)
		{
			return null;
		}

		public int GetIntValue(string key)
		{
			return 0;
		}

		public bool GetBoolValue(string key)
		{
			return false;
		}

		public double GetDoubleValue(string key)
		{
			return 0.0;
		}

		public float GetFloatValue(string key)
		{
			return 0f;
		}

		public T GetJsonObject<T>(string key)
		{
			return default(T);
		}

		private string GetValue(string key)
		{
			return null;
		}

		public int GetIntValueWithOverride(string ggiKey, string firebaseKey)
		{
			return 0;
		}

		public string GetStringValueWithOverride(string ggiKey, string firebaseKey)
		{
			return null;
		}

		private bool HasOverride(string key)
		{
			return false;
		}

		private void AddDefaults()
		{
		}

		private void OnGetGameConfigSuccess(Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config response)
		{
		}

		private void OnGetGameConfigError()
		{
		}

		private bool HasStepbackRemoteConfigOverride()
		{
			return false;
		}

		public StepbackConfig GetDefaultStepbackConfig()
		{
			return null;
		}

		public Dictionary<string, string> GetRemoteData()
		{
			return null;
		}

		public GGIGameConfig()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
