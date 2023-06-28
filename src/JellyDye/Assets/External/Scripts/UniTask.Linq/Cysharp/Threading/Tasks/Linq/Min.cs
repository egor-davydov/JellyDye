using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Min
	{
		public static UniTask<TSource> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TResult> MinAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MinAwaitAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TResult>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MinAwaitWithCancellationAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TResult>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<int> MinAsync(IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<long> MinAsync(IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<float> MinAsync(IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> MinAsync(IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> MinAsync(IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<int?> MinAsync(IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<long?> MinAsync(IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<float?> MinAsync(IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> MinAsync(IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> MinAsync(IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}
	}
}
