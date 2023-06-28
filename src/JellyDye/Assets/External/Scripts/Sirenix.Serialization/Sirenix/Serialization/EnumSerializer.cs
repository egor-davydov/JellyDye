namespace Sirenix.Serialization
{
	public sealed class EnumSerializer<T> : Serializer<T>
	{
		static EnumSerializer()
		{
		}

		public override T ReadValue(IDataReader reader)
		{
			return default(T);
		}

		public override void WriteValue(string name, T value, IDataWriter writer)
		{
		}

		public EnumSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
