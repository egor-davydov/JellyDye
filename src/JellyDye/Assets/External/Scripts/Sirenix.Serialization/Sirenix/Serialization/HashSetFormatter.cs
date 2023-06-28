using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public class HashSetFormatter<T> : BaseFormatter<HashSet<T>>
	{
		private static readonly Serializer<T> TSerializer;

		static HashSetFormatter()
		{
		}

		public HashSetFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override HashSet<T> GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref HashSet<T> value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref HashSet<T> value, IDataWriter writer)
		{
		}
	}
}
