using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DeveGames.UI
{
	public class UiPressAnimation : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[SerializeField]
		private float _downScaleMultiplier;

		[SerializeField]
		private float _downDuration;

		[SerializeField]
		private float _upDuration;

		[SerializeField]
		private Ease _downEase;

		[SerializeField]
		private Ease _upEase;

		private Vector3 _initialLocalScale;

		private Tween _tween;

		private UiLoopAnimation _loopAnimation;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
