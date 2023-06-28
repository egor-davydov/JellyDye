namespace Sirenix.Serialization
{
	public sealed class DecimalSerializer : Serializer<decimal>
	{
		public override decimal ReadValue(IDataReader reader)
		{
			return default(decimal);
		}

		public override void WriteValue(string name, decimal value, IDataWriter writer)
		{
		}

		public DecimalSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
