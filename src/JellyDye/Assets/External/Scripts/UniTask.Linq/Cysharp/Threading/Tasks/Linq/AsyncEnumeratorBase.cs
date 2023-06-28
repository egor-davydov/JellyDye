using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal abstract class AsyncEnumeratorBase<TSource, TResult> : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		private static readonly Action<object> moveNextCallbackDelegate;

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		protected CancellationToken cancellationToken;

		private IUniTaskAsyncEnumerator<TSource> enumerator;

		private UniTask<bool>.Awaiter sourceMoveNext;

		protected TSource SourceCurrent => default(TSource);

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

		public AsyncEnumeratorBase(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
		}

		protected abstract bool TryMoveNextCore(bool sourceHasCurrent, out bool result);

		public UniTask<bool> MoveNextAsync()
		{
			return default(UniTask<bool>);
		}

		protected virtual bool OnFirstIteration()
		{
			return false;
		}

		protected void SourceMoveNext()
		{
		}

		private static void MoveNextCallBack(object state)
		{
		}

		public virtual UniTask DisposeAsync()
		{
			return default(UniTask);
		}
	}
}
