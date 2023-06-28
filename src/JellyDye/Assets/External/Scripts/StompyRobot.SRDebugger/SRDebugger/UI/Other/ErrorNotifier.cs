using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class ErrorNotifier : MonoBehaviour
	{
		private const float DisplayTime = 6f;

		[SerializeField]
		private Animator _animator;

		private int _triggerHash;

		private float _hideTime;

		public bool IsVisible => false;

		private void Awake()
		{
		}

		public void ShowErrorWarning()
		{
		}

		private void Update()
		{
		}
	}
}
