namespace Sirenix.Serialization
{
	public sealed class ArrayFormatter<T> : BaseFormatter<T[]>
	{
		private static Serializer<T> valueReaderWriter;

		protected override T[] GetUninitializedObject()
		{
			return null;
		}

		protected override void DeserializeImplementation(ref T[] value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref T[] value, IDataWriter writer)
		{
		}

		public ArrayFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
