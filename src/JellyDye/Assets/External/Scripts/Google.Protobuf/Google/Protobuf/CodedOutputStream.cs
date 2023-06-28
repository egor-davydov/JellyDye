using System;
using System.IO;

namespace Google.Protobuf
{
	public sealed class CodedOutputStream : IDisposable
	{
		public sealed class OutOfSpaceException : IOException
		{
			internal OutOfSpaceException()
			{
			}
		}

		public static readonly int DefaultBufferSize;

		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private WriterInternalState state;

		private readonly Stream output;

		internal byte[] InternalBuffer => null;

		internal Stream InternalOutputStream => null;

		internal unsafe ref WriterInternalState InternalState => ref *(WriterInternalState*)null;

		public static int ComputeUInt64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeInt64Size(long value)
		{
			return 0;
		}

		public static int ComputeInt32Size(int value)
		{
			return 0;
		}

		public static int ComputeFixed64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeFixed32Size(uint value)
		{
			return 0;
		}

		public static int ComputeStringSize(string value)
		{
			return 0;
		}

		public static int ComputeMessageSize(IMessage value)
		{
			return 0;
		}

		public static int ComputeBytesSize(ByteString value)
		{
			return 0;
		}

		public static int ComputeEnumSize(int value)
		{
			return 0;
		}

		public static int ComputeLengthSize(int length)
		{
			return 0;
		}

		public static int ComputeRawVarint32Size(uint value)
		{
			return 0;
		}

		public static int ComputeRawVarint64Size(ulong value)
		{
			return 0;
		}

		public static int ComputeTagSize(int fieldNumber)
		{
			return 0;
		}

		public CodedOutputStream(byte[] flatArray)
		{
		}

		private CodedOutputStream(byte[] buffer, int offset, int length)
		{
		}

		public void WriteUInt64(ulong value)
		{
		}

		public void WriteInt64(long value)
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

		public void WriteRawMessage(IMessage value)
		{
		}

		public void WriteRawTag(byte b1)
		{
		}

		public void Dispose()
		{
		}

		public void Flush()
		{
		}

		public void CheckNoSpaceLeft()
		{
		}
	}
}
