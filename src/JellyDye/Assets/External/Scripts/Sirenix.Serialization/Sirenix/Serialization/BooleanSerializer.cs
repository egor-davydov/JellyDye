namespace Sirenix.Serialization
{
	public sealed class BooleanSerializer : Serializer<bool>
	{
		public override bool ReadValue(IDataReader reader)
		{
			return false;
		}

		public override void WriteValue(string name, bool value, IDataWriter writer)
		{
		}

		public BooleanSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
