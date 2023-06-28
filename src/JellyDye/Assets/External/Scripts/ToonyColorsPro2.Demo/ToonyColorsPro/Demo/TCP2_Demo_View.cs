using UnityEngine;

namespace ToonyColorsPro.Demo
{
	public class TCP2_Demo_View : MonoBehaviour
	{
		public float OrbitStrg;

		public float OrbitClamp;

		public float PanStrg;

		public float PanClamp;

		public float ZoomStrg;

		public float ZoomClamp;

		public float Decceleration;

		public Transform CharacterTransform;

		private Vector3 mouseDelta;

		private Vector3 orbitAcceleration;

		private Vector3 panAcceleration;

		private Vector3 moveAcceleration;

		private float zoomAcceleration;

		private const float XMax = 60f;

		private const float XMin = 300f;

		private Vector3 mResetCamPos;

		private Vector3 mResetCamRot;

		private bool mMouseDown;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void ResetView()
		{
		}
	}
}
