using GGI.Components;
using GGI.Data.Adjust;
using UnityEngine;

namespace GGI.Data
{
	[CreateAssetMenu]
	public class Settings : ScriptableObject
	{
		public string AdjustAndroidAppToken;

		public string AdjustiOSAppToken;

		public string GJGGameId;

		public string GameName;

		public bool UsePushNotifications;

		public bool UseCrossPromotion;

		public LogLevel LogLevel;

		public string AndroidBannerAdUnitId;

		public string AndroidInterstitialAdUnitId;

		public string AndroidRewardedVideoAdUnitId;

		public string AndroidAOAdUnitId;

		public string iOSBannerAdUnitId;

		public string iOSInterstitialAdUnitId;

		public string iOSRewardedVideoAdUnitId;

		public string iOSAOAdUnitId;

		public string AmazoniOSBannerSlotId;

		public string AmazoniOSInterstitialSlotId;

		public string AmazoniOSRewardedSlotId;

		public string AmazonAndroidBannerSlotId;

		public string AmazonAndroidInterstitialSlotId;

		public string AmazonAndroidRewardedSlotId;

		public string AmazonAndroidAppId;

		public string AmazoniOSAppId;

		public string FinguGameID;

		public string KeystoreName;

		public string KeystorePass;

		public string KeyaliasName;

		public string KeyaliasPass;

		public AdjustEnvironment AdjustEnvironment;

		private static Settings _instance;

		public static Settings Instance => null;

		public static Settings NullableInstance => null;
	}
}
