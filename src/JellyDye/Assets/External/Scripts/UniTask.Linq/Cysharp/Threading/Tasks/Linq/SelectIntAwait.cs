using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SelectIntAwait<TSource, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _SelectAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly Func<TSource, int, UniTask<TResult>> selector;

			private readonly CancellationToken cancellationToken;

			private int state;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private UniTask<TResult>.Awaiter awaiter2;

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

			public _SelectAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<TResult>> selector, CancellationToken cancellationToken)
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

		private readonly Func<TSource, int, UniTask<TResult>> selector;

		public SelectIntAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<TResult>> selector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
