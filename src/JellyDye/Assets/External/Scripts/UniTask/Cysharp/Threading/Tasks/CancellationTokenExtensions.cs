using System;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public static class CancellationTokenExtensions
	{
		private static readonly Action<object> cancellationTokenCallback;

		private static readonly Action<object> disposeCallback;

		public static CancellationToken ToCancellationToken(this UniTask task)
		{
			return default(CancellationToken);
		}

		public static CancellationToken ToCancellationToken(this UniTask task, CancellationToken linkToken)
		{
			return default(CancellationToken);
		}

		public static CancellationToken ToCancellationToken<T>(this UniTask<T> task)
		{
			return default(CancellationToken);
		}

		public static CancellationToken ToCancellationToken<T>(this UniTask<T> task, CancellationToken linkToken)
		{
			return default(CancellationToken);
		}

		private static UniTaskVoid ToCancellationTokenCore(UniTask task, CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		public static (UniTask, CancellationTokenRegistration) ToUniTask(this CancellationToken cancellationToken)
		{
			return default((UniTask, CancellationTokenRegistration));
		}

		private static void Callback(object state)
		{
		}

		public static CancellationTokenAwaitable WaitUntilCanceled(this CancellationToken cancellationToken)
		{
			return default(CancellationTokenAwaitable);
		}

		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action callback)
		{
			return default(CancellationTokenRegistration);
		}

		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state)
		{
			return default(CancellationTokenRegistration);
		}

		public static CancellationTokenRegistration AddTo(this IDisposable disposable, CancellationToken cancellationToken)
		{
			return default(CancellationTokenRegistration);
		}

		private static void DisposeCallback(object state)
		{
		}
	}
}
