using System;
using System.Threading;
using UnityEngine.Events;

namespace Cysharp.Threading.Tasks
{
	public class AsyncUnityEventHandler : IUniTaskSource, IDisposable, IAsyncClickEventHandler
	{
		private static Action<object> cancellationCallback;

		private readonly UnityAction action;

		private readonly UnityEvent unityEvent;

		private CancellationToken cancellationToken;

		private CancellationTokenRegistration registration;

		private bool isDisposed;

		private bool callOnce;

		private UniTaskCompletionSourceCore<AsyncUnit> core;

		public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce)
		{
		}

		public UniTask OnInvokeAsync()
		{
			return default(UniTask);
		}

		private void Invoke()
		{
		}

		private static void CancellationCallback(object state)
		{
		}

		public void Dispose()
		{
		}

		private UniTask Cysharp_002EThreading_002ETasks_002EIAsyncClickEventHandler_002EOnClickAsync()
		{
			return default(UniTask);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
		{
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EUnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EOnCompleted(Action<object> continuation, object state, short token)
		{
		}
	}
	public class AsyncUnityEventHandler<T> : IUniTaskSource<T>, IUniTaskSource, IDisposable, IAsyncValueChangedEventHandler<T>, IAsyncEndEditEventHandler<T>, IAsyncEndTextSelectionEventHandler<T>, IAsyncTextSelectionEventHandler<T>, IAsyncDeselectEventHandler<T>, IAsyncSelectEventHandler<T>, IAsyncSubmitEventHandler<T>
	{
		private static Action<object> cancellationCallback;

		private readonly UnityAction<T> action;

		private readonly UnityEvent<T> unityEvent;

		private CancellationToken cancellationToken;

		private CancellationTokenRegistration registration;

		private bool isDisposed;

		private bool callOnce;

		private UniTaskCompletionSourceCore<T> core;

		public AsyncUnityEventHandler(UnityEvent<T> unityEvent, CancellationToken cancellationToken, bool callOnce)
		{
		}

		public UniTask<T> OnInvokeAsync()
		{
			return default(UniTask<T>);
		}

		private void Invoke(T result)
		{
		}

		private static void CancellationCallback(object state)
		{
		}

		public void Dispose()
		{
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncValueChangedEventHandler_003CT_003E_002EOnValueChangedAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncEndEditEventHandler_003CT_003E_002EOnEndEditAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncEndTextSelectionEventHandler_003CT_003E_002EOnEndTextSelectionAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncTextSelectionEventHandler_003CT_003E_002EOnTextSelectionAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncDeselectEventHandler_003CT_003E_002EOnDeselectAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncSelectEventHandler_003CT_003E_002EOnSelectAsync()
		{
			return default(UniTask<T>);
		}

		private UniTask<T> Cysharp_002EThreading_002ETasks_002EIAsyncSubmitEventHandler_003CT_003E_002EOnSubmitAsync()
		{
			return default(UniTask<T>);
		}

		private T Cysharp_002EThreading_002ETasks_002EIUniTaskSource_003CT_003E_002EGetResult(short token)
		{
			return default(T);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
		{
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EUnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EOnCompleted(Action<object> continuation, object state, short token)
		{
		}
	}
}
