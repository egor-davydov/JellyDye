using System.Runtime.InteropServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	[StructLayout(3)]
	public readonly struct UniTaskCancelableAsyncEnumerable<T>
	{
		[StructLayout(3)]
		public readonly struct Enumerator
		{
			private readonly IUniTaskAsyncEnumerator<T> enumerator;

			public T Current => default(T);

			internal Enumerator(IUniTaskAsyncEnumerator<T> enumerator)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T> enumerable;

		private readonly CancellationToken cancellationToken;

		internal UniTaskCancelableAsyncEnumerable(IUniTaskAsyncEnumerable<T> enumerable, CancellationToken cancellationToken)
		{
		}

		public Enumerator GetAsyncEnumerator()
		{
			return default(Enumerator);
		}
	}
}
