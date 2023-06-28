using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public static class LofeltHaptics
	{
		private static AndroidJavaObject lofeltHaptics;

		private static AndroidJavaObject hapticPatterns;

		private static long nativeController;

		private static IntPtr playMethodId;

		private static IntPtr stopMethodId;

		private static IntPtr seekMethodId;

		private static IntPtr loopMethodId;

		private static IntPtr setAmplitudeMultiplicationMethodId;

		private static IntPtr playMaximumAmplitudePattern;

		[PreserveSig]
		private static extern bool lofeltHapticsLoadDirect(IntPtr controller, [In] byte[] bytes, long size);

		public static void Initialize()
		{
		}

		public static void Release()
		{
		}

		public static bool DeviceMeetsMinimumPlatformRequirements()
		{
			return false;
		}

		public static void Load(byte[] data)
		{
		}

		public static float GetClipDuration()
		{
			return 0f;
		}

		public static void Play()
		{
		}

		public static void PlayMaximumAmplitudePattern(float[] timings)
		{
		}

		public static void Stop()
		{
		}

		public static void StopPattern()
		{
		}

		public static void Seek(float time)
		{
		}

		public static void SetAmplitudeMultiplication(float factor)
		{
		}

		public static void SetFrequencyShift(float shift)
		{
		}

		public static void Loop(bool enabled)
		{
		}

		public static void TriggerPresetHaptics(int type)
		{
		}
	}
}
