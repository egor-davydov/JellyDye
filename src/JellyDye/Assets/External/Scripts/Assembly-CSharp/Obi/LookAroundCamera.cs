using UnityEngine;

namespace Obi
{
	public class LookAroundCamera : MonoBehaviour
	{
		public struct CameraShot
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 up;

			public float fieldOfView;

			public CameraShot(Vector3 position, Quaternion rotation, Vector3 up, float fieldOfView)
			{
			}
		}

		private Camera cam;

		private CameraShot currentShot;

		public float movementSpeed;

		public float rotationSpeed;

		public float translationResponse;

		public float rotationResponse;

		public float fovResponse;

		private void Awake()
		{
		}

		private void LookAt(Vector3 position, Vector3 up)
		{
		}

		private void UpdateShot()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
