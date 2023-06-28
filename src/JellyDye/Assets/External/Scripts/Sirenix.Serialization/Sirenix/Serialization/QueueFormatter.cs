using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public class QueueFormatter<TQueue, TValue> : BaseFormatter<TQueue> where TQueue : Queue<TValue>, new()
	{
		private static readonly Serializer<TValue> TSerializer;

		private static readonly bool IsPlainQueue;

		static QueueFormatter()
		{
		}

		public QueueFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override TQueue GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref TQueue value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref TQueue value, IDataWriter writer)
		{
		}
	}
}
