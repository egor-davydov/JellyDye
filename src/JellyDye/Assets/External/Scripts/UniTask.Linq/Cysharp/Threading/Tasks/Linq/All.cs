using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class All
	{
		internal static UniTask<bool> AllAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		internal static UniTask<bool> AllAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		internal static UniTask<bool> AllAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}
	}
}
