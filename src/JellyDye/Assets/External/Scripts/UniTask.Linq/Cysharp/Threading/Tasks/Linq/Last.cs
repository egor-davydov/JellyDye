using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Last
	{
		public static UniTask<TSource> LastAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}
	}
}
