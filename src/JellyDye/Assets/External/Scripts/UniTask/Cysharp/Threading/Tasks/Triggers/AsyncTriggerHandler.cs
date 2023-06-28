using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.ParticleSystemJobs;

namespace Cysharp.Threading.Tasks.Triggers
{
	public sealed class AsyncTriggerHandler<T> : IAsyncOneShotTrigger, IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, IDisposable, IAsyncFixedUpdateHandler, IAsyncLateUpdateHandler, IAsyncOnAnimatorIKHandler, IAsyncOnAnimatorMoveHandler, IAsyncOnApplicationFocusHandler, IAsyncOnApplicationPauseHandler, IAsyncOnApplicationQuitHandler, IAsyncOnAudioFilterReadHandler, IAsyncOnBecameInvisibleHandler, IAsyncOnBecameVisibleHandler, IAsyncOnBeforeTransformParentChangedHandler, IAsyncOnCanvasGroupChangedHandler, IAsyncOnCollisionEnterHandler, IAsyncOnCollisionEnter2DHandler, IAsyncOnCollisionExitHandler, IAsyncOnCollisionExit2DHandler, IAsyncOnCollisionStayHandler, IAsyncOnCollisionStay2DHandler, IAsyncOnControllerColliderHitHandler, IAsyncOnDisableHandler, IAsyncOnDrawGizmosHandler, IAsyncOnDrawGizmosSelectedHandler, IAsyncOnEnableHandler, IAsyncOnGUIHandler, IAsyncOnJointBreakHandler, IAsyncOnJointBreak2DHandler, IAsyncOnParticleCollisionHandler, IAsyncOnParticleSystemStoppedHandler, IAsyncOnParticleTriggerHandler, IAsyncOnParticleUpdateJobScheduledHandler, IAsyncOnPostRenderHandler, IAsyncOnPreCullHandler, IAsyncOnPreRenderHandler, IAsyncOnRectTransformDimensionsChangeHandler, IAsyncOnRectTransformRemovedHandler, IAsyncOnRenderImageHandler, IAsyncOnRenderObjectHandler, IAsyncOnServerInitializedHandler, IAsyncOnTransformChildrenChangedHandler, IAsyncOnTransformParentChangedHandler, IAsyncOnTriggerEnterHandler, IAsyncOnTriggerEnter2DHandler, IAsyncOnTriggerExitHandler, IAsyncOnTriggerExit2DHandler, IAsyncOnTriggerStayHandler, IAsyncOnTriggerStay2DHandler, IAsyncOnValidateHandler, IAsyncOnWillRenderObjectHandler, IAsyncResetHandler, IAsyncUpdateHandler, IAsyncOnBeginDragHandler, IAsyncOnCancelHandler, IAsyncOnDeselectHandler, IAsyncOnDragHandler, IAsyncOnDropHandler, IAsyncOnEndDragHandler, IAsyncOnInitializePotentialDragHandler, IAsyncOnMoveHandler, IAsyncOnPointerClickHandler, IAsyncOnPointerDownHandler, IAsyncOnPointerEnterHandler, IAsyncOnPointerExitHandler, IAsyncOnPointerUpHandler, IAsyncOnScrollHandler, IAsyncOnSelectHandler, IAsyncOnSubmitHandler, IAsyncOnUpdateSelectedHandler
	{
		private static Action<object> cancellationCallback;

		private readonly AsyncTriggerBase<T> trigger;

		private CancellationToken cancellationToken;

		private CancellationTokenRegistration registration;

		private bool isDisposed;

		private bool callOnce;

		private UniTaskCompletionSourceCore<T> core;

		internal CancellationToken CancellationToken => default(CancellationToken);

		private ITriggerHandler<T> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EPrev
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

		private ITriggerHandler<T> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002ENext
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

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOneShotTrigger_002EOneShotAsync()
		{
			return default(UniTask);
		}

		internal AsyncTriggerHandler(AsyncTriggerBase<T> trigger, bool callOnce)
		{
		}

		internal AsyncTriggerHandler(AsyncTriggerBase<T> trigger, CancellationToken cancellationToken, bool callOnce)
		{
		}

		private static void CancellationCallback(object state)
		{
		}

		public void Dispose()
		{
		}

		private T Cysharp_002EThreading_002ETasks_002EIUniTaskSource_003CT_003E_002EGetResult(short token)
		{
			return default(T);
		}

		private void Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EOnNext(T value)
		{
		}

		private void Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EOnCanceled(CancellationToken cancellationToken)
		{
		}

		private void Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EOnCompleted()
		{
		}

		private void Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EOnError(Exception ex)
		{
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

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncFixedUpdateHandler_002EFixedUpdateAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncLateUpdateHandler_002ELateUpdateAsync()
		{
			return default(UniTask);
		}

		private UniTask<int> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnAnimatorIKHandler_002EOnAnimatorIKAsync()
		{
			return default(UniTask<int>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnAnimatorMoveHandler_002EOnAnimatorMoveAsync()
		{
			return default(UniTask);
		}

		private UniTask<bool> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnApplicationFocusHandler_002EOnApplicationFocusAsync()
		{
			return default(UniTask<bool>);
		}

		private UniTask<bool> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnApplicationPauseHandler_002EOnApplicationPauseAsync()
		{
			return default(UniTask<bool>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnApplicationQuitHandler_002EOnApplicationQuitAsync()
		{
			return default(UniTask);
		}

		private UniTask<(float[], int)> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnAudioFilterReadHandler_002EOnAudioFilterReadAsync()
		{
			return default(UniTask<(float[], int)>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnBecameInvisibleHandler_002EOnBecameInvisibleAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnBecameVisibleHandler_002EOnBecameVisibleAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnBeforeTransformParentChangedHandler_002EOnBeforeTransformParentChangedAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCanvasGroupChangedHandler_002EOnCanvasGroupChangedAsync()
		{
			return default(UniTask);
		}

		private UniTask<Collision> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionEnterHandler_002EOnCollisionEnterAsync()
		{
			return default(UniTask<Collision>);
		}

		private UniTask<Collision2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionEnter2DHandler_002EOnCollisionEnter2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		private UniTask<Collision> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionExitHandler_002EOnCollisionExitAsync()
		{
			return default(UniTask<Collision>);
		}

		private UniTask<Collision2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionExit2DHandler_002EOnCollisionExit2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		private UniTask<Collision> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionStayHandler_002EOnCollisionStayAsync()
		{
			return default(UniTask<Collision>);
		}

		private UniTask<Collision2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCollisionStay2DHandler_002EOnCollisionStay2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		private UniTask<ControllerColliderHit> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnControllerColliderHitHandler_002EOnControllerColliderHitAsync()
		{
			return default(UniTask<ControllerColliderHit>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDisableHandler_002EOnDisableAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDrawGizmosHandler_002EOnDrawGizmosAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDrawGizmosSelectedHandler_002EOnDrawGizmosSelectedAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnEnableHandler_002EOnEnableAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnGUIHandler_002EOnGUIAsync()
		{
			return default(UniTask);
		}

		private UniTask<float> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnJointBreakHandler_002EOnJointBreakAsync()
		{
			return default(UniTask<float>);
		}

		private UniTask<Joint2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnJointBreak2DHandler_002EOnJointBreak2DAsync()
		{
			return default(UniTask<Joint2D>);
		}

		private UniTask<GameObject> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnParticleCollisionHandler_002EOnParticleCollisionAsync()
		{
			return default(UniTask<GameObject>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnParticleSystemStoppedHandler_002EOnParticleSystemStoppedAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnParticleTriggerHandler_002EOnParticleTriggerAsync()
		{
			return default(UniTask);
		}

		private UniTask<ParticleSystemJobData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnParticleUpdateJobScheduledHandler_002EOnParticleUpdateJobScheduledAsync()
		{
			return default(UniTask<ParticleSystemJobData>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPostRenderHandler_002EOnPostRenderAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPreCullHandler_002EOnPreCullAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPreRenderHandler_002EOnPreRenderAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnRectTransformDimensionsChangeHandler_002EOnRectTransformDimensionsChangeAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnRectTransformRemovedHandler_002EOnRectTransformRemovedAsync()
		{
			return default(UniTask);
		}

		private UniTask<(RenderTexture, RenderTexture)> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnRenderImageHandler_002EOnRenderImageAsync()
		{
			return default(UniTask<(RenderTexture, RenderTexture)>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnRenderObjectHandler_002EOnRenderObjectAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnServerInitializedHandler_002EOnServerInitializedAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTransformChildrenChangedHandler_002EOnTransformChildrenChangedAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTransformParentChangedHandler_002EOnTransformParentChangedAsync()
		{
			return default(UniTask);
		}

		private UniTask<Collider> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerEnterHandler_002EOnTriggerEnterAsync()
		{
			return default(UniTask<Collider>);
		}

		private UniTask<Collider2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerEnter2DHandler_002EOnTriggerEnter2DAsync()
		{
			return default(UniTask<Collider2D>);
		}

		private UniTask<Collider> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerExitHandler_002EOnTriggerExitAsync()
		{
			return default(UniTask<Collider>);
		}

		private UniTask<Collider2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerExit2DHandler_002EOnTriggerExit2DAsync()
		{
			return default(UniTask<Collider2D>);
		}

		private UniTask<Collider> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerStayHandler_002EOnTriggerStayAsync()
		{
			return default(UniTask<Collider>);
		}

		private UniTask<Collider2D> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnTriggerStay2DHandler_002EOnTriggerStay2DAsync()
		{
			return default(UniTask<Collider2D>);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnValidateHandler_002EOnValidateAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnWillRenderObjectHandler_002EOnWillRenderObjectAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncResetHandler_002EResetAsync()
		{
			return default(UniTask);
		}

		private UniTask Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncUpdateHandler_002EUpdateAsync()
		{
			return default(UniTask);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnBeginDragHandler_002EOnBeginDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<BaseEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnCancelHandler_002EOnCancelAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		private UniTask<BaseEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDeselectHandler_002EOnDeselectAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDragHandler_002EOnDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnDropHandler_002EOnDropAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnEndDragHandler_002EOnEndDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnInitializePotentialDragHandler_002EOnInitializePotentialDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<AxisEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnMoveHandler_002EOnMoveAsync()
		{
			return default(UniTask<AxisEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPointerClickHandler_002EOnPointerClickAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPointerDownHandler_002EOnPointerDownAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPointerEnterHandler_002EOnPointerEnterAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPointerExitHandler_002EOnPointerExitAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnPointerUpHandler_002EOnPointerUpAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<PointerEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnScrollHandler_002EOnScrollAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		private UniTask<BaseEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnSelectHandler_002EOnSelectAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		private UniTask<BaseEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnSubmitHandler_002EOnSubmitAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		private UniTask<BaseEventData> Cysharp_002EThreading_002ETasks_002ETriggers_002EIAsyncOnUpdateSelectedHandler_002EOnUpdateSelectedAsync()
		{
			return default(UniTask<BaseEventData>);
		}
	}
}
