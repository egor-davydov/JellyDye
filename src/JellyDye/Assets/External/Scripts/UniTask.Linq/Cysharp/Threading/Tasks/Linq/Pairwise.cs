using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Pairwise<TSource> : IUniTaskAsyncEnumerable<(TSource, TSource)>
	{
		private sealed class _Pairwise : MoveNextSource, IUniTaskAsyncEnumerator<(TSource, TSource)>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private TSource prev;

			private bool isFirst;

			public (TSource, TSource) Current
			{
				[CompilerGenerated]
				get
				{
					return default((TSource, TSource));
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _Pairwise(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void SourceMoveNext()
			{
			}

			private static void MoveNextCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		public Pairwise(IUniTaskAsyncEnumerable<TSource> source)
		{
		}

		public IUniTaskAsyncEnumerator<(TSource, TSource)> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
