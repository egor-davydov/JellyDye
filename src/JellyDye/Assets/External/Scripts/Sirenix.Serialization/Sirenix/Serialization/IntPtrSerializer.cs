using System;

namespace Sirenix.Serialization
{
	public sealed class IntPtrSerializer : Serializer<IntPtr>
	{
		public override IntPtr ReadValue(IDataReader reader)
		{
			return (IntPtr)0;
		}

		public override void WriteValue(string name, IntPtr value, IDataWriter writer)
		{
		}

		public IntPtrSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
