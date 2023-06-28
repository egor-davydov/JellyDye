using System;

namespace Cysharp.Threading.Tasks
{
	public class AsyncLazy
	{
		private static Action<object> continuation;

		private Func<UniTask> taskFactory;

		private UniTaskCompletionSource completionSource;

		private UniTask.Awaiter awaiter;

		private object syncLock;

		private bool initialized;

		public UniTask Task => default(UniTask);

		public AsyncLazy(Func<UniTask> taskFactory)
		{
		}

		internal AsyncLazy(UniTask task)
		{
		}

		public UniTask.Awaiter GetAwaiter()
		{
			return default(UniTask.Awaiter);
		}

		private void EnsureInitialized()
		{
		}

		private void EnsureInitializedCore()
		{
		}

		private void SetCompletionSource(in UniTask.Awaiter awaiter)
		{
		}

		private static void SetCompletionSource(object state)
		{
		}
	}
	public class AsyncLazy<T>
	{
		private static Action<object> continuation;

		private Func<UniTask<T>> taskFactory;

		private UniTaskCompletionSource<T> completionSource;

		private UniTask<T>.Awaiter awaiter;

		private object syncLock;

		private bool initialized;

		public UniTask<T> Task => default(UniTask<T>);

		public AsyncLazy(Func<UniTask<T>> taskFactory)
		{
		}

		internal AsyncLazy(UniTask<T> task)
		{
		}

		public UniTask<T>.Awaiter GetAwaiter()
		{
			return default(UniTask<T>.Awaiter);
		}

		private void EnsureInitialized()
		{
		}

		private void EnsureInitializedCore()
		{
		}

		private void SetCompletionSource(in UniTask<T>.Awaiter awaiter)
		{
		}

		private static void SetCompletionSource(object state)
		{
		}
	}
}
