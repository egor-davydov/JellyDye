using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ForEach
	{
		public static UniTask ForEachAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ForEachAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Action<TSource, int> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask> action, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}
	}
}
