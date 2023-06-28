using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	internal struct WriteBufferHelper
	{
		private IBufferWriter<byte> bufferWriter;

		private CodedOutputStream codedOutputStream;

		public CodedOutputStream CodedOutputStream => null;

		[MethodImpl(256)]
		public static void Initialize(CodedOutputStream codedOutputStream, out WriteBufferHelper instance)
		{
			instance = default(WriteBufferHelper);
		}

		[MethodImpl(256)]
		public static void Initialize(IBufferWriter<byte> bufferWriter, out WriteBufferHelper instance, out Span<byte> buffer)
		{
			instance = default(WriteBufferHelper);
			buffer = default(Span<byte>);
		}

		[MethodImpl(256)]
		public static void CheckNoSpaceLeft(ref WriterInternalState state)
		{
		}

		[MethodImpl(256)]
		public static int GetSpaceLeft(ref WriterInternalState state)
		{
			return 0;
		}

		[MethodImpl(8)]
		public static void RefreshBuffer(ref Span<byte> buffer, ref WriterInternalState state)
		{
		}

		[MethodImpl(256)]
		public static void Flush(ref Span<byte> buffer, ref WriterInternalState state)
		{
		}
	}
}
