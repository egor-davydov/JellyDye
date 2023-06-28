using System;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	[Serializable]
	public struct GamepadRumble
	{
		[SerializeField]
		public int[] durationsMs;

		[SerializeField]
		public int totalDurationMs;

		[SerializeField]
		public float[] lowFrequencyMotorSpeeds;

		[SerializeField]
		public float[] highFrequencyMotorSpeeds;

		public bool IsValid()
		{
			return false;
		}
	}
}
