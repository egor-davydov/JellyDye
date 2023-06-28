using System;

namespace Grpc.Core
{
	public class Marshaller<T>
	{
		private readonly Func<T, byte[]> serializer;

		private readonly Func<byte[], T> deserializer;

		private readonly Action<T, SerializationContext> contextualSerializer;

		private readonly Func<DeserializationContext, T> contextualDeserializer;

		public Action<T, SerializationContext> ContextualSerializer => null;

		public Func<DeserializationContext, T> ContextualDeserializer => null;

		public Marshaller(Func<T, byte[]> serializer, Func<byte[], T> deserializer)
		{
		}

		public Marshaller(Action<T, SerializationContext> serializer, Func<DeserializationContext, T> deserializer)
		{
		}

		private void EmulateContextualSerializer(T message, SerializationContext context)
		{
		}

		private T EmulateContextualDeserializer(DeserializationContext context)
		{
			return default(T);
		}
	}
}
