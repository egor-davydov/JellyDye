using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public sealed class KeyValuePairFormatter<TKey, TValue> : BaseFormatter<KeyValuePair<TKey, TValue>>
	{
		private static readonly Serializer<TKey> KeySerializer;

		private static readonly Serializer<TValue> ValueSerializer;

		protected override void SerializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataWriter writer)
		{
		}

		protected override void DeserializeImplementation(ref KeyValuePair<TKey, TValue> value, IDataReader reader)
		{
		}

		public KeyValuePairFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
