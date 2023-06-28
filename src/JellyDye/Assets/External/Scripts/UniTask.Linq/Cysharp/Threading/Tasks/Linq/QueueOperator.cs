using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class QueueOperator<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _Queue : IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private CancellationToken cancellationToken;

			private Channel<TSource> channel;

			private IUniTaskAsyncEnumerator<TSource> channelEnumerator;

			private IUniTaskAsyncEnumerator<TSource> sourceEnumerator;

			private bool channelClosed;

			public TSource Current => default(TSource);

			public _Queue(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static UniTaskVoid ConsumeAll(_Queue self, IUniTaskAsyncEnumerator<TSource> enumerator, ChannelWriter<TSource> writer)
			{
				return default(UniTaskVoid);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		public QueueOperator(IUniTaskAsyncEnumerable<TSource> source)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
