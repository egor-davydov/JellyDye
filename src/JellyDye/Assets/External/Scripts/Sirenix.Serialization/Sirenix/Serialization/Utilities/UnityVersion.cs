using UnityEngine;

namespace Sirenix.Serialization.Utilities
{
	internal static class UnityVersion
	{
		public static readonly int Major;

		public static readonly int Minor;

		static UnityVersion()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void EnsureLoaded()
		{
		}

		public static bool IsVersionOrGreater(int major, int minor)
		{
			return false;
		}
	}
}
