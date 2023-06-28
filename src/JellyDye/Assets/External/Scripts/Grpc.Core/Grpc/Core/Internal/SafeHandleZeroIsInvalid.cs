using System;
using System.Runtime.InteropServices;

namespace Grpc.Core.Internal
{
	internal abstract class SafeHandleZeroIsInvalid : SafeHandle
	{
		public override bool IsInvalid => false;

		public SafeHandleZeroIsInvalid()
			: base((IntPtr)0, ownsHandle: false)
		{
		}
	}
}
