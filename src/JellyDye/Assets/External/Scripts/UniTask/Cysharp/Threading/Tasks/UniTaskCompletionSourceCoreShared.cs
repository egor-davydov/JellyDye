using System;

namespace Cysharp.Threading.Tasks
{
	internal static class UniTaskCompletionSourceCoreShared
	{
		internal static readonly Action<object> s_sentinel;

		private static void CompletionSentinel(object _)
		{
		}
	}
}
