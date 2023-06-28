using System;
using UnityEngine;

namespace GGI.Internal.Android
{
	public class AdvertisingIdPluginCallback : AndroidJavaProxy
	{
		private Action<string> mCallback;

		public AdvertisingIdPluginCallback(Action<string> callback)
			: base((string)null)
		{
		}

		public void onResult(string adid)
		{
		}
	}
}
