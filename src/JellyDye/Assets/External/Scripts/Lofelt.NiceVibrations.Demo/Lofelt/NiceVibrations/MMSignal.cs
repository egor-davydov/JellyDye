using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class MMSignal : MonoBehaviour
	{
		public enum SignalType
		{
			DigitalNoise = 0,
			Pulse = 1,
			Sawtooth = 2,
			Sine = 3,
			Square = 4,
			Triangle = 5,
			WhiteNoise = 6
		}

		public static float GetValue(float time, SignalType signalType, float phase, float amplitude, float frequency, float offset, bool Invert = false)
		{
			return 0f;
		}
	}
}
