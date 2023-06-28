namespace Sirenix.Serialization
{
	public sealed class UInt16Serializer : Serializer<ushort>
	{
		public override ushort ReadValue(IDataReader reader)
		{
			return 0;
		}

		public override void WriteValue(string name, ushort value, IDataWriter writer)
		{
		}

		public UInt16Serializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
