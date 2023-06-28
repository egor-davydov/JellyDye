using System;
using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public static class GenericCollectionFormatter
	{
		public static bool CanFormat(Type type, out Type elementType)
		{
			elementType = null;
			return false;
		}
	}
	public sealed class GenericCollectionFormatter<TCollection, TElement> : BaseFormatter<TCollection> where TCollection : ICollection<TElement>, new()
	{
		private static Serializer<TElement> valueReaderWriter;

		static GenericCollectionFormatter()
		{
		}

		public GenericCollectionFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override TCollection GetUninitializedObject()
		{
			return default(TCollection);
		}

		protected override void DeserializeImplementation(ref TCollection value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref TCollection value, IDataWriter writer)
		{
		}
	}
}
