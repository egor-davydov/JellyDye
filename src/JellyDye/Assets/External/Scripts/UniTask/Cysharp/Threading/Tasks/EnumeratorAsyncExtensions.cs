using System;
using System.Collections;
using System.Reflection;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks
{
	public static class EnumeratorAsyncExtensions
	{
		private sealed class EnumeratorPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<EnumeratorPromise>
		{
			private static TaskPool<EnumeratorPromise> pool;

			private EnumeratorPromise nextNode;

			private IEnumerator innerEnumerator;

			private CancellationToken cancellationToken;

			private int initialFrame;

			private bool loopRunning;

			private bool calledGetResult;

			private UniTaskCompletionSourceCore<object> core;

			private static readonly FieldInfo waitForSeconds_Seconds;

			public unsafe ref EnumeratorPromise NextNode => ref *(EnumeratorPromise*)null;

			static EnumeratorPromise()
			{
			}

			private EnumeratorPromise()
			{
			}

			public static IUniTaskSource Create(IEnumerator innerEnumerator, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public void GetResult(short token)
			{
			}

			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}

			private static IEnumerator ConsumeEnumerator(IEnumerator enumerator)
			{
				return null;
			}

			private static IEnumerator UnwrapWaitForSeconds(WaitForSeconds waitForSeconds)
			{
				return null;
			}

			private static IEnumerator UnwrapWaitAsyncOperation(AsyncOperation asyncOperation)
			{
				return null;
			}
		}

		public static UniTask.Awaiter GetAwaiter<T>(this T enumerator) where T : IEnumerator
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask WithCancellation(this IEnumerator enumerator, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ToUniTask(this IEnumerator enumerator, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask ToUniTask(this IEnumerator enumerator, MonoBehaviour coroutineRunner)
		{
			return default(UniTask);
		}

		private static IEnumerator Core(IEnumerator inner, MonoBehaviour coroutineRunner, AutoResetUniTaskCompletionSource source)
		{
			return null;
		}
	}
}
