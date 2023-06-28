using Facebook.Unity.Mobile.Android;
using UnityEngine;

namespace Facebook.Unity.Android
{
	internal class AndroidWrapper : Facebook.Unity.Mobile.Android.IAndroidWrapper
	{
		private const string FacebookJavaClassName = "com.facebook.unity.FB";

		private AndroidJavaClass facebookJavaClass;

		public T CallStatic<T>(string methodName)
		{
			return default(T);
		}

		public void CallStatic(string methodName, params object[] args)
		{
		}
	}
}
