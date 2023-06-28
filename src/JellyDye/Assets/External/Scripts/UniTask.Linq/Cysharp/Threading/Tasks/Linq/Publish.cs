using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Publish<TSource> : IConnectableUniTaskAsyncEnumerable<TSource>, IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class ConnectDisposable : IDisposable
		{
			private readonly CancellationTokenSource cancellationTokenSource;

			public ConnectDisposable(CancellationTokenSource cancellationTokenSource)
			{
			}

			public void Dispose()
			{
			}
		}

		private sealed class _Publish : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable, ITriggerHandler<TSource>
		{
			private static readonly Action<object> CancelDelegate;

			private readonly Publish<TSource> parent;

			private CancellationToken cancellationToken;

			private CancellationTokenRegistration cancellationTokenRegistration;

			private bool isDisposed;

			public TSource Current
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

			private ITriggerHandler<TSource> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CTSource_003E_002EPrev
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			private ITriggerHandler<TSource> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CTSource_003E_002ENext
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public _Publish(Publish<TSource> parent, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void OnCanceled(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}

			public void OnNext(TSource value)
			{
			}

			public void OnCanceled(CancellationToken cancellationToken)
			{
			}

			public void OnCompleted()
			{
			}

			public void OnError(Exception ex)
			{
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly CancellationTokenSource cancellationTokenSource;

		private TriggerEvent<TSource> trigger;

		private IUniTaskAsyncEnumerator<TSource> enumerator;

		private IDisposable connectedDisposable;

		private bool isCompleted;

		public Publish(IUniTaskAsyncEnumerable<TSource> source)
		{
		}

		public IDisposable Connect()
		{
			return null;
		}

		private UniTaskVoid ConsumeEnumerator()
		{
			return default(UniTaskVoid);
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
