using System.Globalization;

namespace Lofelt.NiceVibrations
{
	public static class HapticPatterns
	{
		public enum PresetType
		{
			Selection = 0,
			Success = 1,
			Warning = 2,
			Failure = 3,
			LightImpact = 4,
			MediumImpact = 5,
			HeavyImpact = 6,
			RigidImpact = 7,
			SoftImpact = 8,
			None = -1
		}

		private struct Pattern
		{
			public float[] time;

			public float[] amplitude;

			private static string clipJsonTemplate;

			static Pattern()
			{
			}

			public Pattern(float[] time, float[] amplitude)
			{
			}

			public GamepadRumble ToRumble()
			{
				return default(GamepadRumble);
			}

			public string ToClip()
			{
				return null;
			}
		}

		private struct Preset
		{
			public PresetType type;

			public float[] maximumAmplitudePattern;

			public byte[] jsonClip;

			public Preset(PresetType type, float[] time, float[] amplitude)
			{
			}

			public float GetDuration()
			{
				return 0f;
			}
		}

		private static string emphasisTemplate;

		private static string constantTemplate;

		private static NumberFormatInfo numberFormat;

		private static float[] constantPatternTime;

		private static Preset Selection;

		private static Preset Light;

		private static Preset Medium;

		private static Preset Heavy;

		private static Preset Rigid;

		private static Preset Soft;

		private static Preset Success;

		private static Preset Failure;

		private static Preset Warning;

		static HapticPatterns()
		{
		}

		public static void PlayEmphasis(float amplitude, float frequency)
		{
		}

		private static PresetType presetTypeForEmphasis(float amplitude)
		{
			return default(PresetType);
		}

		public static void PlayConstant(float amplitude, float frequency, float duration)
		{
		}

		private static Preset GetPresetForType(PresetType type)
		{
			return default(Preset);
		}

		public static void PlayPreset(PresetType presetType)
		{
		}

		public static float GetPresetDuration(PresetType presetType)
		{
			return 0f;
		}
	}
}
