using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	public class TimeCheatingDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Time Cheating Detector";

		private const string FINAL_LOG_PREFIX = "[ACTk] Time Cheating Detector: ";

		private const string TIME_SERVER = "pool.ntp.org";

		private static int instancesInScene;

		private readonly DateTime date1900;

		public int interval;

		public int threshold;

		public static TimeCheatingDetector Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static TimeCheatingDetector GetOrCreateInstance => null;

		public static void StartDetection()
		{
		}

		public static void StartDetection(UnityAction callback)
		{
		}

		public static void StartDetection(UnityAction callback, int interval)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private TimeCheatingDetector()
		{
		}

		private void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnLevelLoadedCallback()
		{
		}

		private void StartDetectionInternal(UnityAction callback, int checkInterval)
		{
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override void ResumeDetector()
		{
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}

		private void CheckForCheat()
		{
		}

		private IEnumerator CheckForCheatCoroutine()
		{
			return null;
		}

		public static double GetOnlineTime(string server)
		{
			return 0.0;
		}

		private double GetLocalTime()
		{
			return 0.0;
		}
	}
}
