using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gjg.Io.Scio.Client.Event;
using Gjg.Io.Scio.Core.Event;
using Grpc.Core;
using UnityEngine;

public class EventManager : MonoBehaviour
{
	private class AdManager
	{
		private class Ad
		{
			public MaxSdkBase.AdInfo AdInfo
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

			public long CreatedAt
			{
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private long day;

		public int _total_revenue;

		public int _total_ads_shown;

		public int _total_ads_clicked;

		private List<Ad> _ads;

		public long GetDayMiliseconds(long d)
		{
			return 0L;
		}

		public void Add(MaxSdkBase.AdInfo adInfo)
		{
		}

		public double GetRevenueLastXDays(long day)
		{
			return 0.0;
		}
	}

	private class IapManager
	{
		public int _total_iap;
	}

	private class Metadata
	{
		public int Progress;

		public int CurrentLevelId;

		public AdManager AdManager;

		public IapManager IapManager;

		public int LevelsFailed;

		public int LevelsCompleted;

		public bool LastLevelStatus;
	}

	private Channel _channel;

	private ClientSegmentService.ClientSegmentServiceClient _client;

	private string _hostUrl;

	private string _appBundleId;

	private Platform _platform;

	private bool isPrefsInitialized;

	private Metadata _eventManagerMetadata;

	private List<Segment> _currentSegments;

	private List<ClientEvent> _eventBuffer;

	private Identifier _identifier;

	private void HydratePlayerPrefs()
	{
	}

	private int GetDaysPassedSinceInstall()
	{
		return 0;
	}

	private void SetEventSent(string id)
	{
	}

	private bool EventSent(string id)
	{
		return false;
	}

	private void GatherIdentifiers()
	{
	}

	public void Init(List<Segment> segments)
	{
	}

	public TriggerRequest SetupTriggerRequest(string segmentId)
	{
		return null;
	}

	private void HydrateEventBuffer(ref TriggerRequest t)
	{
	}

	private static long GetCurrentTimeUnix()
	{
		return 0L;
	}

	private static ClientEvent ProcessLevelEvent(string id, int level, Condition condition, bool isCallback)
	{
		return null;
	}

	private ClientEvent ProcessRevenueEvent(string id, EventInfo ef, EventConfig eventConfig, bool isCallback)
	{
		return null;
	}

	private void ConnectToScio()
	{
	}

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void AdPaidEvent(string _, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnLevelFinished(int progress, int level, bool isSuccessful)
	{
	}

	public void HydrateSegments()
	{
	}

	private static double ParseFloat(string s)
	{
		return 0.0;
	}

	private static int ParseInt(string s)
	{
		return 0;
	}

	private List<Segment> GroupSegmentsByEventType(Gjg.Io.Scio.Core.Event.EventType eventType)
	{
		return null;
	}

	public void TryProcessEvent(EventInfo eventInfo, Gjg.Io.Scio.Core.Event.EventType eventType, bool isCallback)
	{
	}

	private IEnumerator TriggerRoutine(TriggerRequest triggerRequest)
	{
		return null;
	}
}
