using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class ToUniTaskAsyncEnumerable<T> : IUniTaskAsyncEnumerable<T>
	{
		private class _ToUniTaskAsyncEnumerable : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			private readonly IEnumerable<T> source;

			private CancellationToken cancellationToken;

			private IEnumerator<T> enumerator;

			public T Current => default(T);

			public _ToUniTaskAsyncEnumerable(IEnumerable<T> source, CancellationToken cancellationToken)
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

		private readonly IEnumerable<T> source;

		public ToUniTaskAsyncEnumerable(IEnumerable<T> source)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
