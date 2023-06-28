namespace Sirenix.Serialization
{
	public sealed class Int32Serializer : Serializer<int>
	{
		public override int ReadValue(IDataReader reader)
		{
			return 0;
		}

		public override void WriteValue(string name, int value, IDataWriter writer)
		{
		}

		public Int32Serializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
