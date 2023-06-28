using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class SingleOperator
	{
		public static UniTask<TSource> SingleAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}
	}
}
