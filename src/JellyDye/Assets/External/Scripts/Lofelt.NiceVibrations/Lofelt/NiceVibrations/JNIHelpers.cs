using System;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	internal static class JNIHelpers
	{
		private static jvalue[] jniArgs;

		private static string javaThrowableToString(IntPtr throwable)
		{
			return null;
		}

		public static void Call(AndroidJavaObject obj, IntPtr methodId, jvalue[] jniArgs)
		{
		}

		public static void Call(AndroidJavaObject obj, IntPtr methodId)
		{
		}

		public static void Call(AndroidJavaObject obj, IntPtr methodId, float arg)
		{
		}

		public static void Call(AndroidJavaObject obj, IntPtr methodId, bool arg)
		{
		}

		public static void Call(AndroidJavaObject obj, IntPtr methodId, float[] arg)
		{
		}

		public static ReturnType Call<ReturnType>(AndroidJavaObject obj, string methodName)
		{
			return default(ReturnType);
		}
	}
}
