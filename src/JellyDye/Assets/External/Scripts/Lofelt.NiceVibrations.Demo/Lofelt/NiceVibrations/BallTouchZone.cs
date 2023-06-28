using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Lofelt.NiceVibrations
{
	public class BallTouchZone : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
	{
		public RectTransform BallMover;

		protected bool _holding;

		protected PointerEventData _pointerEventData;

		protected Vector3 _newPosition;

		protected Canvas _canvas;

		protected float _initialZPosition;

		protected Vector2 _workPosition;

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

		protected virtual void Initialization()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual Vector3 GetWorldPosition(Vector3 testPosition)
		{
			return default(Vector3);
		}

		public virtual void OnPointerEnter(PointerEventData data)
		{
		}

		public virtual void OnPointerExit(PointerEventData data)
		{
		}
	}
}
