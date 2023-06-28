using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Google.Protobuf
{
	internal static class WritingPrimitives
	{
		internal static readonly Encoding Utf8Encoding;

		public static void WriteDouble(ref Span<byte> buffer, ref WriterInternalState state, double value)
		{
		}

		public static void WriteFloat(ref Span<byte> buffer, ref WriterInternalState state, float value)
		{
		}

		[MethodImpl(8)]
		private static void WriteFloatSlowPath(ref Span<byte> buffer, ref WriterInternalState state, float value)
		{
		}

		public static void WriteUInt64(ref Span<byte> buffer, ref WriterInternalState state, ulong value)
		{
		}

		public static void WriteInt64(ref Span<byte> buffer, ref WriterInternalState state, long value)
		{
		}

		public static void WriteInt32(ref Span<byte> buffer, ref WriterInternalState state, int value)
		{
		}

		public static void WriteFixed64(ref Span<byte> buffer, ref WriterInternalState state, ulong value)
		{
		}

		public static void WriteFixed32(ref Span<byte> buffer, ref WriterInternalState state, uint value)
		{
		}

		public static void WriteBool(ref Span<byte> buffer, ref WriterInternalState state, bool value)
		{
		}

		public static void WriteString(ref Span<byte> buffer, ref WriterInternalState state, string value)
		{
		}

		private static int WriteStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value)
		{
			return 0;
		}

		public static void WriteBytes(ref Span<byte> buffer, ref WriterInternalState state, ByteString value)
		{
		}

		public static void WriteEnum(ref Span<byte> buffer, ref WriterInternalState state, int value)
		{
		}

		public static void WriteLength(ref Span<byte> buffer, ref WriterInternalState state, int length)
		{
		}

		public static void WriteRawVarint32(ref Span<byte> buffer, ref WriterInternalState state, uint value)
		{
		}

		public static void WriteRawVarint64(ref Span<byte> buffer, ref WriterInternalState state, ulong value)
		{
		}

		public static void WriteRawLittleEndian32(ref Span<byte> buffer, ref WriterInternalState state, uint value)
		{
		}

		[MethodImpl(8)]
		private static void WriteRawLittleEndian32SlowPath(ref Span<byte> buffer, ref WriterInternalState state, uint value)
		{
		}

		public static void WriteRawLittleEndian64(ref Span<byte> buffer, ref WriterInternalState state, ulong value)
		{
		}

		[MethodImpl(8)]
		public static void WriteRawLittleEndian64SlowPath(ref Span<byte> buffer, ref WriterInternalState state, ulong value)
		{
		}

		private static void WriteRawByte(ref Span<byte> buffer, ref WriterInternalState state, byte value)
		{
		}

		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value)
		{
		}

		public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, ReadOnlySpan<byte> value)
		{
		}

		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, int fieldNumber, WireFormat.WireType type)
		{
		}

		public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, uint tag)
		{
		}

		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1)
		{
		}

		public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2)
		{
		}

		[MethodImpl(8)]
		private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2)
		{
		}
	}
}
