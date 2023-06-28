using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Core
{
	internal static class UnityThreadUtils
	{
		private static int s_UnityThreadId;

		internal static TaskScheduler UnityThreadScheduler;

		public static bool IsRunningOnUnityThread => false;

		[RuntimeInitializeOnLoadMethod]
		private static void CaptureUnityThreadInfo()
		{
		}
	}
}
