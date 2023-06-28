using UnityEngine;

namespace Unity.Services.Core.Device
{
	internal static class AndroidUtils
	{
		public static AndroidJavaObject GetUnityActivity()
		{
			return null;
		}

		public static AndroidJavaObject GetSharedPreferences(AndroidJavaObject context, string name, int mode = 0)
		{
			return null;
		}

		public static AndroidJavaObject GetSharedPreferences(string name, int mode = 0)
		{
			return null;
		}

		public static string SharedPreferencesGetString(string name, string key, string defValue = "")
		{
			return null;
		}

		public static string SharedPreferencesGetString(AndroidJavaObject preferences, string key, string defValue = "")
		{
			return null;
		}

		public static void SharedPreferencesPutString(string name, string key, string value)
		{
		}

		public static void SharedPreferencesPutString(AndroidJavaObject preferences, string key, string value)
		{
		}
	}
}
