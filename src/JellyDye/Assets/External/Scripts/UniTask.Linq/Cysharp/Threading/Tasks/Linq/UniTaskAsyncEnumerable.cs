using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cysharp.Threading.Tasks.Linq
{
	public static class UniTaskAsyncEnumerable
	{
		public static UniTask<TSource> AggregateAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, TSource> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TAccumulate> AggregateAsync<TSource, TAccumulate>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TAccumulate>);
		}

		public static UniTask<TResult> AggregateAsync<TSource, TAccumulate, TResult>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TSource> AggregateAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, UniTask<TSource>> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TAccumulate> AggregateAwaitAsync<TSource, TAccumulate>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TAccumulate>);
		}

		public static UniTask<TResult> AggregateAwaitAsync<TSource, TAccumulate, TResult>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, Func<TAccumulate, UniTask<TResult>> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TSource> AggregateAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, CancellationToken, UniTask<TSource>> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TAccumulate> AggregateAwaitWithCancellationAsync<TSource, TAccumulate>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TAccumulate>);
		}

		public static UniTask<TResult> AggregateAwaitWithCancellationAsync<TSource, TAccumulate, TResult>(this IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, Func<TAccumulate, CancellationToken, UniTask<TResult>> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<bool> AllAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AllAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AllAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AnyAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AnyAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AnyAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> AnyAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static IUniTaskAsyncEnumerable<TSource> Append<TSource>(this IUniTaskAsyncEnumerable<TSource> source, TSource element)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Prepend<TSource>(this IUniTaskAsyncEnumerable<TSource> source, TSource element)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> AsUniTaskAsyncEnumerable<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static UniTask<double> AverageAsync(this IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAsync(this IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<float> AverageAsync(this IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> AverageAsync(this IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> AverageAsync(this IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<double?> AverageAsync(this IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAsync(this IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<float?> AverageAsync(this IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> AverageAsync(this IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> AverageAsync(this IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> AverageAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> AverageAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> AverageAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static IUniTaskAsyncEnumerable<IList<TSource>> Buffer<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IList<TSource>> Buffer<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count, int skip)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Cast<TResult>(this IUniTaskAsyncEnumerable<object> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, Func<T1, T2, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, Func<T1, T2, T3, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, Func<T1, T2, T3, T4, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, Func<T1, T2, T3, T4, T5, T6, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, IUniTaskAsyncEnumerable<T15> source15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Concat<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second)
		{
			return null;
		}

		public static UniTask<bool> ContainsAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, TSource value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> ContainsAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<int> CountAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> CountAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> CountAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> CountAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static IUniTaskAsyncEnumerable<T> Create<T>(Func<IAsyncWriter<T>, CancellationToken, UniTask> create)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DefaultIfEmpty<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DefaultIfEmpty<TSource>(this IUniTaskAsyncEnumerable<TSource> source, TSource defaultValue)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Distinct<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Distinct<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Distinct<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Distinct<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChanged<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChanged<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChanged<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChanged<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChangedAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChangedAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChangedAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> DistinctUntilChangedAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Do<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Do<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Do<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action onCompleted)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Do<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Do<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IObserver<TSource> observer)
		{
			return null;
		}

		public static UniTask<TSource> ElementAtAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int index, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> ElementAtOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int index, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static IUniTaskAsyncEnumerable<T> Empty<T>()
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Except<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Except<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static UniTask<TSource> FirstAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstOrDefaultAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> FirstOrDefaultAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask ForEachAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ForEachAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource, int> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		[Obsolete]
		public static UniTask ForEachAsync<T>(this IUniTaskAsyncEnumerable<T> source, Func<T, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		[Obsolete]
		public static UniTask ForEachAsync<T>(this IUniTaskAsyncEnumerable<T> source, Func<T, int, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ForEachAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask> action, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwait<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwait<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwait<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TSource>> GroupByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwaitWithCancellation<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<IGrouping<TKey, TElement>> GroupByAwaitWithCancellation<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TKey, IEnumerable<TSource>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, Func<TKey, IEnumerable<TElement>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoinAwait<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoinAwait<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> GroupJoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Intersect<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Intersect<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> JoinAwait<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> JoinAwait<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> JoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> JoinAwaitWithCancellation<TOuter, TInner, TKey, TResult>(this IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, CancellationToken, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static UniTask<TSource> LastAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastOrDefaultAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> LastOrDefaultAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<long> LongCountAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> LongCountAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> LongCountAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> LongCountAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<TSource> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TResult> MaxAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MaxAwaitAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MaxAwaitWithCancellationAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TSource> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TResult> MinAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MinAwaitAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<TResult> MinAwaitWithCancellationAsync<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TResult>);
		}

		public static UniTask<int> MinAsync(this IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<long> MinAsync(this IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<float> MinAsync(this IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> MinAsync(this IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> MinAsync(this IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<int?> MinAsync(this IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<long?> MinAsync(this IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<float?> MinAsync(this IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> MinAsync(this IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> MinAsync(this IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MinAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<int> MaxAsync(this IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<long> MaxAsync(this IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<float> MaxAsync(this IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> MaxAsync(this IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> MaxAsync(this IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<int?> MaxAsync(this IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<long?> MaxAsync(this IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<float?> MaxAsync(this IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> MaxAsync(this IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> MaxAsync(this IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> MaxAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static IUniTaskAsyncEnumerable<T> Never<T>()
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> OfType<TResult>(this IUniTaskAsyncEnumerable<object> source)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderBy<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescending<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescending<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescendingAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescendingAwait<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescendingAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> OrderByDescendingAwaitWithCancellation<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenBy<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenBy<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByAwait<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByAwait<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByAwaitWithCancellation<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByAwaitWithCancellation<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescending<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescending<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescendingAwait<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescendingAwait<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescendingAwaitWithCancellation<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector)
		{
			return null;
		}

		public static IUniTaskOrderedAsyncEnumerable<TSource> ThenByDescendingAwaitWithCancellation<TSource, TKey>(this IUniTaskOrderedAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<(TSource, TSource)> Pairwise<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IConnectableUniTaskAsyncEnumerable<TSource> Publish<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Queue<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<int> Range(int start, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TElement> Repeat<TElement>(TElement element, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TValue> Return<TValue>(TValue value)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Reverse<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Select<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Select<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectAwait<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectAwait<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectAwaitWithCancellation<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectAwaitWithCancellation<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectMany<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, IUniTaskAsyncEnumerable<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectMany<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, IUniTaskAsyncEnumerable<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, IUniTaskAsyncEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, IUniTaskAsyncEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwait<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<IUniTaskAsyncEnumerable<TResult>>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwait<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<IUniTaskAsyncEnumerable<TResult>>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwait<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<IUniTaskAsyncEnumerable<TCollection>>> collectionSelector, Func<TSource, TCollection, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwait<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<IUniTaskAsyncEnumerable<TCollection>>> collectionSelector, Func<TSource, TCollection, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwaitWithCancellation<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TResult>>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwaitWithCancellation<TSource, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TResult>>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwaitWithCancellation<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> collectionSelector, Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> SelectManyAwaitWithCancellation<TSource, TCollection, TResult>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> collectionSelector, Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector)
		{
			return null;
		}

		public static UniTask<bool> SequenceEqualAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> SequenceEqualAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<bool>);
		}

		public static UniTask<TSource> SingleAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleOrDefaultAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleOrDefaultAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static UniTask<TSource> SingleOrDefaultAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource>);
		}

		public static IUniTaskAsyncEnumerable<TSource> Skip<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipLast<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipUntil<TSource>(this IUniTaskAsyncEnumerable<TSource> source, UniTask other)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipUntil<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<CancellationToken, UniTask> other)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipUntilCanceled<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhile<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhile<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhileAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhileAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhileAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> SkipWhileAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> action)
		{
			return null;
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> action)
		{
			return null;
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTaskVoid> action)
		{
			return null;
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> action, CancellationToken cancellationToken)
		{
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> action, CancellationToken cancellationToken)
		{
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTaskVoid> action, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, CancellationToken cancellationToken)
		{
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, CancellationToken cancellationToken)
		{
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action<Exception> onError, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action<Exception> onError, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action<Exception> onError)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action<Exception> onError, CancellationToken cancellationToken)
		{
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action onCompleted)
		{
			return null;
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action onCompleted)
		{
			return null;
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action onCompleted, CancellationToken cancellationToken)
		{
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action onCompleted, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action onCompleted)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action onCompleted, CancellationToken cancellationToken)
		{
		}

		public static IDisposable SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action onCompleted)
		{
			return null;
		}

		public static void SubscribeAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action onCompleted, CancellationToken cancellationToken)
		{
		}

		public static IDisposable Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IObserver<TSource> observer)
		{
			return null;
		}

		public static void Subscribe<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IObserver<TSource> observer, CancellationToken cancellationToken)
		{
		}

		public static UniTask<int> SumAsync(this IUniTaskAsyncEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int>);
		}

		public static UniTask<long> SumAsync(this IUniTaskAsyncEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<long> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long>);
		}

		public static UniTask<float> SumAsync(this IUniTaskAsyncEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float>);
		}

		public static UniTask<double> SumAsync(this IUniTaskAsyncEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<double> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double>);
		}

		public static UniTask<decimal> SumAsync(this IUniTaskAsyncEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<decimal> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal>);
		}

		public static UniTask<int?> SumAsync(this IUniTaskAsyncEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<int?> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<int?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<int?>);
		}

		public static UniTask<long?> SumAsync(this IUniTaskAsyncEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<long?> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<long?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<long?>);
		}

		public static UniTask<float?> SumAsync(this IUniTaskAsyncEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<float?> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<float?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<float?>);
		}

		public static UniTask<double?> SumAsync(this IUniTaskAsyncEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<double?> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<double?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<double?>);
		}

		public static UniTask<decimal?> SumAsync(this IUniTaskAsyncEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> SumAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> SumAwaitAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static UniTask<decimal?> SumAwaitWithCancellationAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<decimal?>> selector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<decimal?>);
		}

		public static IUniTaskAsyncEnumerable<TSource> Take<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeLast<TSource>(this IUniTaskAsyncEnumerable<TSource> source, int count)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeUntil<TSource>(this IUniTaskAsyncEnumerable<TSource> source, UniTask other)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeUntil<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<CancellationToken, UniTask> other)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeUntilCanceled<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhile<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhile<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhileAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhileAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhileAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> TakeWhileAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TValue> Throw<TValue>(Exception exception)
		{
			return null;
		}

		public static UniTask<TSource[]> ToArrayAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<TSource[]>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAwaitAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAwaitAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAwaitAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAwaitAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAwaitWithCancellationAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TSource>> ToDictionaryAwaitWithCancellationAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TSource>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAwaitWithCancellationAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<Dictionary<TKey, TElement>> ToDictionaryAwaitWithCancellationAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<Dictionary<TKey, TElement>>);
		}

		public static UniTask<HashSet<TSource>> ToHashSetAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<HashSet<TSource>>);
		}

		public static UniTask<HashSet<TSource>> ToHashSetAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<HashSet<TSource>>);
		}

		public static UniTask<List<TSource>> ToListAsync<TSource>(this IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<List<TSource>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAwaitAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAwaitAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAwaitAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAwaitAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAwaitWithCancellationAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TSource>> ToLookupAwaitWithCancellationAsync<TSource, TKey>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAwaitWithCancellationAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static UniTask<ILookup<TKey, TElement>> ToLookupAwaitWithCancellationAsync<TSource, TKey, TElement>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		public static IObservable<TSource> ToObservable<TSource>(this IUniTaskAsyncEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> ToUniTaskAsyncEnumerable<TSource>(this IEnumerable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> ToUniTaskAsyncEnumerable<TSource>(this Task<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> ToUniTaskAsyncEnumerable<TSource>(this UniTask<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> ToUniTaskAsyncEnumerable<TSource>(this IObservable<TSource> source)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Union<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Union<TSource>(this IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> EveryUpdate(PlayerLoopTiming updateTiming = PlayerLoopTiming.Update)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TProperty> EveryValueChanged<TTarget, TProperty>(TTarget target, Func<TTarget, TProperty> propertySelector, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update, IEqualityComparer<TProperty> equalityComparer = null) where TTarget : class
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> Timer(TimeSpan dueTime, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update, bool ignoreTimeScale = false)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> Timer(TimeSpan dueTime, TimeSpan period, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update, bool ignoreTimeScale = false)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> Interval(TimeSpan period, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update, bool ignoreTimeScale = false)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> TimerFrame(int dueTimeFrameCount, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> TimerFrame(int dueTimeFrameCount, int periodFrameCount, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> IntervalFrame(int intervalFrameCount, PlayerLoopTiming updateTiming = PlayerLoopTiming.Update)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Where<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> Where<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> WhereAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> WhereAwait<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> WhereAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TSource> WhereAwaitWithCancellation<TSource>(this IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<bool>> predicate)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<(TFirst, TSecond)> Zip<TFirst, TSecond>(this IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> ZipAwait<TFirst, TSecond, TResult>(this IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, UniTask<TResult>> selector)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<TResult> ZipAwaitWithCancellation<TFirst, TSecond, TResult>(this IUniTaskAsyncEnumerable<TFirst> first, IUniTaskAsyncEnumerable<TSecond> second, Func<TFirst, TSecond, CancellationToken, UniTask<TResult>> selector)
		{
			return null;
		}
	}
}
