using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public class MessageParser
	{
		private Func<IMessage> factory;

		internal bool DiscardUnknownFields
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal ExtensionRegistry Extensions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions)
		{
		}

		public IMessage ParseFrom(ByteString data)
		{
			return null;
		}
	}
	public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
	{
		private readonly Func<T> factory;

		public MessageParser(Func<T> factory)
			: base(null, discardUnknownFields: false, null)
		{
		}

		internal MessageParser(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions)
			: base(null, discardUnknownFields: false, null)
		{
		}

		internal T CreateTemplate()
		{
			return default(T);
		}

		public T ParseFrom(byte[] data)
		{
			return default(T);
		}

		public T ParseFrom(ReadOnlySequence<byte> data)
		{
			return default(T);
		}

		public MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry)
		{
			return null;
		}
	}
}
