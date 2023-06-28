using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;

namespace DeveGames.UI
{
	public class UIShinePlayer : MonoBehaviour
	{
		[SerializeField]
		private UIShiny _uiShiny;

		[SerializeField]
		private bool _playOnAwake;

		[SerializeField]
		private float _loopDuration;

		[SerializeField]
		private float _delayBetweenLoop;

		private Tweener _playTweener;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
