using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks
{
	internal static class AwaiterActions
	{
		internal static readonly Action<object> InvokeContinuationDelegate;

		[MethodImpl(256)]
		[DebuggerHidden]
		private static void Continuation(object state)
		{
		}
	}
}
