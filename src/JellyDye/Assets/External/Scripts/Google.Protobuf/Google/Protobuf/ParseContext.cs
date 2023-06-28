using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	[Obsolete]
	public ref struct ParseContext
	{
		internal ReadOnlySpan<byte> buffer;

		internal ParserInternalState state;

		internal uint LastTag => 0u;

		internal bool DiscardUnknownFields
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ExtensionRegistry ExtensionRegistry
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[MethodImpl(256)]
		internal static void Initialize(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, out ParseContext ctx)
		{
			ctx = default(ParseContext);
		}

		[MethodImpl(256)]
		internal static void Initialize(CodedInputStream input, out ParseContext ctx)
		{
			ctx = default(ParseContext);
		}

		[MethodImpl(256)]
		internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx)
		{
			ctx = default(ParseContext);
		}

		[MethodImpl(256)]
		internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx)
		{
			ctx = default(ParseContext);
		}

		[MethodImpl(256)]
		public uint ReadTag()
		{
			return 0u;
		}

		[MethodImpl(256)]
		public double ReadDouble()
		{
			return 0.0;
		}

		[MethodImpl(256)]
		public float ReadFloat()
		{
			return 0f;
		}

		[MethodImpl(256)]
		public ulong ReadUInt64()
		{
			return 0uL;
		}

		[MethodImpl(256)]
		public long ReadInt64()
		{
			return 0L;
		}

		[MethodImpl(256)]
		public int ReadInt32()
		{
			return 0;
		}

		[MethodImpl(256)]
		public ulong ReadFixed64()
		{
			return 0uL;
		}

		[MethodImpl(256)]
		public uint ReadFixed32()
		{
			return 0u;
		}

		[MethodImpl(256)]
		public bool ReadBool()
		{
			return false;
		}

		[MethodImpl(256)]
		public string ReadString()
		{
			return null;
		}

		[MethodImpl(256)]
		public void ReadMessage(IMessage message)
		{
		}

		[MethodImpl(256)]
		public ByteString ReadBytes()
		{
			return null;
		}

		[MethodImpl(256)]
		public int ReadEnum()
		{
			return 0;
		}

		[MethodImpl(256)]
		public int ReadLength()
		{
			return 0;
		}

		internal void CopyStateTo(CodedInputStream input)
		{
		}

		internal void LoadStateFrom(CodedInputStream input)
		{
		}
	}
}
