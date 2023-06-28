using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class LongCount
	{
		internal static UniTask<long> LongCountAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		internal static UniTask<long> LongCountAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		internal static UniTask<long> LongCountAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		internal static UniTask<long> LongCountAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}
	}
}
