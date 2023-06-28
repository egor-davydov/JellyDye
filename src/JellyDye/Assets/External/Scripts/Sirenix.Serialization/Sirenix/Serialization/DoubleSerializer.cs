namespace Sirenix.Serialization
{
	public sealed class DoubleSerializer : Serializer<double>
	{
		public override double ReadValue(IDataReader reader)
		{
			return 0.0;
		}

		public override void WriteValue(string name, double value, IDataWriter writer)
		{
		}

		public DoubleSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
