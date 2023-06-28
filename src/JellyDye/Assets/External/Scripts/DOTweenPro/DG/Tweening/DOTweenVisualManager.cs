using DG.Tweening.Core;
using UnityEngine;

namespace DG.Tweening
{
	public class DOTweenVisualManager : MonoBehaviour
	{
		public VisualManagerPreset preset;

		public OnEnableBehaviour onEnableBehaviour;

		public OnDisableBehaviour onDisableBehaviour;

		private bool _requiresRestartFromSpawnPoint;

		private ABSAnimationComponent _animComponent;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
