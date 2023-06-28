using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GGI.Ads;
using GGI.Analytics;
using GGI.Analytics.Events;
using GGI.Components;
using GGI.Data.Responses.Stepback;
using GGI.Scripts.Internal.Session;
using com.adjust.sdk;

namespace GGI.Core
{
	public class GGIAnalytics : AutoSingletonMono<GGIAnalytics>
	{
		private long _lastEngagementSentTime;

		private long _lastBackgroundTimeLostLevelEvent;

		private long _lastLevelStartTime;

		private long _sessionId;

		private readonly SessionCounter _sessionCounter;

		private readonly LowPerformanceIndicator _lowPerfTicker;

		private long _lastTimeSpentInBackground;

		public long LastAppWentIntoBackgroundTime;

		public AnalyticsGRPC AnalyticsServer;

		private FirebaseHandler _firebase;

		private bool _didInit;

		public AdjustAttribution UserAttribution
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

		public UserData UserData
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

		public bool IsLAT
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool LineItemSamplingUser
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool StepbackSamplingUser
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsFirstSession
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int SessionBannerCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int SessionInterCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SessionRewardedCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SessionMissedInterCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SessionMissedRewardedCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SessionCompletedLevelCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SessionCurrentFailedLevelCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static int[] eventDaySpan
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static int[] LevelCompleteSpan
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static int[] DailyQuestCountSpan
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static int[] RoomProgressSpan
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventManager EventManager
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

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		public void InitPushNotifications()
		{
		}

		public string GetFCMToken()
		{
			return null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void OnApplicationResign()
		{
		}

		public void ApplicationWillEnterForeground()
		{
		}

		private void HandleApplicationOnBackground(bool pause)
		{
		}

		private IEnumerator RoutineTasks()
		{
			return null;
		}

		private void GameConfigFetched()
		{
		}

		public void OnImpression(AdUnitType type)
		{
		}

		public void OnAdLoad(AdUnitType type)
		{
		}

		public void OnImpressionRequested(AdUnitType type)
		{
		}

		public void SetAdvertisingIdentifier(string id)
		{
		}

		public void SetSessionId(long session)
		{
		}

		public void IncreaseSessionNumber()
		{
		}

		public long CalculateEngagementTime(long now)
		{
			return 0L;
		}

		private void SaveUserData()
		{
		}

		public void LoadUserData()
		{
		}

		public long GetSessionId()
		{
			return 0L;
		}

		public long GetLastTimeSpentInBackground()
		{
			return 0L;
		}

		public void LogSessionDisruptEvent(float time)
		{
		}

		public void LogLowPerformanceEvent(string level, float fps, int threshold)
		{
		}

		public void LogLevelEvent(int level, LevelStatus status, Dictionary<string, object> extraParams = null)
		{
		}

		public void LogLevelEvent(string level, LevelStatus status, Dictionary<string, object> extraParams = null)
		{
		}

		public void LogLevelEvent(int progress, int level, LevelStatus status, double? timeUnused, Dictionary<string, object> extraParams = null)
		{
		}

		public void LogLevelEvent(int progress, string level, LevelStatus status, double? timeUnused, Dictionary<string, object> extraParams = null)
		{
		}

		private void IncreasePlayCount()
		{
		}

		private void IncreaseProgress()
		{
		}

		public void LogMarketEvent(string type, int id, double cost)
		{
		}

		public void LogMarketEvent(string type, string id, double cost)
		{
		}

		public void LogMarketClick()
		{
		}

		public void LogInAppPurchase(string productName, string currency, double price, bool validated)
		{
		}

		public void LogRealtimeRevenue(double revenue)
		{
		}

		public void LogMissedOpportunity(AdUnitType type)
		{
		}

		public void LogGenericEvent(string key)
		{
		}

		public void LogGenericEventWithParams(string key, Dictionary<string, object> extraParams)
		{
		}

		public void LogImpression(AdUnitType type, string networkName, string placementId, double revenue, string creativeId, string adUnitId, string adFormat, string rewardedPlace = "")
		{
		}

		public void LogAdRequest(AdUnitType type)
		{
		}

		public void LogAdStatistics(AdUnitType type, double time, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void LogLineItemEvent(StepbackFillEvent fill, bool success)
		{
		}

		public void LogAdExpiredEvent(AdExpiredEvent adExpiredEvent)
		{
		}

		public void LogCrossPromoImpression(string gameId, string gameName, string creative)
		{
		}

		public void LogCrossPromoClick(string gameId, string gameName, string creative)
		{
		}

		public void LogRateUsChoice(int session, int level, bool choice)
		{
		}

		private int GetDaysPassedSinceInstall()
		{
			return 0;
		}

		public void LogLevelEventsToAdjust(int level)
		{
		}

		public void LogInstallDateRelatedEvents(string eventPrefix, int[] progressSpan, int eventProgress)
		{
		}

		public string GetFirebaseInstanceId()
		{
			return null;
		}

		public GGIAnalytics()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
