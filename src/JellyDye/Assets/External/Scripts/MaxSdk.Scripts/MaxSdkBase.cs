using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class MaxSdkBase
{
	public enum ConsentDialogState
	{
		Unknown = 0,
		Applies = 1,
		DoesNotApply = 2
	}

	public enum AdViewPosition
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		Centered = 3,
		CenterLeft = 4,
		CenterRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8
	}

	public enum BannerPosition
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		Centered = 3,
		CenterLeft = 4,
		CenterRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8
	}

	public class SdkConfiguration
	{
		public bool IsSuccessfullyInitialized;

		public ConsentDialogState ConsentDialogState;

		public string CountryCode;

		public static SdkConfiguration Create(IDictionary<string, object> eventProps)
		{
			return null;
		}
	}

	public struct Reward
	{
		public string Label;

		public int Amount;

		public override string ToString()
		{
			return null;
		}

		public bool IsValid()
		{
			return false;
		}
	}

	public enum ErrorCode
	{
		Unspecified = -1,
		NoFill = 204,
		AdLoadFailed = -5001,
		AdDisplayFailed = -4205,
		NetworkError = -1000,
		NetworkTimeout = -1001,
		NoNetwork = -1009,
		FullscreenAdAlreadyShowing = -23,
		FullscreenAdNotReady = -24,
		NoActivity = -5601,
		DontKeepActivitiesEnabled = -5602
	}

	public enum MaxAdLoadState
	{
		AdLoadNotAttempted = 0,
		AdLoaded = 1,
		FailedToLoad = 2
	}

	public class AdInfo
	{
		public string AdUnitIdentifier
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

		public string AdFormat
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

		public string NetworkName
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

		public string NetworkPlacement
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

		public string Placement
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

		public string CreativeIdentifier
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

		public double Revenue
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string RevenuePrecision
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

		public WaterfallInfo WaterfallInfo
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

		public string DspName
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

		public AdInfo(IDictionary<string, object> adInfoDictionary)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class WaterfallInfo
	{
		public string Name
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

		public string TestName
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

		public List<NetworkResponseInfo> NetworkResponses
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

		public long LatencyMillis
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public WaterfallInfo(IDictionary<string, object> waterfallInfoDict)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class NetworkResponseInfo
	{
		public MaxAdLoadState AdLoadState
		{
			[CompilerGenerated]
			get
			{
				return default(MaxAdLoadState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MediatedNetworkInfo MediatedNetwork
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

		public Dictionary<string, object> Credentials
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

		public long LatencyMillis
		{
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ErrorInfo Error
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

		public NetworkResponseInfo(IDictionary<string, object> networkResponseInfoDict)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class MediatedNetworkInfo
	{
		public string Name
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

		public string AdapterClassName
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

		public string AdapterVersion
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

		public string SdkVersion
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

		public MediatedNetworkInfo(IDictionary<string, object> mediatedNetworkDictionary)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class ErrorInfo
	{
		public ErrorCode Code
		{
			[CompilerGenerated]
			get
			{
				return default(ErrorCode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
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

		public int MediatedNetworkErrorCode
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

		public string MediatedNetworkErrorMessage
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

		public string AdLoadFailureInfo
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

		public WaterfallInfo WaterfallInfo
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

		public ErrorInfo(IDictionary<string, object> errorInfoDictionary)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	protected static readonly MaxUserSegment SharedUserSegment;

	protected static readonly MaxTargetingData SharedTargetingData;

	protected static void ValidateAdUnitIdentifier(string adUnitIdentifier, string debugPurpose)
	{
	}

	protected static void InitCallbacks()
	{
	}

	protected static string GenerateMetaData()
	{
		return null;
	}

	protected static Rect GetRectFromString(string rectPropString)
	{
		return default(Rect);
	}
}
