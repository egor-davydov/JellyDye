using System;
using System.Timers;

namespace Lofelt.NiceVibrations
{
	public static class HapticController
	{
		private static bool lofeltHapticsInitalized;

		private static Timer playbackFinishedTimer;

		private static float clipLoadedDurationSecs;

		private static bool clipLoaded;

		private static float lastSeekTime;

		private static bool deviceMeetsAdvancedRequirements;

		private static bool isLoopingEnabledByUser;

		private static bool isPlaybackLooping;

		private static HapticPatterns.PresetType _fallbackPreset;

		internal static bool _hapticsEnabled;

		internal static float _outputLevel;

		internal static float _clipLevel;

		public static Action LoadedClipChanged;

		public static Action PlaybackStarted;

		public static Action PlaybackStopped;

		public static HapticPatterns.PresetType fallbackPreset
		{
			get
			{
				return default(HapticPatterns.PresetType);
			}
			set
			{
			}
		}

		public static bool hapticsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static float outputLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float clipLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static float clipFrequencyShift
		{
			set
			{
			}
		}

		public static bool Init()
		{
			return false;
		}

		public static void Load(byte[] data)
		{
		}

		public static void Load(HapticClip clip)
		{
		}

		public static void Load(byte[] json, GamepadRumble rumble)
		{
		}

		private static void HandleFinishedPlayback()
		{
		}

		public static void Play()
		{
		}

		public static void Play(HapticClip clip)
		{
		}

		public static void Stop()
		{
		}

		public static void Seek(float time)
		{
		}

		public static void Loop(bool enabled)
		{
		}

		public static bool IsPlaying()
		{
			return false;
		}

		public static void Reset()
		{
		}

		public static void ProcessApplicationFocus(bool hasFocus)
		{
		}
	}
}
