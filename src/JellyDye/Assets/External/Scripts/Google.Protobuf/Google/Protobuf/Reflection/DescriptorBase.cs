using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public abstract class DescriptorBase : IDescriptor
	{
		public abstract string Name { get; }

		public string FullName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public FileDescriptor File
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal DescriptorBase(FileDescriptor file, string fullName, int index)
		{
		}

		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}
	}
}
