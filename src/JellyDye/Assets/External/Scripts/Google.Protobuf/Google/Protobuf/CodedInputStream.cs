using System;
using System.IO;

namespace Google.Protobuf
{
	public sealed class CodedInputStream : IDisposable
	{
		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private readonly Stream input;

		private ParserInternalState state;

		internal bool DiscardUnknownFields
		{
			set
			{
			}
		}

		internal ExtensionRegistry ExtensionRegistry
		{
			set
			{
			}
		}

		internal byte[] InternalBuffer => null;

		internal Stream InternalInputStream => null;

		internal unsafe ref ParserInternalState InternalState => ref *(ParserInternalState*)null;

		public CodedInputStream(byte[] buffer)
		{
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen)
		{
		}

		public void Dispose()
		{
		}

		internal void CheckReadEndOfStreamTag()
		{
		}

		public uint ReadTag()
		{
			return 0u;
		}

		public ulong ReadUInt64()
		{
			return 0uL;
		}

		public long ReadInt64()
		{
			return 0L;
		}

		public bool ReadBool()
		{
			return false;
		}

		public string ReadString()
		{
			return null;
		}

		public void ReadMessage(IMessage builder)
		{
		}

		internal ulong ReadRawVarint64()
		{
			return 0uL;
		}

		public void ReadRawMessage(IMessage message)
		{
		}
	}
}
