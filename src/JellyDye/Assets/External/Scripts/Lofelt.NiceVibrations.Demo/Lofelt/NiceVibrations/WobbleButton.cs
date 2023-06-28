using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class WobbleButton : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
	{
		public Camera TargetCamera;

		public AudioSource SpringAudioSource;

		public Animator TargetAnimator;

		public HapticSource SpringHapticSource;

		public Image TargetModel;

		public float OffDuration;

		public float MaxRange;

		public AnimationCurve WobbleCurve;

		public float DragResetDuration;

		public float WobbleFactor;

		protected Vector3 _neutralPosition;

		protected Canvas _canvas;

		protected Vector3 _newTargetPosition;

		protected Vector3 _eventPosition;

		protected Vector2 _workPosition;

		protected float _initialZPosition;

		protected bool _dragging;

		protected int _pointerID;

		protected PointerEventData _pointerEventData;

		protected RectTransform _rectTransform;

		protected Vector3 _dragEndedPosition;

		protected float _dragEndedAt;

		protected Vector3 _dragResetDirection;

		protected bool _pointerOn;

		protected bool _draggedOnce;

		protected int _sparkAnimationParameter;

		protected long[] _wobbleAndroidPattern;

		protected int[] _wobbleAndroidAmplitude;

		public RenderMode ParentCanvasRenderMode
		{
			[CompilerGenerated]
			get
			{
				return default(RenderMode);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Start()
		{
		}

		public virtual void SetPitch(float newPitch)
		{
		}

		public virtual void Initialization()
		{
		}

		public virtual void SetNeutralPosition()
		{
		}

		protected virtual Vector3 GetWorldPosition(Vector3 testPosition)
		{
			return default(Vector3);
		}

		protected virtual void Update()
		{
		}

		protected virtual void StickToPointer()
		{
		}

		protected virtual void GoBackToInitialPosition()
		{
		}

		public virtual void OnPointerEnter(PointerEventData data)
		{
		}

		public virtual void OnPointerExit(PointerEventData data)
		{
		}

		protected virtual float Remap(float x, float A, float B, float C, float D)
		{
			return 0f;
		}
	}
}
