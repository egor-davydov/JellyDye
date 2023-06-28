using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Concat<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _Concat : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private enum IteratingState
			{
				IteratingFirst = 0,
				IteratingSecond = 1,
				Complete = 2
			}

			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> first;

			private readonly IUniTaskAsyncEnumerable<TSource> second;

			private CancellationToken cancellationToken;

			private IteratingState iteratingState;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			public TSource Current
			{
				[CompilerGenerated]
				get
				{
					return default(TSource);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _Concat(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void StartIterate()
			{
			}

			private static void MoveNextCore(object state)
			{
			}

			private UniTaskVoid RunSecondAfterDisposeAsync()
			{
				return default(UniTaskVoid);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> first;

		private readonly IUniTaskAsyncEnumerable<TSource> second;

		public Concat(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
