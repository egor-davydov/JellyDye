namespace Sirenix.Serialization
{
	public sealed class Int64Serializer : Serializer<long>
	{
		public override long ReadValue(IDataReader reader)
		{
			return 0L;
		}

		public override void WriteValue(string name, long value, IDataWriter writer)
		{
		}

		public Int64Serializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
