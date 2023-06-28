using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks
{
	public static class UniTaskStatusExtensions
	{
		[MethodImpl(256)]
		public static bool IsCompleted(this UniTaskStatus status)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsCompletedSuccessfully(this UniTaskStatus status)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsCanceled(this UniTaskStatus status)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsFaulted(this UniTaskStatus status)
		{
			return false;
		}
	}
}
