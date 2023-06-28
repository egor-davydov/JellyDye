namespace Sirenix.Serialization
{
	public sealed class SByteSerializer : Serializer<sbyte>
	{
		public override sbyte ReadValue(IDataReader reader)
		{
			return 0;
		}

		public override void WriteValue(string name, sbyte value, IDataWriter writer)
		{
		}

		public SByteSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
