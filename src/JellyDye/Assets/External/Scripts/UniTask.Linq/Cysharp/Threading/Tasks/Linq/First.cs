using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class First
	{
		public static UniTask<TSource> FirstAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}
	}
}
