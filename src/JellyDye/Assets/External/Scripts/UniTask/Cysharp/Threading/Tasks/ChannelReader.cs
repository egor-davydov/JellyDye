using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public abstract class ChannelReader<T>
	{
		public abstract UniTask Completion { get; }

		public abstract bool TryRead(out T item);

		public abstract UniTask<bool> WaitToReadAsync(CancellationToken cancellationToken = default(CancellationToken));

		public virtual UniTask<T> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		private UniTask<T> ReadAsyncCore(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public abstract IUniTaskAsyncEnumerable<T> ReadAllAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
