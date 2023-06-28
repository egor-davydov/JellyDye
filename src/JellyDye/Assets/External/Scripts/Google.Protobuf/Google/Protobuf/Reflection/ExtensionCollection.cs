using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class ExtensionCollection
	{
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder;

		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder;

		public IList<FieldDescriptor> UnorderedExtensions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal ExtensionCollection(FileDescriptor file, Extension[] extensions)
		{
		}

		internal ExtensionCollection(MessageDescriptor message, Extension[] extensions)
		{
		}

		internal void CrossLink()
		{
		}
	}
}
