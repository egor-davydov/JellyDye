using UnityEngine;

namespace Core.Helper
{
	public class CameraAndLightPlacer : MonoBehaviour
	{
		[SerializeField]
		private Transform _cameraTransform;

		[SerializeField]
		private float _cameraFieldOfView;

		[SerializeField]
		private Transform _lightTransform;

		[SerializeField]
		private Color _lightColor;

		[SerializeField]
		private float _lightIntensity;

		[SerializeField]
		private float _shadowStrength;

		private void OnEnable()
		{
		}

		private void SetupCameraAndLight()
		{
		}
	}
}
