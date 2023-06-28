using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[Obsolete]
	public ref struct WriteContext
	{
		internal Span<byte> buffer;

		internal WriterInternalState state;

		[MethodImpl(256)]
		internal static void Initialize(ref Span<byte> buffer, ref WriterInternalState state, out WriteContext ctx)
		{
			ctx = default(WriteContext);
		}

		[MethodImpl(256)]
		internal static void Initialize(CodedOutputStream output, out WriteContext ctx)
		{
			ctx = default(WriteContext);
		}

		[MethodImpl(256)]
		internal static void Initialize(IBufferWriter<byte> output, out WriteContext ctx)
		{
			ctx = default(WriteContext);
		}

		public void WriteDouble(double value)
		{
		}

		public void WriteFloat(float value)
		{
		}

		public void WriteUInt64(ulong value)
		{
		}

		public void WriteInt64(long value)
		{
		}

		public void WriteInt32(int value)
		{
		}

		public void WriteFixed64(ulong value)
		{
		}

		public void WriteFixed32(uint value)
		{
		}

		public void WriteBool(bool value)
		{
		}

		public void WriteString(string value)
		{
		}

		public void WriteMessage(IMessage value)
		{
		}

		public void WriteBytes(ByteString value)
		{
		}

		public void WriteEnum(int value)
		{
		}

		public void WriteLength(int length)
		{
		}

		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
		}

		public void WriteTag(uint tag)
		{
		}

		public void WriteRawTag(byte b1)
		{
		}

		public void WriteRawTag(byte b1, byte b2)
		{
		}

		internal void Flush()
		{
		}

		internal void CopyStateTo(CodedOutputStream output)
		{
		}

		internal void LoadStateFrom(CodedOutputStream output)
		{
		}
	}
}
