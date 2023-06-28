using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Aggregate
	{
		internal static UniTask<TSource> AggregateAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, TSource> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource>);
		}

		internal static UniTask<TAccumulate> AggregateAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TAccumulate>);
		}

		internal static UniTask<TResult> AggregateAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		internal static UniTask<TSource> AggregateAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, UniTask<TSource>> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource>);
		}

		internal static UniTask<TAccumulate> AggregateAwaitAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TAccumulate>);
		}

		internal static UniTask<TResult> AggregateAwaitAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, Func<TAccumulate, UniTask<TResult>> resultSelector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		internal static UniTask<TSource> AggregateAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, CancellationToken, UniTask<TSource>> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource>);
		}

		internal static UniTask<TAccumulate> AggregateAwaitWithCancellationAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken)
		{
			return default(UniTask<TAccumulate>);
		}

		internal static UniTask<TResult> AggregateAwaitWithCancellationAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, Func<TAccumulate, CancellationToken, UniTask<TResult>> resultSelector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}
	}
}
