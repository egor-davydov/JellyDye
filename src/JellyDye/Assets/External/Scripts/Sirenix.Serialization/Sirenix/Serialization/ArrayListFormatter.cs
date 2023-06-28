using System.Collections;

namespace Sirenix.Serialization
{
	public class ArrayListFormatter : BaseFormatter<ArrayList>
	{
		private static readonly Serializer<object> ObjectSerializer;

		protected override ArrayList GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref ArrayList value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref ArrayList value, IDataWriter writer)
		{
		}

		public ArrayListFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
