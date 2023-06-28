namespace Sirenix.Serialization
{
	public sealed class StringSerializer : Serializer<string>
	{
		public override string ReadValue(IDataReader reader)
		{
			return null;
		}

		public override void WriteValue(string name, string value, IDataWriter writer)
		{
		}

		public StringSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
