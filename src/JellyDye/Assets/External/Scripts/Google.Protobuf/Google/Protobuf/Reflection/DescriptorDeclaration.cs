using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorDeclaration
	{
		public int StartLine
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		private DescriptorDeclaration(IDescriptor descriptor, SourceCodeInfo.Types.Location location)
		{
		}

		internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location)
		{
			return null;
		}
	}
}
