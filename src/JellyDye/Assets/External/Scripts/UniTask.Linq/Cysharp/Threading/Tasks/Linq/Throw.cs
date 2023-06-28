using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Throw<TValue> : IUniTaskAsyncEnumerable<TValue>
	{
		private class _Throw : IUniTaskAsyncEnumerator<TValue>, IUniTaskAsyncDisposable
		{
			private readonly Exception exception;

			private CancellationToken cancellationToken;

			public TValue Current => default(TValue);

			public _Throw(Exception exception, CancellationToken cancellationToken)
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

		private readonly Exception exception;

		public Throw(Exception exception)
		{
		}

		public IUniTaskAsyncEnumerator<TValue> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
