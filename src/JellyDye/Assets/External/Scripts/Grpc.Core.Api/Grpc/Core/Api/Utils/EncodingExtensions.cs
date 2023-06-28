using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Grpc.Core.Api.Utils
{
	internal static class EncodingExtensions
	{
		public unsafe static string GetString(this Encoding encoding, byte* source, int byteCount)
		{
			return null;
		}

		[MethodImpl(256)]
		public static string GetString(this Encoding encoding, IntPtr ptr, int len)
		{
			return null;
		}
	}
}
