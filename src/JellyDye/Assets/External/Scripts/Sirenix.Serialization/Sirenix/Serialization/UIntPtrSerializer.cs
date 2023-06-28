using System;

namespace Sirenix.Serialization
{
	public sealed class UIntPtrSerializer : Serializer<UIntPtr>
	{
		public override UIntPtr ReadValue(IDataReader reader)
		{
			return (UIntPtr)0u;
		}

		public override void WriteValue(string name, UIntPtr value, IDataWriter writer)
		{
		}

		public UIntPtrSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
