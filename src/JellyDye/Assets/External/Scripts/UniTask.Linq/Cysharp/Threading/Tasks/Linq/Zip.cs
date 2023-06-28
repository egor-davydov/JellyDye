using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Zip<TFirst, TSecond, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _Zip : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> firstMoveNextCoreDelegate;

			private static readonly Action<object> secondMoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TFirst> first;

			private readonly IUniTaskAsyncEnumerable<TSecond> second;

			private readonly Func<TFirst, TSecond, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<TFirst> firstEnumerator;

			private IUniTaskAsyncEnumerator<TSecond> secondEnumerator;

			private UniTask<bool>.Awaiter firstAwaiter;

			private UniTask<bool>.Awaiter secondAwaiter;

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

			public _Zip(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void FirstMoveNextCore(object state)
			{
			}

			private static void SecondMoveNextCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TFirst> first;

		private readonly IUniTaskAsyncEnumerable<TSecond> second;

		private readonly Func<TFirst, TSecond, TResult> resultSelector;

		public Zip(IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
