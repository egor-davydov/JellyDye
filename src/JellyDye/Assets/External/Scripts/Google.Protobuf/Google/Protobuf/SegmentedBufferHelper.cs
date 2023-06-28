using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	internal struct SegmentedBufferHelper
	{
		private int? totalLength;

		private ReadOnlySequence<byte>.Enumerator readOnlySequenceEnumerator;

		private CodedInputStream codedInputStream;

		public int? TotalLength => null;

		public CodedInputStream CodedInputStream => null;

		[MethodImpl(256)]
		public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance)
		{
			instance = default(SegmentedBufferHelper);
		}

		[MethodImpl(256)]
		public static void Initialize(ReadOnlySequence<byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<byte> firstSpan)
		{
			instance = default(SegmentedBufferHelper);
			firstSpan = default(ReadOnlySpan<byte>);
		}

		public bool RefillBuffer(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed)
		{
			return false;
		}

		public static int PushLimit(ref ParserInternalState state, int byteLimit)
		{
			return 0;
		}

		public static void PopLimit(ref ParserInternalState state, int oldLimit)
		{
		}

		public static bool IsReachedLimit(ref ParserInternalState state)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsAtEnd(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state)
		{
			return false;
		}

		private bool RefillFromReadOnlySequence(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed)
		{
			return false;
		}

		private bool RefillFromCodedInputStream(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed)
		{
			return false;
		}

		private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state)
		{
		}

		private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state)
		{
		}
	}
}
