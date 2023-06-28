namespace Sirenix.Serialization
{
	public sealed class NullableFormatter<T> : BaseFormatter<T?> where T : struct
	{
		private static readonly Serializer<T> TSerializer;

		static NullableFormatter()
		{
		}

		public NullableFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}

		protected override void DeserializeImplementation(ref T? value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref T? value, IDataWriter writer)
		{
		}
	}
}
