using System;

namespace Sirenix.Serialization
{
	public sealed class GuidSerializer : Serializer<Guid>
	{
		public override Guid ReadValue(IDataReader reader)
		{
			return default(Guid);
		}

		public override void WriteValue(string name, Guid value, IDataWriter writer)
		{
		}

		public GuidSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
