using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class TakeLast<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _TakeLast : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly int count;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private Queue<TSource> queue;

			private bool iterateCompleted;

			private bool continueNext;

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

			public _TakeLast(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken)
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

		private readonly int count;

		public TakeLast(IUniTaskAsyncEnumerable<TSource> source, int count)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
