namespace Sirenix.Serialization
{
	public sealed class UInt32Serializer : Serializer<uint>
	{
		public override uint ReadValue(IDataReader reader)
		{
			return 0u;
		}

		public override void WriteValue(string name, uint value, IDataWriter writer)
		{
		}

		public UInt32Serializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
