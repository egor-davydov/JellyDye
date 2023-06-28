using System;
using System.Runtime.CompilerServices;

namespace Grpc.Core.Internal
{
	internal static class WellKnownStrings
	{
		[MethodImpl(256)]
		private unsafe static ulong Coerce64(byte* value)
		{
			return 0uL;
		}

		[MethodImpl(256)]
		private unsafe static ushort Coerce16(byte* value)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static string TryIdentify(IntPtr source, int length)
		{
			return null;
		}

		public unsafe static string TryIdentify(byte* source, int length)
		{
			return null;
		}
	}
}
