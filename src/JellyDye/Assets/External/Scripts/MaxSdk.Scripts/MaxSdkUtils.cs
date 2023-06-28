using System.Collections.Generic;
using UnityEngine;

public class MaxSdkUtils
{
	public enum VersionComparisonResult
	{
		Lesser = -1,
		Equal = 0,
		Greater = 1
	}

	private static readonly AndroidJavaClass MaxUnityPluginClass;

	public static float GetAdaptiveBannerHeight(float width = -1f)
	{
		return 0f;
	}

	public static Dictionary<string, object> GetDictionaryFromDictionary(IDictionary<string, object> dictionary, string key, Dictionary<string, object> defaultValue = null)
	{
		return null;
	}

	public static List<object> GetListFromDictionary(IDictionary<string, object> dictionary, string key, List<object> defaultValue = null)
	{
		return null;
	}

	public static string GetStringFromDictionary(IDictionary<string, object> dictionary, string key, string defaultValue = "")
	{
		return null;
	}

	public static bool GetBoolFromDictionary(IDictionary<string, object> dictionary, string key, bool defaultValue = false)
	{
		return false;
	}

	public static int GetIntFromDictionary(IDictionary<string, object> dictionary, string key, int defaultValue = 0)
	{
		return 0;
	}

	public static long GetLongFromDictionary(IDictionary<string, object> dictionary, string key, long defaultValue = 0L)
	{
		return 0L;
	}

	public static float GetFloatFromDictionary(IDictionary<string, object> dictionary, string key, float defaultValue = 0f)
	{
		return 0f;
	}

	public static double GetDoubleFromDictionary(IDictionary<string, object> dictionary, string key, int defaultValue = 0)
	{
		return 0.0;
	}

	public static string InvariantCultureToString(object obj)
	{
		return null;
	}

	public static List<T> PropsStringsToList<T>(string str)
	{
		return null;
	}

	public static string ParseColor(Color color)
	{
		return null;
	}

	public static bool IsTablet()
	{
		return false;
	}

	public static bool IsPhysicalDevice()
	{
		return false;
	}

	public static float GetScreenDensity()
	{
		return 0f;
	}

	public static VersionComparisonResult CompareUnityMediationVersions(string versionA, string versionB)
	{
		return default(VersionComparisonResult);
	}

	public static VersionComparisonResult CompareVersions(string versionA, string versionB)
	{
		return default(VersionComparisonResult);
	}
}
