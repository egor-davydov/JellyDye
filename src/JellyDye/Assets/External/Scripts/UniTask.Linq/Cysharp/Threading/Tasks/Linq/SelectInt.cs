using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SelectInt<TSource, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _Select : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly Func<TSource, int, TResult> selector;

			private readonly CancellationToken cancellationToken;

			private int state;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private Action moveNextAction;

			private int index;

			public TResult Current
			{
				[CompilerGenerated]
				get
				{
					return default(TResult);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _Select(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, TResult> selector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void MoveNext()
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Func<TSource, int, TResult> selector;

		public SelectInt(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
