namespace Sirenix.Serialization.Utilities.Unsafe
{
	internal static class UnsafeUtilities
	{
		private struct Struct256Bit
		{
			public decimal d1;

			public decimal d2;
		}

		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength) where T : struct
		{
			return null;
		}

		public static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset) where T : struct
		{
			return null;
		}

		public static byte[] StructArrayToBytes<T>(T[] array) where T : struct
		{
			return null;
		}

		public static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset) where T : struct
		{
			return null;
		}

		public static string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport)
		{
			return null;
		}

		public static int StringToBytes(byte[] buffer, string value, bool needs16BitSupport)
		{
			return 0;
		}

		public unsafe static void MemoryCopy(void* from, void* to, int bytes)
		{
		}

		public static void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset)
		{
		}
	}
}
