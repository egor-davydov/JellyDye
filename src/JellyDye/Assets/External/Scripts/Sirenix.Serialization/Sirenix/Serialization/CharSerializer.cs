namespace Sirenix.Serialization
{
	public sealed class CharSerializer : Serializer<char>
	{
		public override char ReadValue(IDataReader reader)
		{
			return '\0';
		}

		public override void WriteValue(string name, char value, IDataWriter writer)
		{
		}

		public CharSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
