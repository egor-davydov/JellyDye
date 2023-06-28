using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorRoll3D
{
	public static class VibrationController
	{
		private const string EnabledKey = "ColorRoll-VibrationEnabledKey";

		private static readonly Dictionary<int, Coroutine> ActiveVibrations;

		public static bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void RollVibrate(int id, float intensity = 0.17f, float sharpness = 0.26f, float duration = 1f)
		{
		}

		public static void UnrollVibrate(int id, float intensity = 0.33f, float sharpness = 0.25f, float duration = -0.05f)
		{
		}

		public static void Vibrate(int id, float intensity = 0.24f, float sharpness = 0.26f, float duration = 0.6f)
		{
		}

		private static void StopVibration(int id)
		{
		}

		private static IEnumerator VibrationImpl(int id, float intensity, float sharpness, float duration)
		{
			return null;
		}

		public static void BulbVibrate()
		{
		}
	}
}
