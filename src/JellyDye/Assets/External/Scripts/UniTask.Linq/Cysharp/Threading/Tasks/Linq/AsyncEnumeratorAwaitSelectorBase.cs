using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal abstract class AsyncEnumeratorAwaitSelectorBase<TSource, TResult, TAwait> : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		private static readonly Action<object> moveNextCallbackDelegate;

		private static readonly Action<object> setCurrentCallbackDelegate;

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		protected CancellationToken cancellationToken;

		private IUniTaskAsyncEnumerator<TSource> enumerator;

		private UniTask<bool>.Awaiter sourceMoveNext;

		private UniTask<TAwait>.Awaiter resultAwaiter;

		protected TSource SourceCurrent
		{
			[CompilerGenerated]
			get
			{
				return default(TSource);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TResult Current
		{
			[CompilerGenerated]
			get
			{
				return default(TResult);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public AsyncEnumeratorAwaitSelectorBase(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
		}

		protected abstract UniTask<TAwait> TransformAsync(TSource sourceCurrent);

		protected abstract bool TrySetCurrentCore(TAwait awaitResult, out bool terminateIteration);

		protected (bool, bool) ActionCompleted(bool trySetCurrentResult, out bool moveNextResult)
		{
			moveNextResult = default(bool);
			return default((bool, bool));
		}

		protected (bool, bool) WaitAwaitCallback(out bool moveNextResult)
		{
			moveNextResult = default(bool);
			return default((bool, bool));
		}

		protected (bool, bool) IterateFinished(out bool moveNextResult)
		{
			moveNextResult = default(bool);
			return default((bool, bool));
		}

		public UniTask<bool> MoveNextAsync()
		{
			return default(UniTask<bool>);
		}

		protected void SourceMoveNext()
		{
		}

		private (bool, bool) TryMoveNextCore(bool sourceHasCurrent, out bool result)
		{
			result = default(bool);
			return default((bool, bool));
		}

		protected bool UnwarapTask(UniTask<TAwait> taskResult, out TAwait result)
		{
			result = default(TAwait);
			return false;
		}

		private static void MoveNextCallBack(object state)
		{
		}

		private static void SetCurrentCallBack(object state)
		{
		}

		public virtual UniTask DisposeAsync()
		{
			return default(UniTask);
		}
	}
}
