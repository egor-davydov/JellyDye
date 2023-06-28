using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class MapFieldAccessor : FieldAccessorBase
	{
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
			: base(null, null)
		{
		}

		public override void Clear(IMessage message)
		{
		}

		public override bool HasValue(IMessage message)
		{
			return false;
		}

		public override void SetValue(IMessage message, object value)
		{
		}
	}
}
