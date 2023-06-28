using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class ExtensionAccessor : IFieldAccessor
	{
		private readonly Extension extension;

		private readonly ReflectionUtil.IExtensionReflectionHelper helper;

		public FieldDescriptor Descriptor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal ExtensionAccessor(FieldDescriptor descriptor)
		{
		}

		public void Clear(IMessage message)
		{
		}

		public bool HasValue(IMessage message)
		{
			return false;
		}

		public object GetValue(IMessage message)
		{
			return null;
		}
	}
}
