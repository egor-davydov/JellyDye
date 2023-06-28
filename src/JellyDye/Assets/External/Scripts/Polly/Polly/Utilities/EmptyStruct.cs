using System.Runtime.InteropServices;

namespace Polly.Utilities
{
	[StructLayout(0, Size = 1)]
	internal struct EmptyStruct
	{
		internal static readonly EmptyStruct Instance;
	}
}
