using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Serialization
{
	internal sealed class DerivedDictionaryFormatter<TDictionary, TKey, TValue> : BaseFormatter<TDictionary> where TDictionary : Dictionary<TKey, TValue>, new()
	{
		private static readonly bool KeyIsValueType;

		private static readonly Serializer<IEqualityComparer<TKey>> EqualityComparerSerializer;

		private static readonly Serializer<TKey> KeyReaderWriter;

		private static readonly Serializer<TValue> ValueReaderWriter;

		private static readonly ConstructorInfo ComparerConstructor;

		static DerivedDictionaryFormatter()
		{
		}

		public DerivedDictionaryFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override TDictionary GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref TDictionary value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref TDictionary value, IDataWriter writer)
		{
		}
	}
}
