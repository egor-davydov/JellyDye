using System.Runtime.CompilerServices;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public static class DeviceCapabilities
	{
		private static bool _meetsAdvancedRequirements;

		private static bool _hasAmplitudeControl;

		private static bool _hasFrequencyControl;

		private static bool _hasAmplitudeModulation;

		private static bool _hasFrequencyModulation;

		private static bool _hasEmphasis;

		private static bool _canEmulateEmphasis;

		private static bool _canLoop;

		public static RuntimePlatform platform
		{
			[CompilerGenerated]
			get
			{
				return default(RuntimePlatform);
			}
		}

		public static int platformVersion
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public static bool meetsAdvancedRequirements => false;

		public static bool isVersionSupported
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public static bool hasAmplitudeControl => false;

		public static bool hasFrequencyControl => false;

		public static bool hasAmplitudeModulation => false;

		public static bool hasFrequencyModulation => false;

		public static bool hasEmphasis => false;

		public static bool canEmulateEmphasis => false;

		public static bool canLoop => false;

		static DeviceCapabilities()
		{
		}

		public static void Init()
		{
		}
	}
}
