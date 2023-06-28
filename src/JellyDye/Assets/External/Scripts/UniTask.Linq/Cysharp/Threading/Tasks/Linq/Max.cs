using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Max
	{
		public static UniTask<TSource> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TResult> MaxAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MaxAwaitAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TResult>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MaxAwaitWithCancellationAsync<TSource, TResult>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TResult>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<int> MaxAsync(IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static UniTask<long> MaxAsync(IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long>);
		}

		public static UniTask<float> MaxAsync(IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> MaxAsync(IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> MaxAsync(IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<int?> MaxAsync(IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<int?>);
		}

		public static UniTask<long?> MaxAsync(IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<long?>);
		}

		public static UniTask<float?> MaxAsync(IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> MaxAsync(IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> MaxAsync(IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken)
		{
			return default(UniTask<decimal?>);
		}
	}
}
