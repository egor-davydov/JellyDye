namespace Sirenix.Serialization
{
	public sealed class PrimitiveArrayFormatter<T> : MinimalBaseFormatter<T[]> where T : struct
	{
		protected override T[] GetUninitializedObject()
		{
			return null;
		}

		protected override void Read(ref T[] value, IDataReader reader)
		{
		}

		protected override void Write(ref T[] value, IDataWriter writer)
		{
		}

		public PrimitiveArrayFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
