using System.Buffers;

namespace Google.Protobuf
{
	public static class MessageExtensions
	{
		public static byte[] ToByteArray(this IMessage message)
		{
			return null;
		}

		public static void WriteTo(this IMessage message, IBufferWriter<byte> output)
		{
		}

		internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		internal static void MergeFrom(this IMessage message, ReadOnlySequence<byte> data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}
	}
}
