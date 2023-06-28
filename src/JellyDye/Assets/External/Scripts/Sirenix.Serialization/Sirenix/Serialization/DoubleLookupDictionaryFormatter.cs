using System.Collections.Generic;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	internal sealed class DoubleLookupDictionaryFormatter<TPrimary, TSecondary, TValue> : BaseFormatter<DoubleLookupDictionary<TPrimary, TSecondary, TValue>>
	{
		private static readonly Serializer<TPrimary> PrimaryReaderWriter;

		private static readonly Serializer<Dictionary<TSecondary, TValue>> InnerReaderWriter;

		static DoubleLookupDictionaryFormatter()
		{
		}

		public DoubleLookupDictionaryFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override DoubleLookupDictionary<TPrimary, TSecondary, TValue> GetUninitializedObject()
		{
			return null;
		}

		protected override void SerializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataWriter writer)
		{
		}

		protected override void DeserializeImplementation(ref DoubleLookupDictionary<TPrimary, TSecondary, TValue> value, IDataReader reader)
		{
		}
	}
}
