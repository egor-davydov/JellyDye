using System;
using UnityEngine;

namespace AmazonAds
{
	public class AdError
	{
		private int errorCode;

		private string errorMessage;

		private AdRequest adLoader;

		private AndroidJavaObject adError;

		private IntPtr adErrorPtr;

		public AdError(int code, string message)
		{
		}

		public int GetCode()
		{
			return 0;
		}

		public string GetMessage()
		{
			return null;
		}

		public AdRequest GetAdLoader()
		{
			return null;
		}

		public AndroidJavaObject GetAdError()
		{
			return null;
		}

		public IntPtr GetInstance()
		{
			return (IntPtr)0;
		}

		internal void SetAdLoader(AdRequest adRequest)
		{
		}

		internal void SetAdError(AndroidJavaObject error)
		{
		}

		internal void SetInstance(IntPtr inPtr)
		{
		}
	}
}
