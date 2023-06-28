using UnityEngine;

public class MaxVariableServiceAndroid
{
	private static readonly AndroidJavaClass _maxUnityPluginClass;

	private static readonly MaxVariableServiceAndroid _instance;

	public static MaxVariableServiceAndroid Instance => null;

	public void LoadVariables()
	{
	}

	public bool GetBoolean(string key, bool defaultValue = false)
	{
		return false;
	}

	public string GetString(string key, string defaultValue = "")
	{
		return null;
	}
}
