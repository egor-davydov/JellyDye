using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class CombineLatest<T1, T2, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private const int CompleteCount = 2;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly Func<T1, T2, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, Func<T1, T2, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly Func<T1, T2, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, Func<T1, T2, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private const int CompleteCount = 3;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly Func<T1, T2, T3, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, Func<T1, T2, T3, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly Func<T1, T2, T3, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, Func<T1, T2, T3, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private const int CompleteCount = 4;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly Func<T1, T2, T3, T4, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, Func<T1, T2, T3, T4, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly Func<T1, T2, T3, T4, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, Func<T1, T2, T3, T4, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private const int CompleteCount = 5;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private const int CompleteCount = 6;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly Func<T1, T2, T3, T4, T5, T6, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, Func<T1, T2, T3, T4, T5, T6, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly Func<T1, T2, T3, T4, T5, T6, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, Func<T1, T2, T3, T4, T5, T6, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private const int CompleteCount = 7;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, Func<T1, T2, T3, T4, T5, T6, T7, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private const int CompleteCount = 8;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private const int CompleteCount = 9;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private const int CompleteCount = 10;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private static readonly Action<object> Completed11Delegate;

			private const int CompleteCount = 11;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly IUniTaskAsyncEnumerable<T11> source11;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private IUniTaskAsyncEnumerator<T11> enumerator11;

			private UniTask<bool>.Awaiter awaiter11;

			private bool hasCurrent11;

			private bool running11;

			private T11 current11;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private static void Completed11(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly IUniTaskAsyncEnumerable<T11> source11;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private static readonly Action<object> Completed11Delegate;

			private static readonly Action<object> Completed12Delegate;

			private const int CompleteCount = 12;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly IUniTaskAsyncEnumerable<T11> source11;

			private readonly IUniTaskAsyncEnumerable<T12> source12;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private IUniTaskAsyncEnumerator<T11> enumerator11;

			private UniTask<bool>.Awaiter awaiter11;

			private bool hasCurrent11;

			private bool running11;

			private T11 current11;

			private IUniTaskAsyncEnumerator<T12> enumerator12;

			private UniTask<bool>.Awaiter awaiter12;

			private bool hasCurrent12;

			private bool running12;

			private T12 current12;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private static void Completed11(object state)
			{
			}

			private static void Completed12(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly IUniTaskAsyncEnumerable<T11> source11;

		private readonly IUniTaskAsyncEnumerable<T12> source12;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private static readonly Action<object> Completed11Delegate;

			private static readonly Action<object> Completed12Delegate;

			private static readonly Action<object> Completed13Delegate;

			private const int CompleteCount = 13;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly IUniTaskAsyncEnumerable<T11> source11;

			private readonly IUniTaskAsyncEnumerable<T12> source12;

			private readonly IUniTaskAsyncEnumerable<T13> source13;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private IUniTaskAsyncEnumerator<T11> enumerator11;

			private UniTask<bool>.Awaiter awaiter11;

			private bool hasCurrent11;

			private bool running11;

			private T11 current11;

			private IUniTaskAsyncEnumerator<T12> enumerator12;

			private UniTask<bool>.Awaiter awaiter12;

			private bool hasCurrent12;

			private bool running12;

			private T12 current12;

			private IUniTaskAsyncEnumerator<T13> enumerator13;

			private UniTask<bool>.Awaiter awaiter13;

			private bool hasCurrent13;

			private bool running13;

			private T13 current13;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private static void Completed11(object state)
			{
			}

			private static void Completed12(object state)
			{
			}

			private static void Completed13(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly IUniTaskAsyncEnumerable<T11> source11;

		private readonly IUniTaskAsyncEnumerable<T12> source12;

		private readonly IUniTaskAsyncEnumerable<T13> source13;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private static readonly Action<object> Completed11Delegate;

			private static readonly Action<object> Completed12Delegate;

			private static readonly Action<object> Completed13Delegate;

			private static readonly Action<object> Completed14Delegate;

			private const int CompleteCount = 14;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly IUniTaskAsyncEnumerable<T11> source11;

			private readonly IUniTaskAsyncEnumerable<T12> source12;

			private readonly IUniTaskAsyncEnumerable<T13> source13;

			private readonly IUniTaskAsyncEnumerable<T14> source14;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private IUniTaskAsyncEnumerator<T11> enumerator11;

			private UniTask<bool>.Awaiter awaiter11;

			private bool hasCurrent11;

			private bool running11;

			private T11 current11;

			private IUniTaskAsyncEnumerator<T12> enumerator12;

			private UniTask<bool>.Awaiter awaiter12;

			private bool hasCurrent12;

			private bool running12;

			private T12 current12;

			private IUniTaskAsyncEnumerator<T13> enumerator13;

			private UniTask<bool>.Awaiter awaiter13;

			private bool hasCurrent13;

			private bool running13;

			private T13 current13;

			private IUniTaskAsyncEnumerator<T14> enumerator14;

			private UniTask<bool>.Awaiter awaiter14;

			private bool hasCurrent14;

			private bool running14;

			private T14 current14;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private static void Completed11(object state)
			{
			}

			private static void Completed12(object state)
			{
			}

			private static void Completed13(object state)
			{
			}

			private static void Completed14(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly IUniTaskAsyncEnumerable<T11> source11;

		private readonly IUniTaskAsyncEnumerable<T12> source12;

		private readonly IUniTaskAsyncEnumerable<T13> source13;

		private readonly IUniTaskAsyncEnumerable<T14> source14;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class CombineLatest<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> Completed1Delegate;

			private static readonly Action<object> Completed2Delegate;

			private static readonly Action<object> Completed3Delegate;

			private static readonly Action<object> Completed4Delegate;

			private static readonly Action<object> Completed5Delegate;

			private static readonly Action<object> Completed6Delegate;

			private static readonly Action<object> Completed7Delegate;

			private static readonly Action<object> Completed8Delegate;

			private static readonly Action<object> Completed9Delegate;

			private static readonly Action<object> Completed10Delegate;

			private static readonly Action<object> Completed11Delegate;

			private static readonly Action<object> Completed12Delegate;

			private static readonly Action<object> Completed13Delegate;

			private static readonly Action<object> Completed14Delegate;

			private static readonly Action<object> Completed15Delegate;

			private const int CompleteCount = 15;

			private readonly IUniTaskAsyncEnumerable<T1> source1;

			private readonly IUniTaskAsyncEnumerable<T2> source2;

			private readonly IUniTaskAsyncEnumerable<T3> source3;

			private readonly IUniTaskAsyncEnumerable<T4> source4;

			private readonly IUniTaskAsyncEnumerable<T5> source5;

			private readonly IUniTaskAsyncEnumerable<T6> source6;

			private readonly IUniTaskAsyncEnumerable<T7> source7;

			private readonly IUniTaskAsyncEnumerable<T8> source8;

			private readonly IUniTaskAsyncEnumerable<T9> source9;

			private readonly IUniTaskAsyncEnumerable<T10> source10;

			private readonly IUniTaskAsyncEnumerable<T11> source11;

			private readonly IUniTaskAsyncEnumerable<T12> source12;

			private readonly IUniTaskAsyncEnumerable<T13> source13;

			private readonly IUniTaskAsyncEnumerable<T14> source14;

			private readonly IUniTaskAsyncEnumerable<T15> source15;

			private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<T1> enumerator1;

			private UniTask<bool>.Awaiter awaiter1;

			private bool hasCurrent1;

			private bool running1;

			private T1 current1;

			private IUniTaskAsyncEnumerator<T2> enumerator2;

			private UniTask<bool>.Awaiter awaiter2;

			private bool hasCurrent2;

			private bool running2;

			private T2 current2;

			private IUniTaskAsyncEnumerator<T3> enumerator3;

			private UniTask<bool>.Awaiter awaiter3;

			private bool hasCurrent3;

			private bool running3;

			private T3 current3;

			private IUniTaskAsyncEnumerator<T4> enumerator4;

			private UniTask<bool>.Awaiter awaiter4;

			private bool hasCurrent4;

			private bool running4;

			private T4 current4;

			private IUniTaskAsyncEnumerator<T5> enumerator5;

			private UniTask<bool>.Awaiter awaiter5;

			private bool hasCurrent5;

			private bool running5;

			private T5 current5;

			private IUniTaskAsyncEnumerator<T6> enumerator6;

			private UniTask<bool>.Awaiter awaiter6;

			private bool hasCurrent6;

			private bool running6;

			private T6 current6;

			private IUniTaskAsyncEnumerator<T7> enumerator7;

			private UniTask<bool>.Awaiter awaiter7;

			private bool hasCurrent7;

			private bool running7;

			private T7 current7;

			private IUniTaskAsyncEnumerator<T8> enumerator8;

			private UniTask<bool>.Awaiter awaiter8;

			private bool hasCurrent8;

			private bool running8;

			private T8 current8;

			private IUniTaskAsyncEnumerator<T9> enumerator9;

			private UniTask<bool>.Awaiter awaiter9;

			private bool hasCurrent9;

			private bool running9;

			private T9 current9;

			private IUniTaskAsyncEnumerator<T10> enumerator10;

			private UniTask<bool>.Awaiter awaiter10;

			private bool hasCurrent10;

			private bool running10;

			private T10 current10;

			private IUniTaskAsyncEnumerator<T11> enumerator11;

			private UniTask<bool>.Awaiter awaiter11;

			private bool hasCurrent11;

			private bool running11;

			private T11 current11;

			private IUniTaskAsyncEnumerator<T12> enumerator12;

			private UniTask<bool>.Awaiter awaiter12;

			private bool hasCurrent12;

			private bool running12;

			private T12 current12;

			private IUniTaskAsyncEnumerator<T13> enumerator13;

			private UniTask<bool>.Awaiter awaiter13;

			private bool hasCurrent13;

			private bool running13;

			private T13 current13;

			private IUniTaskAsyncEnumerator<T14> enumerator14;

			private UniTask<bool>.Awaiter awaiter14;

			private bool hasCurrent14;

			private bool running14;

			private T14 current14;

			private IUniTaskAsyncEnumerator<T15> enumerator15;

			private UniTask<bool>.Awaiter awaiter15;

			private bool hasCurrent15;

			private bool running15;

			private T15 current15;

			private int completedCount;

			private bool syncRunning;

			private TResult result;

			public TResult Current => default(TResult);

			public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, IUniTaskAsyncEnumerable<T15> source15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void Completed1(object state)
			{
			}

			private static void Completed2(object state)
			{
			}

			private static void Completed3(object state)
			{
			}

			private static void Completed4(object state)
			{
			}

			private static void Completed5(object state)
			{
			}

			private static void Completed6(object state)
			{
			}

			private static void Completed7(object state)
			{
			}

			private static void Completed8(object state)
			{
			}

			private static void Completed9(object state)
			{
			}

			private static void Completed10(object state)
			{
			}

			private static void Completed11(object state)
			{
			}

			private static void Completed12(object state)
			{
			}

			private static void Completed13(object state)
			{
			}

			private static void Completed14(object state)
			{
			}

			private static void Completed15(object state)
			{
			}

			private bool TrySetResult()
			{
				return false;
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly IUniTaskAsyncEnumerable<T6> source6;

		private readonly IUniTaskAsyncEnumerable<T7> source7;

		private readonly IUniTaskAsyncEnumerable<T8> source8;

		private readonly IUniTaskAsyncEnumerable<T9> source9;

		private readonly IUniTaskAsyncEnumerable<T10> source10;

		private readonly IUniTaskAsyncEnumerable<T11> source11;

		private readonly IUniTaskAsyncEnumerable<T12> source12;

		private readonly IUniTaskAsyncEnumerable<T13> source13;

		private readonly IUniTaskAsyncEnumerable<T14> source14;

		private readonly IUniTaskAsyncEnumerable<T15> source15;

		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector;

		public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, IUniTaskAsyncEnumerable<T6> source6, IUniTaskAsyncEnumerable<T7> source7, IUniTaskAsyncEnumerable<T8> source8, IUniTaskAsyncEnumerable<T9> source9, IUniTaskAsyncEnumerable<T10> source10, IUniTaskAsyncEnumerable<T11> source11, IUniTaskAsyncEnumerable<T12> source12, IUniTaskAsyncEnumerable<T13> source13, IUniTaskAsyncEnumerable<T14> source14, IUniTaskAsyncEnumerable<T15> source15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
