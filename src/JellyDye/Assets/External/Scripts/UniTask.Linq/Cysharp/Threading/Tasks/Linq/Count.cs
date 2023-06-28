using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Count
	{
		internal static UniTask<int> CountAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		internal static UniTask<int> CountAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		internal static UniTask<int> CountAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		internal static UniTask<int> CountAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}
	}
}
