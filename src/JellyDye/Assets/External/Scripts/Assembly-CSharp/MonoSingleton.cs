using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _sInstance;

	public static T Instance => null;

	public static void Initialize()
	{
	}
}
