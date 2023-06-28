namespace Sirenix.Serialization
{
	public static class ArchitectureInfo
	{
		public static readonly bool Architecture_Supports_Unaligned_Float32_Reads;

		public static bool Architecture_Supports_All_Unaligned_ReadWrites;

		static ArchitectureInfo()
		{
		}

		internal static void SetIsOnAndroid(string architecture)
		{
		}

		internal static void SetIsNotOnAndroid()
		{
		}
	}
}
