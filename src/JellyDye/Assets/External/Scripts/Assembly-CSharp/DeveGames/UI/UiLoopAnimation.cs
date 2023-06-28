using DG.Tweening;
using UnityEngine;

namespace DeveGames.UI
{
	public class UiLoopAnimation : MonoBehaviour
	{
		[SerializeField]
		private float _scaleMultiplier;

		[SerializeField]
		private Ease _ease;

		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _delay;

		private Vector3 _initialLocalScale;

		private Tween _tween;

		private UiPressAnimation _pressAnimation;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Stop()
		{
		}

		public void Play(bool shouldUseDelay = true)
		{
		}
	}
}
