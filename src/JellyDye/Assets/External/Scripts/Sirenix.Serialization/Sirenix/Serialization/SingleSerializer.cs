namespace Sirenix.Serialization
{
	public sealed class SingleSerializer : Serializer<float>
	{
		public override float ReadValue(IDataReader reader)
		{
			return 0f;
		}

		public override void WriteValue(string name, float value, IDataWriter writer)
		{
		}

		public SingleSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
