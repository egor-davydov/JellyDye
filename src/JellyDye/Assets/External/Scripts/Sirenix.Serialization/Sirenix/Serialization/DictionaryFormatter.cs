using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public sealed class DictionaryFormatter<TKey, TValue> : BaseFormatter<Dictionary<TKey, TValue>>
	{
		private static readonly bool KeyIsValueType;

		private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer;

		private static readonly Serializer<TKey> KeyReaderWriter;

		private static readonly Serializer<TValue> ValueReaderWriter;

		static DictionaryFormatter()
		{
		}

		public DictionaryFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override Dictionary<TKey, TValue> GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref Dictionary<TKey, TValue> value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref Dictionary<TKey, TValue> value, IDataWriter writer)
		{
		}
	}
}
