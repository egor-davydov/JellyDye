using System;
using System.Threading;
using Cysharp.Threading.Tasks.Internal;

namespace Cysharp.Threading.Tasks
{
	public static class UniTaskObservableExtensions
	{
		private class ToUniTaskObserver<T> : IObserver<T>
		{
			private static readonly Action<object> callback;

			private readonly UniTaskCompletionSource<T> promise;

			private readonly SingleAssignmentDisposable disposable;

			private readonly CancellationToken cancellationToken;

			private readonly CancellationTokenRegistration registration;

			private bool hasValue;

			private T latestValue;

			public ToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
			{
			}

			private static void OnCanceled(object state)
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnCompleted()
			{
			}
		}

		private class FirstValueToUniTaskObserver<T> : IObserver<T>
		{
			private static readonly Action<object> callback;

			private readonly UniTaskCompletionSource<T> promise;

			private readonly SingleAssignmentDisposable disposable;

			private readonly CancellationToken cancellationToken;

			private readonly CancellationTokenRegistration registration;

			private bool hasValue;

			public FirstValueToUniTaskObserver(UniTaskCompletionSource<T> promise, SingleAssignmentDisposable disposable, CancellationToken cancellationToken)
			{
			}

			private static void OnCanceled(object state)
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnCompleted()
			{
			}
		}

		private class ReturnObservable<T> : IObservable<T>
		{
			private readonly T value;

			public ReturnObservable(T value)
			{
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		private class ThrowObservable<T> : IObservable<T>
		{
			private readonly Exception value;

			public ThrowObservable(Exception value)
			{
			}

			public IDisposable Subscribe(IObserver<T> observer)
			{
				return null;
			}
		}

		public static UniTask<T> ToUniTask<T>(this IObservable<T> source, bool useFirstValue = false, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static IObservable<T> ToObservable<T>(this UniTask<T> task)
		{
			return null;
		}

		public static IObservable<AsyncUnit> ToObservable(this UniTask task)
		{
			return null;
		}

		private static UniTaskVoid Fire<T>(AsyncSubject<T> subject, UniTask<T> task)
		{
			return default(UniTaskVoid);
		}

		private static UniTaskVoid Fire(AsyncSubject<AsyncUnit> subject, UniTask task)
		{
			return default(UniTaskVoid);
		}
	}
}
