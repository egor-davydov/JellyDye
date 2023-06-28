using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class EveryValueChangedStandardObject<TTarget, TProperty> : IUniTaskAsyncEnumerable<TProperty> where TTarget : class
	{
		private sealed class _EveryValueChanged : MoveNextSource, IUniTaskAsyncEnumerator<TProperty>, IUniTaskAsyncDisposable, IPlayerLoopItem
		{
			private readonly WeakReference<TTarget> target;

			private readonly IEqualityComparer<TProperty> equalityComparer;

			private readonly Func<TTarget, TProperty> propertySelector;

			private CancellationToken cancellationToken;

			private bool first;

			private TProperty currentValue;

			private bool disposed;

			public TProperty Current => default(TProperty);

			public _EveryValueChanged(WeakReference<TTarget> target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		private readonly WeakReference<TTarget> target;

		private readonly Func<TTarget, TProperty> propertySelector;

		private readonly IEqualityComparer<TProperty> equalityComparer;

		private readonly PlayerLoopTiming monitorTiming;

		public EveryValueChangedStandardObject(TTarget target, Func<TTarget, TProperty> propertySelector, IEqualityComparer<TProperty> equalityComparer, PlayerLoopTiming monitorTiming)
		{
		}

		public IUniTaskAsyncEnumerator<TProperty> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
