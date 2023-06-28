using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Any
	{
		internal static UniTask<bool> AnyAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		internal static UniTask<bool> AnyAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		internal static UniTask<bool> AnyAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		internal static UniTask<bool> AnyAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}
	}
}
