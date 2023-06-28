namespace Sirenix.Serialization
{
	public sealed class ByteSerializer : Serializer<byte>
	{
		public override byte ReadValue(IDataReader reader)
		{
			return 0;
		}

		public override void WriteValue(string name, byte value, IDataWriter writer)
		{
		}

		public ByteSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
