using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace Cysharp.Threading.Tasks
{
	public static class UniTaskExtensions
	{
		private sealed class AttachExternalCancellationSource : IUniTaskSource
		{
			private static readonly Action<object> cancellationCallbackDelegate;

			private CancellationToken cancellationToken;

			private CancellationTokenRegistration tokenRegistration;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public AttachExternalCancellationSource(UniTask task, CancellationToken cancellationToken)
			{
			}

			private UniTaskVoid RunTask(UniTask task)
			{
				return default(UniTaskVoid);
			}

			private static void CancellationCallback(object state)
			{
			}

			public void GetResult(short token)
			{
			}

			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}
		}

		private sealed class AttachExternalCancellationSource<T> : IUniTaskSource<T>, IUniTaskSource
		{
			private static readonly Action<object> cancellationCallbackDelegate;

			private CancellationToken cancellationToken;

			private CancellationTokenRegistration tokenRegistration;

			private UniTaskCompletionSourceCore<T> core;

			public AttachExternalCancellationSource(UniTask<T> task, CancellationToken cancellationToken)
			{
			}

			private UniTaskVoid RunTask(UniTask<T> task)
			{
				return default(UniTaskVoid);
			}

			private static void CancellationCallback(object state)
			{
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}
		}

		private sealed class ToCoroutineEnumerator : IEnumerator
		{
			private bool completed;

			private UniTask task;

			private Action<Exception> exceptionHandler;

			private bool isStarted;

			private ExceptionDispatchInfo exception;

			public object Current => null;

			public ToCoroutineEnumerator(UniTask task, Action<Exception> exceptionHandler)
			{
			}

			private UniTaskVoid RunTask(UniTask task)
			{
				return default(UniTaskVoid);
			}

			public bool MoveNext()
			{
				return false;
			}

			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class ToCoroutineEnumerator<T> : IEnumerator
		{
			private bool completed;

			private Action<T> resultHandler;

			private Action<Exception> exceptionHandler;

			private bool isStarted;

			private UniTask<T> task;

			private object current;

			private ExceptionDispatchInfo exception;

			public object Current => null;

			public ToCoroutineEnumerator(UniTask<T> task, Action<T> resultHandler, Action<Exception> exceptionHandler)
			{
			}

			private UniTaskVoid RunTask(UniTask<T> task)
			{
				return default(UniTaskVoid);
			}

			public bool MoveNext()
			{
				return false;
			}

			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public static UniTask.Awaiter GetAwaiter(this UniTask[] tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this IEnumerable<UniTask> tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask<T[]>.Awaiter GetAwaiter<T>(this UniTask<T>[] tasks)
		{
			return default(UniTask<T[]>.Awaiter);
		}

		public static UniTask<T[]>.Awaiter GetAwaiter<T>(this IEnumerable<UniTask<T>> tasks)
		{
			return default(UniTask<T[]>.Awaiter);
		}

		public static UniTask<(T1, T2)>.Awaiter GetAwaiter<T1, T2>(this (UniTask<T1>, UniTask<T2>) tasks)
		{
			return default(UniTask<(T1, T2)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3)>.Awaiter GetAwaiter<T1, T2, T3>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>) tasks)
		{
			return default(UniTask<(T1, T2, T3)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4)>.Awaiter GetAwaiter<T1, T2, T3, T4>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>, UniTask<T11>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>, UniTask<T11>, UniTask<T12>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>, UniTask<T11>, UniTask<T12>, UniTask<T13>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>, UniTask<T11>, UniTask<T12>, UniTask<T13>, UniTask<T14>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>.Awaiter);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>.Awaiter GetAwaiter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this (UniTask<T1>, UniTask<T2>, UniTask<T3>, UniTask<T4>, UniTask<T5>, UniTask<T6>, UniTask<T7>, UniTask<T8>, UniTask<T9>, UniTask<T10>, UniTask<T11>, UniTask<T12>, UniTask<T13>, UniTask<T14>, UniTask<T15>) tasks)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask.Awaiter GetAwaiter(this (UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask, UniTask) tasks)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask<T> AsUniTask<T>(this Task<T> task, bool useCurrentSynchronizationContext = true)
		{
			return default(UniTask<T>);
		}

		public static UniTask AsUniTask(this Task task, bool useCurrentSynchronizationContext = true)
		{
			return default(UniTask);
		}

		public static Task<T> AsTask<T>(this UniTask<T> task)
		{
			return null;
		}

		public static Task AsTask(this UniTask task)
		{
			return null;
		}

		public static AsyncLazy ToAsyncLazy(this UniTask task)
		{
			return null;
		}

		public static AsyncLazy<T> ToAsyncLazy<T>(this UniTask<T> task)
		{
			return null;
		}

		public static UniTask AttachExternalCancellation(this UniTask task, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask<T> AttachExternalCancellation<T>(this UniTask<T> task, CancellationToken cancellationToken)
		{
			return default(UniTask<T>);
		}

		public static IEnumerator ToCoroutine<T>(this UniTask<T> task, Action<T> resultHandler = null, Action<Exception> exceptionHandler = null)
		{
			return null;
		}

		public static IEnumerator ToCoroutine(this UniTask task, Action<Exception> exceptionHandler = null)
		{
			return null;
		}

		public static UniTask Timeout(this UniTask task, TimeSpan timeout, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null)
		{
			return default(UniTask);
		}

		public static UniTask<T> Timeout<T>(this UniTask<T> task, TimeSpan timeout, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null)
		{
			return default(UniTask<T>);
		}

		public static UniTask<bool> TimeoutWithoutException(this UniTask task, TimeSpan timeout, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null)
		{
			return default(UniTask<bool>);
		}

		public static UniTask<(bool, T)> TimeoutWithoutException<T>(this UniTask<T> task, TimeSpan timeout, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming timeoutCheckTiming = PlayerLoopTiming.Update, CancellationTokenSource taskCancellationTokenSource = null)
		{
			return default(UniTask<(bool, T)>);
		}

		public static void Forget(this UniTask task)
		{
		}

		public static void Forget(this UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true)
		{
		}

		private static UniTaskVoid ForgetCoreWithCatch(UniTask task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread)
		{
			return default(UniTaskVoid);
		}

		public static void Forget<T>(this UniTask<T> task)
		{
		}

		public static void Forget<T>(this UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread = true)
		{
		}

		private static UniTaskVoid ForgetCoreWithCatch<T>(UniTask<T> task, Action<Exception> exceptionHandler, bool handleExceptionOnMainThread)
		{
			return default(UniTaskVoid);
		}

		public static UniTask ContinueWith<T>(this UniTask<T> task, Action<T> continuationFunction)
		{
			return default(UniTask);
		}

		public static UniTask ContinueWith<T>(this UniTask<T> task, Func<T, UniTask> continuationFunction)
		{
			return default(UniTask);
		}

		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, TR> continuationFunction)
		{
			return default(UniTask<TR>);
		}

		public static UniTask<TR> ContinueWith<T, TR>(this UniTask<T> task, Func<T, UniTask<TR>> continuationFunction)
		{
			return default(UniTask<TR>);
		}

		public static UniTask ContinueWith(this UniTask task, Action continuationFunction)
		{
			return default(UniTask);
		}

		public static UniTask ContinueWith(this UniTask task, Func<UniTask> continuationFunction)
		{
			return default(UniTask);
		}

		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<T> continuationFunction)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> ContinueWith<T>(this UniTask task, Func<UniTask<T>> continuationFunction)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Unwrap<T>(this UniTask<UniTask<T>> task)
		{
			return default(UniTask<T>);
		}

		public static UniTask Unwrap(this UniTask<UniTask> task)
		{
			return default(UniTask);
		}

		public static UniTask<T> Unwrap<T>(this Task<UniTask<T>> task)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Unwrap<T>(this Task<UniTask<T>> task, bool continueOnCapturedContext)
		{
			return default(UniTask<T>);
		}

		public static UniTask Unwrap(this Task<UniTask> task)
		{
			return default(UniTask);
		}

		public static UniTask Unwrap(this Task<UniTask> task, bool continueOnCapturedContext)
		{
			return default(UniTask);
		}

		public static UniTask<T> Unwrap<T>(this UniTask<Task<T>> task)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Unwrap<T>(this UniTask<Task<T>> task, bool continueOnCapturedContext)
		{
			return default(UniTask<T>);
		}

		public static UniTask Unwrap(this UniTask<Task> task)
		{
			return default(UniTask);
		}

		public static UniTask Unwrap(this UniTask<Task> task, bool continueOnCapturedContext)
		{
			return default(UniTask);
		}
	}
}
