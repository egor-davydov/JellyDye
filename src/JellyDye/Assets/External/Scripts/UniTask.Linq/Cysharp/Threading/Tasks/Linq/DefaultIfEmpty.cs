using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class DefaultIfEmpty<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _DefaultIfEmpty : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private enum IteratingState : byte
			{
				Empty = 0,
				Iterating = 1,
				Completed = 2
			}

			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly TSource defaultValue;

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

			public _DefaultIfEmpty(IUniTaskAsyncEnumerable<TSource> source, TSource defaultValue, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
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

		private readonly TSource defaultValue;

		public DefaultIfEmpty(IUniTaskAsyncEnumerable<TSource> source, TSource defaultValue)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
