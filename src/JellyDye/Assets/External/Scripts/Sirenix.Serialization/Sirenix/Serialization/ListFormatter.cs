using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public class ListFormatter<T> : BaseFormatter<List<T>>
	{
		private static readonly Serializer<T> TSerializer;

		static ListFormatter()
		{
		}

		public ListFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override List<T> GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref List<T> value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref List<T> value, IDataWriter writer)
		{
		}
	}
}
