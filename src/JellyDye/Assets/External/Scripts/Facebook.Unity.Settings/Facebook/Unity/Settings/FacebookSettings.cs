using System;
using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity.Settings
{
	public class FacebookSettings : ScriptableObject
	{
		public enum BuildTarget
		{
			StandaloneOSX = 0,
			StandaloneWindows = 1,
			iOS = 2,
			Android = 3,
			StandaloneWindows64 = 4,
			WebGL = 5,
			WSAPlayer = 6,
			StandaloneLinux64 = 7,
			PS4 = 8,
			XboxOne = 9,
			tvOS = 10,
			Switch = 11,
			Stadia = 12,
			CloudRendering = 13,
			PS5 = 14,
			none = 15
		}

		public delegate void OnChangeCallback();

		[Serializable]
		public class UrlSchemes
		{
			[SerializeField]
			private List<string> list;

			public List<string> Schemes
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public UrlSchemes(List<string> schemes = null)
			{
			}
		}

		public const string FacebookSettingsAssetName = "FacebookSettings";

		public const string FacebookSettingsPath = "FacebookSDK/SDK/Resources";

		public const string FacebookSettingsAssetExtension = ".asset";

		private static List<OnChangeCallback> onChangeCallbacks;

		private static FacebookSettings instance;

		[SerializeField]
		private int selectedAppIndex;

		[SerializeField]
		private List<string> clientTokens;

		[SerializeField]
		private List<string> appIds;

		[SerializeField]
		private List<string> appLabels;

		[SerializeField]
		private bool cookie;

		[SerializeField]
		private bool logging;

		[SerializeField]
		private bool status;

		[SerializeField]
		private bool xfbml;

		[SerializeField]
		private bool frictionlessRequests;

		[SerializeField]
		private string androidKeystorePath;

		[SerializeField]
		private string iosURLSuffix;

		[SerializeField]
		private List<UrlSchemes> appLinkSchemes;

		[SerializeField]
		private string uploadAccessToken;

		[SerializeField]
		private bool autoLogAppEventsEnabled;

		[SerializeField]
		private bool advertiserIDCollectionEnabled;

		private BuildTarget editorBuildTargetName;

		public static BuildTarget EditorBuildTarget
		{
			get
			{
				return default(BuildTarget);
			}
			set
			{
			}
		}

		public static int SelectedAppIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static List<string> AppIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<string> AppLabels
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<string> ClientTokens
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AppId => null;

		public static string ClientToken => null;

		public static bool IsValidAppId => false;

		public static bool Cookie
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Logging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Status
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool Xfbml
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string AndroidKeystorePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string IosURLSuffix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string ChannelUrl => null;

		public static bool FrictionlessRequests
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<UrlSchemes> AppLinkSchemes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string UploadAccessToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool AutoLogAppEventsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool AdvertiserIDCollectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static FacebookSettings Instance => null;

		public static FacebookSettings NullableInstance => null;

		public static void RegisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		public static void UnregisterChangeEventCallback(OnChangeCallback callback)
		{
		}

		private static void SettingsChanged()
		{
		}
	}
}
