using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks.Internal;
using UnityEngine;
using UnityEngine.Events;

namespace Cysharp.Threading.Tasks
{
	[StructLayout(3)]
	public readonly struct UniTask
	{
		private sealed class YieldPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<YieldPromise>
		{
			private static TaskPool<YieldPromise> pool;

			private YieldPromise nextNode;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref YieldPromise NextNode => ref *(YieldPromise*)null;

			static YieldPromise()
			{
			}

			private YieldPromise()
			{
			}

			public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class NextFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<NextFramePromise>
		{
			private static TaskPool<NextFramePromise> pool;

			private NextFramePromise nextNode;

			private int frameCount;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public unsafe ref NextFramePromise NextNode => ref *(NextFramePromise*)null;

			static NextFramePromise()
			{
			}

			private NextFramePromise()
			{
			}

			public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class DelayFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayFramePromise>
		{
			private static TaskPool<DelayFramePromise> pool;

			private DelayFramePromise nextNode;

			private int initialFrame;

			private int delayFrameCount;

			private CancellationToken cancellationToken;

			private int currentFrameCount;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public unsafe ref DelayFramePromise NextNode => ref *(DelayFramePromise*)null;

			static DelayFramePromise()
			{
			}

			private DelayFramePromise()
			{
			}

			public static IUniTaskSource Create(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class DelayPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayPromise>
		{
			private static TaskPool<DelayPromise> pool;

			private DelayPromise nextNode;

			private int initialFrame;

			private float delayTimeSpan;

			private float elapsed;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref DelayPromise NextNode => ref *(DelayPromise*)null;

			static DelayPromise()
			{
			}

			private DelayPromise()
			{
			}

			public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class DelayIgnoreTimeScalePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayIgnoreTimeScalePromise>
		{
			private static TaskPool<DelayIgnoreTimeScalePromise> pool;

			private DelayIgnoreTimeScalePromise nextNode;

			private float delayFrameTimeSpan;

			private float elapsed;

			private int initialFrame;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref DelayIgnoreTimeScalePromise NextNode => ref *(DelayIgnoreTimeScalePromise*)null;

			static DelayIgnoreTimeScalePromise()
			{
			}

			private DelayIgnoreTimeScalePromise()
			{
			}

			public static IUniTaskSource Create(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class DelayRealtimePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayRealtimePromise>
		{
			private static TaskPool<DelayRealtimePromise> pool;

			private DelayRealtimePromise nextNode;

			private long delayTimeSpanTicks;

			private ValueStopwatch stopwatch;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public unsafe ref DelayRealtimePromise NextNode => ref *(DelayRealtimePromise*)null;

			static DelayRealtimePromise()
			{
			}

			private DelayRealtimePromise()
			{
			}

			public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private static class CanceledUniTaskCache<T>
		{
			public static readonly UniTask<T> Task;

			static CanceledUniTaskCache()
			{
			}
		}

		private sealed class ExceptionResultSource : IUniTaskSource
		{
			private readonly ExceptionDispatchInfo exception;

			public ExceptionResultSource(Exception exception)
			{
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
		}

		private sealed class ExceptionResultSource<T> : IUniTaskSource<T>, IUniTaskSource
		{
			private readonly ExceptionDispatchInfo exception;

			public ExceptionResultSource(Exception exception)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class CanceledResultSource : IUniTaskSource
		{
			private readonly CancellationToken cancellationToken;

			public CanceledResultSource(CancellationToken cancellationToken)
			{
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
		}

		private sealed class CanceledResultSource<T> : IUniTaskSource<T>, IUniTaskSource
		{
			private readonly CancellationToken cancellationToken;

			public CanceledResultSource(CancellationToken cancellationToken)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class DeferPromise : IUniTaskSource
		{
			private Func<UniTask> factory;

			private UniTask task;

			private Awaiter awaiter;

			public DeferPromise(Func<UniTask> factory)
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

		private sealed class DeferPromise<T> : IUniTaskSource<T>, IUniTaskSource
		{
			private Func<UniTask<T>> factory;

			private UniTask<T> task;

			private UniTask<T>.Awaiter awaiter;

			public DeferPromise(Func<UniTask<T>> factory)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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

		private sealed class NeverPromise<T> : IUniTaskSource<T>, IUniTaskSource
		{
			private static readonly Action<object> cancellationCallback;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<T> core;

			public NeverPromise(CancellationToken cancellationToken)
			{
			}

			private static void CancellationCallback(object state)
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

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WaitUntilPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilPromise>
		{
			private static TaskPool<WaitUntilPromise> pool;

			private WaitUntilPromise nextNode;

			private Func<bool> predicate;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref WaitUntilPromise NextNode => ref *(WaitUntilPromise*)null;

			static WaitUntilPromise()
			{
			}

			private WaitUntilPromise()
			{
			}

			public static IUniTaskSource Create(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class WaitWhilePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitWhilePromise>
		{
			private static TaskPool<WaitWhilePromise> pool;

			private WaitWhilePromise nextNode;

			private Func<bool> predicate;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref WaitWhilePromise NextNode => ref *(WaitWhilePromise*)null;

			static WaitWhilePromise()
			{
			}

			private WaitWhilePromise()
			{
			}

			public static IUniTaskSource Create(Func<bool> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
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
		}

		private sealed class WaitUntilCanceledPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilCanceledPromise>
		{
			private static TaskPool<WaitUntilCanceledPromise> pool;

			private WaitUntilCanceledPromise nextNode;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<object> core;

			public unsafe ref WaitUntilCanceledPromise NextNode => ref *(WaitUntilCanceledPromise*)null;

			static WaitUntilCanceledPromise()
			{
			}

			private WaitUntilCanceledPromise()
			{
			}

			public static IUniTaskSource Create(CancellationToken cancellationToken, PlayerLoopTiming timing, out short token)
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
		}

		private sealed class WaitUntilValueChangedUnityObjectPromise<T, U> : IUniTaskSource<U>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilValueChangedUnityObjectPromise<T, U>>
		{
			private static TaskPool<WaitUntilValueChangedUnityObjectPromise<T, U>> pool;

			private WaitUntilValueChangedUnityObjectPromise<T, U> nextNode;

			private T target;

			private UnityEngine.Object targetAsUnityObject;

			private U currentValue;

			private Func<T, U> monitorFunction;

			private IEqualityComparer<U> equalityComparer;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<U> core;

			public unsafe ref WaitUntilValueChangedUnityObjectPromise<T, U> NextNode => ref *(WaitUntilValueChangedUnityObjectPromise<T, U>*)null;

			static WaitUntilValueChangedUnityObjectPromise()
			{
			}

			private WaitUntilValueChangedUnityObjectPromise()
			{
			}

			public static IUniTaskSource<U> Create(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public U GetResult(short token)
			{
				return default(U);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WaitUntilValueChangedStandardObjectPromise<T, U> : IUniTaskSource<U>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilValueChangedStandardObjectPromise<T, U>> where T : class
		{
			private static TaskPool<WaitUntilValueChangedStandardObjectPromise<T, U>> pool;

			private WaitUntilValueChangedStandardObjectPromise<T, U> nextNode;

			private WeakReference<T> target;

			private U currentValue;

			private Func<T, U> monitorFunction;

			private IEqualityComparer<U> equalityComparer;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<U> core;

			public unsafe ref WaitUntilValueChangedStandardObjectPromise<T, U> NextNode => ref *(WaitUntilValueChangedStandardObjectPromise<T, U>*)null;

			static WaitUntilValueChangedStandardObjectPromise()
			{
			}

			private WaitUntilValueChangedStandardObjectPromise()
			{
			}

			public static IUniTaskSource<U> Create(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public U GetResult(short token)
			{
				return default(U);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2> : IUniTaskSource<(T1, T2)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			public (T1, T2) GetResult(short token)
			{
				return default((T1, T2));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3> : IUniTaskSource<(T1, T2, T3)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3) GetResult(short token)
			{
				return default((T1, T2, T3));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4> : IUniTaskSource<(T1, T2, T3, T4)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4) GetResult(short token)
			{
				return default((T1, T2, T3, T4));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5> : IUniTaskSource<(T1, T2, T3, T4, T5)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6> : IUniTaskSource<(T1, T2, T3, T4, T5, T6)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private T11 t11;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private T11 t11;

			private T12 t12;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private T11 t11;

			private T12 t12;

			private T13 t13;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private T11 t11;

			private T12 t12;

			private T13 t13;

			private T14 t14;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT14(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T14>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IUniTaskSource<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>, IUniTaskSource
		{
			private T1 t1;

			private T2 t2;

			private T3 t3;

			private T4 t4;

			private T5 t5;

			private T6 t6;

			private T7 t7;

			private T8 t8;

			private T9 t9;

			private T10 t10;

			private T11 t11;

			private T12 t12;

			private T13 t13;

			private T14 t14;

			private T15 t15;

			private int completedCount;

			private UniTaskCompletionSourceCore<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> core;

			public WhenAllPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15)
			{
			}

			private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT14(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T14>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT15(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T15>.Awaiter awaiter)
			{
			}

			public (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) GetResult(short token)
			{
				return default((T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15));
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise<T> : IUniTaskSource<T[]>, IUniTaskSource
		{
			private T[] result;

			private int completeCount;

			private UniTaskCompletionSourceCore<T[]> core;

			public WhenAllPromise(UniTask<T>[] tasks, int tasksLength)
			{
			}

			private static void TryInvokeContinuation(WhenAllPromise<T> self, in UniTask<T>.Awaiter awaiter, int i)
			{
			}

			public T[] GetResult(short token)
			{
				return null;
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class WhenAllPromise : IUniTaskSource
		{
			private int completeCount;

			private int tasksLength;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public WhenAllPromise(UniTask[] tasks, int tasksLength)
			{
			}

			private static void TryInvokeContinuation(WhenAllPromise self, in Awaiter awaiter)
			{
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
		}

		private sealed class WhenAnyPromise<T1, T2> : IUniTaskSource<(int, T1, T2)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			public (int, T1, T2) GetResult(short token)
			{
				return default((int, T1, T2));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3> : IUniTaskSource<(int, T1, T2, T3)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3) GetResult(short token)
			{
				return default((int, T1, T2, T3));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4> : IUniTaskSource<(int, T1, T2, T3, T4)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5> : IUniTaskSource<(int, T1, T2, T3, T4, T5)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT14(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in UniTask<T14>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IUniTaskSource<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> core;

			public WhenAnyPromise(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15)
			{
			}

			private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T1>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T2>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T3>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T4>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T5>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T6>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T7>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T8>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T9>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT10(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T10>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT11(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T11>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT12(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T12>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT13(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T13>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT14(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T14>.Awaiter awaiter)
			{
			}

			private static void TryInvokeContinuationT15(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in UniTask<T15>.Awaiter awaiter)
			{
			}

			public (int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) GetResult(short token)
			{
				return default((int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyLRPromise<T> : IUniTaskSource<(bool, T)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(bool, T)> core;

			public WhenAnyLRPromise(UniTask<T> leftTask, UniTask rightTask)
			{
			}

			private static void TryLeftInvokeContinuation(WhenAnyLRPromise<T> self, in UniTask<T>.Awaiter awaiter)
			{
			}

			private static void TryRightInvokeContinuation(WhenAnyLRPromise<T> self, in Awaiter awaiter)
			{
			}

			public (bool, T) GetResult(short token)
			{
				return default((bool, T));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise<T> : IUniTaskSource<(int, T)>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<(int, T)> core;

			public WhenAnyPromise(UniTask<T>[] tasks, int tasksLength)
			{
			}

			private static void TryInvokeContinuation(WhenAnyPromise<T> self, in UniTask<T>.Awaiter awaiter, int i)
			{
			}

			public (int, T) GetResult(short token)
			{
				return default((int, T));
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class WhenAnyPromise : IUniTaskSource<int>, IUniTaskSource
		{
			private int completedCount;

			private UniTaskCompletionSourceCore<int> core;

			public WhenAnyPromise(UniTask[] tasks, int tasksLength)
			{
			}

			private static void TryInvokeContinuation(WhenAnyPromise self, in Awaiter awaiter, int i)
			{
			}

			public int GetResult(short token)
			{
				return 0;
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class AsyncUnitSource : IUniTaskSource<AsyncUnit>, IUniTaskSource
		{
			private readonly IUniTaskSource source;

			public AsyncUnitSource(IUniTaskSource source)
			{
			}

			public AsyncUnit GetResult(short token)
			{
				return default(AsyncUnit);
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

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}
		}

		private sealed class IsCanceledSource : IUniTaskSource<bool>, IUniTaskSource
		{
			private readonly IUniTaskSource source;

			public IsCanceledSource(IUniTaskSource source)
			{
			}

			public bool GetResult(short token)
			{
				return false;
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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
		}

		private sealed class MemoizeSource : IUniTaskSource
		{
			private IUniTaskSource source;

			private ExceptionDispatchInfo exception;

			private UniTaskStatus status;

			public MemoizeSource(IUniTaskSource source)
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

		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly UniTask task;

			public bool IsCompleted
			{
				[MethodImpl(256)]
				[DebuggerHidden]
				get
				{
					return false;
				}
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public Awaiter(in UniTask task)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void GetResult()
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void OnCompleted(Action continuation)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void SourceOnCompleted(Action<object> continuation, object state)
			{
			}
		}

		private static readonly UniTask CanceledUniTask;

		public static readonly UniTask CompletedTask;

		private readonly IUniTaskSource source;

		private readonly short token;

		public UniTaskStatus Status
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return default(UniTaskStatus);
			}
		}

		public static IEnumerator ToCoroutine(Func<UniTask> taskFactory)
		{
			return null;
		}

		public static YieldAwaitable Yield()
		{
			return default(YieldAwaitable);
		}

		public static YieldAwaitable Yield(PlayerLoopTiming timing)
		{
			return default(YieldAwaitable);
		}

		public static UniTask Yield(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask NextFrame()
		{
			return default(UniTask);
		}

		public static UniTask NextFrame(PlayerLoopTiming timing)
		{
			return default(UniTask);
		}

		public static UniTask NextFrame(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask NextFrame(PlayerLoopTiming timing, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static YieldAwaitable WaitForEndOfFrame()
		{
			return default(YieldAwaitable);
		}

		public static UniTask WaitForEndOfFrame(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static YieldAwaitable WaitForFixedUpdate()
		{
			return default(YieldAwaitable);
		}

		public static UniTask WaitForFixedUpdate(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Delay(int millisecondsDelay, DelayType delayType, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask FromException(Exception ex)
		{
			return default(UniTask);
		}

		public static UniTask<T> FromException<T>(Exception ex)
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> FromResult<T>(T value)
		{
			return default(UniTask<T>);
		}

		public static UniTask FromCanceled(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask<T> FromCanceled<T>(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask Create(Func<UniTask> factory)
		{
			return default(UniTask);
		}

		public static UniTask<T> Create<T>(Func<UniTask<T>> factory)
		{
			return default(UniTask<T>);
		}

		public static AsyncLazy Lazy(Func<UniTask> factory)
		{
			return null;
		}

		public static AsyncLazy<T> Lazy<T>(Func<UniTask<T>> factory)
		{
			return null;
		}

		public static void Void(Func<UniTaskVoid> asyncAction)
		{
		}

		public static void Void(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken)
		{
		}

		public static void Void<T>(Func<T, UniTaskVoid> asyncAction, T state)
		{
		}

		public static Action Action(Func<UniTaskVoid> asyncAction)
		{
			return null;
		}

		public static Action Action(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UnityAction UnityAction(Func<UniTaskVoid> asyncAction)
		{
			return null;
		}

		public static UnityAction UnityAction(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask Defer(Func<UniTask> factory)
		{
			return default(UniTask);
		}

		public static UniTask<T> Defer<T>(Func<UniTask<T>> factory)
		{
			return default(UniTask<T>);
		}

		public static UniTask Never(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask<T> Never<T>(CancellationToken cancellationToken)
		{
			return default(UniTask<T>);
		}

		public static UniTask Run(Action action, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Run(Action<object> action, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Run(Func<UniTask> action, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask Run(Func<object, UniTask> action, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask<T> Run<T>(Func<T> func, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Run<T>(Func<UniTask<T>> func, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Run<T>(Func<object, T> func, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> Run<T>(Func<object, UniTask<T>> func, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask RunOnThreadPool(Action action, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask RunOnThreadPool(Action<object> action, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask RunOnThreadPool(Func<UniTask> action, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask RunOnThreadPool(Func<object, UniTask> action, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask<T> RunOnThreadPool<T>(Func<T> func, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> RunOnThreadPool<T>(Func<UniTask<T>> func, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> RunOnThreadPool<T>(Func<object, T> func, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static UniTask<T> RunOnThreadPool<T>(Func<object, UniTask<T>> func, object state, bool configureAwait = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		public static SwitchToMainThreadAwaitable SwitchToMainThread(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(SwitchToMainThreadAwaitable);
		}

		public static SwitchToMainThreadAwaitable SwitchToMainThread(PlayerLoopTiming timing, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(SwitchToMainThreadAwaitable);
		}

		public static ReturnToMainThread ReturnToMainThread(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ReturnToMainThread);
		}

		public static ReturnToMainThread ReturnToMainThread(PlayerLoopTiming timing, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ReturnToMainThread);
		}

		public static void Post(Action action, PlayerLoopTiming timing = PlayerLoopTiming.Update)
		{
		}

		public static SwitchToThreadPoolAwaitable SwitchToThreadPool()
		{
			return default(SwitchToThreadPoolAwaitable);
		}

		public static SwitchToTaskPoolAwaitable SwitchToTaskPool()
		{
			return default(SwitchToTaskPoolAwaitable);
		}

		public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext synchronizationContext, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(SwitchToSynchronizationContextAwaitable);
		}

		public static ReturnToSynchronizationContext ReturnToSynchronizationContext(SynchronizationContext synchronizationContext, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ReturnToSynchronizationContext);
		}

		public static ReturnToSynchronizationContext ReturnToCurrentSynchronizationContext(bool dontPostWhenSameContext = true, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(ReturnToSynchronizationContext);
		}

		public static UniTask WaitUntil(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask WaitWhile(Func<bool> predicate, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask WaitUntilCanceled(CancellationToken cancellationToken, PlayerLoopTiming timing = PlayerLoopTiming.Update)
		{
			return default(UniTask);
		}

		public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = PlayerLoopTiming.Update, IEqualityComparer<U> equalityComparer = null, CancellationToken cancellationToken = default(CancellationToken)) where T : class
		{
			return default(UniTask<U>);
		}

		public static UniTask<(T1, T2)> WhenAll<T1, T2>(UniTask<T1> task1, UniTask<T2> task2)
		{
			return default(UniTask<(T1, T2)>);
		}

		public static UniTask<(T1, T2, T3)> WhenAll<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
		{
			return default(UniTask<(T1, T2, T3)>);
		}

		public static UniTask<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
		{
			return default(UniTask<(T1, T2, T3, T4)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
		{
			return default(UniTask<(T1, T2, T3, T4, T5)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>);
		}

		public static UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15)
		{
			return default(UniTask<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>);
		}

		public static UniTask<T[]> WhenAll<T>(params UniTask<T>[] tasks)
		{
			return default(UniTask<T[]>);
		}

		public static UniTask<T[]> WhenAll<T>(IEnumerable<UniTask<T>> tasks)
		{
			return default(UniTask<T[]>);
		}

		public static UniTask WhenAll(params UniTask[] tasks)
		{
			return default(UniTask);
		}

		public static UniTask WhenAll(IEnumerable<UniTask> tasks)
		{
			return default(UniTask);
		}

		public static UniTask<(int, T1, T2)> WhenAny<T1, T2>(UniTask<T1> task1, UniTask<T2> task2)
		{
			return default(UniTask<(int, T1, T2)>);
		}

		public static UniTask<(int, T1, T2, T3)> WhenAny<T1, T2, T3>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3)
		{
			return default(UniTask<(int, T1, T2, T3)>);
		}

		public static UniTask<(int, T1, T2, T3, T4)> WhenAny<T1, T2, T3, T4>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4)
		{
			return default(UniTask<(int, T1, T2, T3, T4)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5)> WhenAny<T1, T2, T3, T4, T5>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6)> WhenAny<T1, T2, T3, T4, T5, T6>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7)> WhenAny<T1, T2, T3, T4, T5, T6, T7>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>);
		}

		public static UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15)
		{
			return default(UniTask<(int, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>);
		}

		public static UniTask<(bool, T)> WhenAny<T>(UniTask<T> leftTask, UniTask rightTask)
		{
			return default(UniTask<(bool, T)>);
		}

		public static UniTask<(int, T)> WhenAny<T>(params UniTask<T>[] tasks)
		{
			return default(UniTask<(int, T)>);
		}

		public static UniTask<(int, T)> WhenAny<T>(IEnumerable<UniTask<T>> tasks)
		{
			return default(UniTask<(int, T)>);
		}

		public static UniTask<int> WhenAny(params UniTask[] tasks)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> WhenAny(IEnumerable<UniTask> tasks)
		{
			return default(UniTask<int>);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public UniTask(IUniTaskSource source, short token)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask<bool> SuppressCancellationThrow()
		{
			return default(UniTask<bool>);
		}

		public override string ToString()
		{
			return null;
		}

		public UniTask Preserve()
		{
			return default(UniTask);
		}

		public UniTask<AsyncUnit> AsAsyncUnitUniTask()
		{
			return default(UniTask<AsyncUnit>);
		}
	}
	[StructLayout(3)]
	public readonly struct UniTask<T>
	{
		private sealed class IsCanceledSource : IUniTaskSource<(bool, T)>, IUniTaskSource
		{
			private readonly IUniTaskSource<T> source;

			[MethodImpl(256)]
			[DebuggerHidden]
			public IsCanceledSource(IUniTaskSource<T> source)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public (bool, T) GetResult(short token)
			{
				return default((bool, T));
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}
		}

		private sealed class MemoizeSource : IUniTaskSource<T>, IUniTaskSource
		{
			private IUniTaskSource<T> source;

			private T result;

			private ExceptionDispatchInfo exception;

			private UniTaskStatus status;

			public MemoizeSource(IUniTaskSource<T> source)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
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

		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly UniTask<T> task;

			public bool IsCompleted
			{
				[MethodImpl(256)]
				[DebuggerHidden]
				get
				{
					return false;
				}
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public Awaiter(in UniTask<T> task)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public T GetResult()
			{
				return default(T);
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void OnCompleted(Action continuation)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void UnsafeOnCompleted(Action continuation)
			{
			}

			[MethodImpl(256)]
			[DebuggerHidden]
			public void SourceOnCompleted(Action<object> continuation, object state)
			{
			}
		}

		private readonly IUniTaskSource<T> source;

		private readonly T result;

		private readonly short token;

		public UniTaskStatus Status
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return default(UniTaskStatus);
			}
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public UniTask(T result)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public UniTask(IUniTaskSource<T> source, short token)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask<T> Preserve()
		{
			return default(UniTask<T>);
		}

		public UniTask AsUniTask()
		{
			return default(UniTask);
		}

		public static implicit operator UniTask(UniTask<T> self)
		{
			return default(UniTask);
		}

		public UniTask<(bool, T)> SuppressCancellationThrow()
		{
			return default(UniTask<(bool, T)>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
