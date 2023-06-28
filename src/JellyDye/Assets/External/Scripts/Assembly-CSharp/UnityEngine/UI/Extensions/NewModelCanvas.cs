using System;
using DG.Tweening;

namespace UnityEngine.UI.Extensions
{
	public class NewModelCanvas : MonoBehaviour
	{
		public static Action OnNewModelScreenClosed;

		[SerializeField]
		private ParticleSystem stars;

		[SerializeField]
		private Button GetButton;

		[SerializeField]
		private Button noThanks;

		private Tween noThanksButtonAppearTween;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetModelScreen()
		{
		}

		public void OnGetNowButtonClicked()
		{
		}

		public void OnLoseItButtonClicked()
		{
		}

		private void Close()
		{
		}
	}
}
