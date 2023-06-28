using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Cysharp.Threading.Tasks
{
	public static class UnityAsyncExtensions
	{
		public struct AssetBundleRequestAllAssetsAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private AssetBundleRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public AssetBundleRequestAllAssetsAwaiter(AssetBundleRequest asyncOperation)
			{
			}

			public AssetBundleRequestAllAssetsAwaiter GetAwaiter()
			{
				return default(AssetBundleRequestAllAssetsAwaiter);
			}

			public UnityEngine.Object[] GetResult()
			{
				return null;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class AssetBundleRequestAllAssetsConfiguredSource : IUniTaskSource<UnityEngine.Object[]>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleRequestAllAssetsConfiguredSource>
		{
			private static TaskPool<AssetBundleRequestAllAssetsConfiguredSource> pool;

			private AssetBundleRequestAllAssetsConfiguredSource nextNode;

			private AssetBundleRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<UnityEngine.Object[]> core;

			public unsafe ref AssetBundleRequestAllAssetsConfiguredSource NextNode => ref *(AssetBundleRequestAllAssetsConfiguredSource*)null;

			static AssetBundleRequestAllAssetsConfiguredSource()
			{
			}

			private AssetBundleRequestAllAssetsConfiguredSource()
			{
			}

			public static IUniTaskSource<UnityEngine.Object[]> Create(AssetBundleRequest asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public UnityEngine.Object[] GetResult(short token)
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

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		private sealed class AsyncGPUReadbackRequestAwaiterConfiguredSource : IUniTaskSource<AsyncGPUReadbackRequest>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncGPUReadbackRequestAwaiterConfiguredSource>
		{
			private static TaskPool<AsyncGPUReadbackRequestAwaiterConfiguredSource> pool;

			private AsyncGPUReadbackRequestAwaiterConfiguredSource nextNode;

			private AsyncGPUReadbackRequest asyncOperation;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<AsyncGPUReadbackRequest> core;

			public unsafe ref AsyncGPUReadbackRequestAwaiterConfiguredSource NextNode => ref *(AsyncGPUReadbackRequestAwaiterConfiguredSource*)null;

			static AsyncGPUReadbackRequestAwaiterConfiguredSource()
			{
			}

			private AsyncGPUReadbackRequestAwaiterConfiguredSource()
			{
			}

			public static IUniTaskSource<AsyncGPUReadbackRequest> Create(AsyncGPUReadbackRequest asyncOperation, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public AsyncGPUReadbackRequest GetResult(short token)
			{
				return default(AsyncGPUReadbackRequest);
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

		private sealed class JobHandlePromise : IUniTaskSource, IPlayerLoopItem
		{
			private JobHandle jobHandle;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public static JobHandlePromise Create(JobHandle jobHandle, out short token)
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
		}

		public struct AsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private AsyncOperation asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public AsyncOperationAwaiter(AsyncOperation asyncOperation)
			{
			}

			public void GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class AsyncOperationConfiguredSource : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AsyncOperationConfiguredSource>
		{
			private static TaskPool<AsyncOperationConfiguredSource> pool;

			private AsyncOperationConfiguredSource nextNode;

			private AsyncOperation asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public unsafe ref AsyncOperationConfiguredSource NextNode => ref *(AsyncOperationConfiguredSource*)null;

			static AsyncOperationConfiguredSource()
			{
			}

			private AsyncOperationConfiguredSource()
			{
			}

			public static IUniTaskSource Create(AsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
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

		public struct ResourceRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private ResourceRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public ResourceRequestAwaiter(ResourceRequest asyncOperation)
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class ResourceRequestConfiguredSource : IUniTaskSource<UnityEngine.Object>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<ResourceRequestConfiguredSource>
		{
			private static TaskPool<ResourceRequestConfiguredSource> pool;

			private ResourceRequestConfiguredSource nextNode;

			private ResourceRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<UnityEngine.Object> core;

			public unsafe ref ResourceRequestConfiguredSource NextNode => ref *(ResourceRequestConfiguredSource*)null;

			static ResourceRequestConfiguredSource()
			{
			}

			private ResourceRequestConfiguredSource()
			{
			}

			public static IUniTaskSource<UnityEngine.Object> Create(ResourceRequest asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public UnityEngine.Object GetResult(short token)
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

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		public struct AssetBundleRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private AssetBundleRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public AssetBundleRequestAwaiter(AssetBundleRequest asyncOperation)
			{
			}

			public UnityEngine.Object GetResult()
			{
				return null;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class AssetBundleRequestConfiguredSource : IUniTaskSource<UnityEngine.Object>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleRequestConfiguredSource>
		{
			private static TaskPool<AssetBundleRequestConfiguredSource> pool;

			private AssetBundleRequestConfiguredSource nextNode;

			private AssetBundleRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<UnityEngine.Object> core;

			public unsafe ref AssetBundleRequestConfiguredSource NextNode => ref *(AssetBundleRequestConfiguredSource*)null;

			static AssetBundleRequestConfiguredSource()
			{
			}

			private AssetBundleRequestConfiguredSource()
			{
			}

			public static IUniTaskSource<UnityEngine.Object> Create(AssetBundleRequest asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public UnityEngine.Object GetResult(short token)
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

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		public struct AssetBundleCreateRequestAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private AssetBundleCreateRequest asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public AssetBundleCreateRequestAwaiter(AssetBundleCreateRequest asyncOperation)
			{
			}

			public AssetBundle GetResult()
			{
				return null;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class AssetBundleCreateRequestConfiguredSource : IUniTaskSource<AssetBundle>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<AssetBundleCreateRequestConfiguredSource>
		{
			private static TaskPool<AssetBundleCreateRequestConfiguredSource> pool;

			private AssetBundleCreateRequestConfiguredSource nextNode;

			private AssetBundleCreateRequest asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<AssetBundle> core;

			public unsafe ref AssetBundleCreateRequestConfiguredSource NextNode => ref *(AssetBundleCreateRequestConfiguredSource*)null;

			static AssetBundleCreateRequestConfiguredSource()
			{
			}

			private AssetBundleCreateRequestConfiguredSource()
			{
			}

			public static IUniTaskSource<AssetBundle> Create(AssetBundleCreateRequest asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public AssetBundle GetResult(short token)
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

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		public struct UnityWebRequestAsyncOperationAwaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private UnityWebRequestAsyncOperation asyncOperation;

			private Action<AsyncOperation> continuationAction;

			public bool IsCompleted => false;

			public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation)
			{
			}

			public UnityWebRequest GetResult()
			{
				return null;
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private sealed class UnityWebRequestAsyncOperationConfiguredSource : IUniTaskSource<UnityWebRequest>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<UnityWebRequestAsyncOperationConfiguredSource>
		{
			private static TaskPool<UnityWebRequestAsyncOperationConfiguredSource> pool;

			private UnityWebRequestAsyncOperationConfiguredSource nextNode;

			private UnityWebRequestAsyncOperation asyncOperation;

			private IProgress<float> progress;

			private CancellationToken cancellationToken;

			private UniTaskCompletionSourceCore<UnityWebRequest> core;

			public unsafe ref UnityWebRequestAsyncOperationConfiguredSource NextNode => ref *(UnityWebRequestAsyncOperationConfiguredSource*)null;

			static UnityWebRequestAsyncOperationConfiguredSource()
			{
			}

			private UnityWebRequestAsyncOperationConfiguredSource()
			{
			}

			public static IUniTaskSource<UnityWebRequest> Create(UnityWebRequestAsyncOperation asyncOperation, PlayerLoopTiming timing, IProgress<float> progress, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public UnityWebRequest GetResult(short token)
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

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		public static AssetBundleRequestAllAssetsAwaiter AwaitForAllAssets(this AssetBundleRequest asyncOperation)
		{
			return default(AssetBundleRequestAllAssetsAwaiter);
		}

		public static UniTask<UnityEngine.Object[]> AwaitForAllAssets(this AssetBundleRequest asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<UnityEngine.Object[]>);
		}

		public static UniTask<UnityEngine.Object[]> AwaitForAllAssets(this AssetBundleRequest asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<UnityEngine.Object[]>);
		}

		public static UniTask<AsyncGPUReadbackRequest>.Awaiter GetAwaiter(this AsyncGPUReadbackRequest asyncOperation)
		{
			return default(UniTask<AsyncGPUReadbackRequest>.Awaiter);
		}

		public static UniTask<AsyncGPUReadbackRequest> WithCancellation(this AsyncGPUReadbackRequest asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<AsyncGPUReadbackRequest>);
		}

		public static UniTask<AsyncGPUReadbackRequest> ToUniTask(this AsyncGPUReadbackRequest asyncOperation, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<AsyncGPUReadbackRequest>);
		}

		public static UniTask WaitAsync(this JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static UniTask.Awaiter GetAwaiter(this JobHandle jobHandle)
		{
			return default(UniTask.Awaiter);
		}

		public static UniTask ToUniTask(this JobHandle jobHandle, PlayerLoopTiming waitTiming)
		{
			return default(UniTask);
		}

		public static UniTask StartAsyncCoroutine(this MonoBehaviour monoBehaviour, Func<CancellationToken, UniTask> asyncCoroutine)
		{
			return default(UniTask);
		}

		public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation)
		{
			return default(AsyncOperationAwaiter);
		}

		public static UniTask WithCancellation(this AsyncOperation asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static UniTask ToUniTask(this AsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask);
		}

		public static ResourceRequestAwaiter GetAwaiter(this ResourceRequest asyncOperation)
		{
			return default(ResourceRequestAwaiter);
		}

		public static UniTask<UnityEngine.Object> WithCancellation(this ResourceRequest asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static UniTask<UnityEngine.Object> ToUniTask(this ResourceRequest asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static AssetBundleRequestAwaiter GetAwaiter(this AssetBundleRequest asyncOperation)
		{
			return default(AssetBundleRequestAwaiter);
		}

		public static UniTask<UnityEngine.Object> WithCancellation(this AssetBundleRequest asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static UniTask<UnityEngine.Object> ToUniTask(this AssetBundleRequest asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<UnityEngine.Object>);
		}

		public static AssetBundleCreateRequestAwaiter GetAwaiter(this AssetBundleCreateRequest asyncOperation)
		{
			return default(AssetBundleCreateRequestAwaiter);
		}

		public static UniTask<AssetBundle> WithCancellation(this AssetBundleCreateRequest asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<AssetBundle>);
		}

		public static UniTask<AssetBundle> ToUniTask(this AssetBundleCreateRequest asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<AssetBundle>);
		}

		public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation)
		{
			return default(UnityWebRequestAsyncOperationAwaiter);
		}

		public static UniTask<UnityWebRequest> WithCancellation(this UnityWebRequestAsyncOperation asyncOperation, CancellationToken cancellationToken)
		{
			return default(UniTask<UnityWebRequest>);
		}

		public static UniTask<UnityWebRequest> ToUniTask(this UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<UnityWebRequest>);
		}

		public static AsyncUnityEventHandler GetAsyncEventHandler(this UnityEvent unityEvent, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask OnInvokeAsync(this UnityEvent unityEvent, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> OnInvokeAsAsyncEnumerable(this UnityEvent unityEvent, CancellationToken cancellationToken)
		{
			return null;
		}

		public static AsyncUnityEventHandler<T> GetAsyncEventHandler<T>(this UnityEvent<T> unityEvent, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<T> OnInvokeAsync<T>(this UnityEvent<T> unityEvent, CancellationToken cancellationToken)
		{
			return default(UniTask<T>);
		}

		public static IUniTaskAsyncEnumerable<T> OnInvokeAsAsyncEnumerable<T>(this UnityEvent<T> unityEvent, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button)
		{
			return null;
		}

		public static IAsyncClickEventHandler GetAsyncClickEventHandler(this Button button, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask OnClickAsync(this Button button)
		{
			return default(UniTask);
		}

		public static UniTask OnClickAsync(this Button button, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> OnClickAsAsyncEnumerable(this Button button)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<AsyncUnit> OnClickAsAsyncEnumerable(this Button button, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(this Toggle toggle, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle)
		{
			return default(UniTask<bool>);
		}

		public static UniTask<bool> OnValueChangedAsync(this Toggle toggle, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		public static IUniTaskAsyncEnumerable<bool> OnValueChangedAsAsyncEnumerable(this Toggle toggle)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<bool> OnValueChangedAsAsyncEnumerable(this Toggle toggle, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Scrollbar scrollbar, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> OnValueChangedAsync(this Scrollbar scrollbar, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static IUniTaskAsyncEnumerable<float> OnValueChangedAsAsyncEnumerable(this Scrollbar scrollbar)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<float> OnValueChangedAsAsyncEnumerable(this Scrollbar scrollbar, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(this ScrollRect scrollRect, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect)
		{
			return default(UniTask<Vector2>);
		}

		public static UniTask<Vector2> OnValueChangedAsync(this ScrollRect scrollRect, CancellationToken cancellationToken)
		{
			return default(UniTask<Vector2>);
		}

		public static IUniTaskAsyncEnumerable<Vector2> OnValueChangedAsAsyncEnumerable(this ScrollRect scrollRect)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<Vector2> OnValueChangedAsAsyncEnumerable(this ScrollRect scrollRect, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(this Slider slider, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<float> OnValueChangedAsync(this Slider slider)
		{
			return default(UniTask<float>);
		}

		public static UniTask<float> OnValueChangedAsync(this Slider slider, CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		public static IUniTaskAsyncEnumerable<float> OnValueChangedAsAsyncEnumerable(this Slider slider)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<float> OnValueChangedAsAsyncEnumerable(this Slider slider, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField)
		{
			return null;
		}

		public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(this InputField inputField, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<string> OnEndEditAsync(this InputField inputField)
		{
			return default(UniTask<string>);
		}

		public static UniTask<string> OnEndEditAsync(this InputField inputField, CancellationToken cancellationToken)
		{
			return default(UniTask<string>);
		}

		public static IUniTaskAsyncEnumerable<string> OnEndEditAsAsyncEnumerable(this InputField inputField)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<string> OnEndEditAsAsyncEnumerable(this InputField inputField, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<string> GetAsyncValueChangedEventHandler(this InputField inputField)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<string> GetAsyncValueChangedEventHandler(this InputField inputField, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<string> OnValueChangedAsync(this InputField inputField)
		{
			return default(UniTask<string>);
		}

		public static UniTask<string> OnValueChangedAsync(this InputField inputField, CancellationToken cancellationToken)
		{
			return default(UniTask<string>);
		}

		public static IUniTaskAsyncEnumerable<string> OnValueChangedAsAsyncEnumerable(this InputField inputField)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<string> OnValueChangedAsAsyncEnumerable(this InputField inputField, CancellationToken cancellationToken)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown)
		{
			return null;
		}

		public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(this Dropdown dropdown, CancellationToken cancellationToken)
		{
			return null;
		}

		public static UniTask<int> OnValueChangedAsync(this Dropdown dropdown)
		{
			return default(UniTask<int>);
		}

		public static UniTask<int> OnValueChangedAsync(this Dropdown dropdown, CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public static IUniTaskAsyncEnumerable<int> OnValueChangedAsAsyncEnumerable(this Dropdown dropdown)
		{
			return null;
		}

		public static IUniTaskAsyncEnumerable<int> OnValueChangedAsAsyncEnumerable(this Dropdown dropdown, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
