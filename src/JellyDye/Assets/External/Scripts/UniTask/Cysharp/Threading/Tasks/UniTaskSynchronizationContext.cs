using System.Runtime.InteropServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public class UniTaskSynchronizationContext : SynchronizationContext
	{
		[StructLayout(3)]
		private readonly struct Callback
		{
			private readonly SendOrPostCallback callback;

			private readonly object state;

			public Callback(SendOrPostCallback callback, object state)
			{
			}

			public void Invoke()
			{
			}
		}

		private const int MaxArrayLength = 2146435071;

		private const int InitialSize = 16;

		private static SpinLock gate;

		private static bool dequing;

		private static int actionListCount;

		private static Callback[] actionList;

		private static int waitingListCount;

		private static Callback[] waitingList;

		private static int opCount;

		public override void Send(SendOrPostCallback d, object state)
		{
		}

		public override void Post(SendOrPostCallback d, object state)
		{
		}

		public override void OperationStarted()
		{
		}

		public override void OperationCompleted()
		{
		}

		public override SynchronizationContext CreateCopy()
		{
			return null;
		}

		internal static void Run()
		{
		}
	}
}
