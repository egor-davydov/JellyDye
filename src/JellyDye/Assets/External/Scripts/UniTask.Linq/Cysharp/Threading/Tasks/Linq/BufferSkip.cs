using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class BufferSkip<TSource> : IUniTaskAsyncEnumerable<IList<TSource>>
	{
		private sealed class _BufferSkip : MoveNextSource, IUniTaskAsyncEnumerator<IList<TSource>>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly int count;

			private readonly int skip;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private bool continueNext;

			private bool completed;

			private Queue<List<TSource>> buffers;

			private int index;

			public IList<TSource> Current
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _BufferSkip(IUniTaskAsyncEnumerable<TSource> source, int count, int skip, CancellationToken cancellationToken)
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

		private readonly int skip;

		public BufferSkip(IUniTaskAsyncEnumerable<TSource> source, int count, int skip)
		{
		}

		public IUniTaskAsyncEnumerator<IList<TSource>> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
