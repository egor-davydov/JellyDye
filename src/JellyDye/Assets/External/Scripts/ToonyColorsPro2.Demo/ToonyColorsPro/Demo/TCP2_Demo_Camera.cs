using UnityEngine;

namespace ToonyColorsPro.Demo
{
	public class TCP2_Demo_Camera : MonoBehaviour
	{
		public Transform Pivot;

		public float OrbitStrg;

		public float OrbitClamp;

		public float PanStrgMin;

		public float PanStrgMax;

		public float ZoomStrg;

		public float ZoomClamp;

		public float ZoomDistMin;

		public float ZoomDistMax;

		public float Decceleration;

		public RectTransform ignoreMouseRect;

		private Vector3 mouseDelta;

		private Vector3 orbitAcceleration;

		private Vector3 panAcceleration;

		private Vector3 moveAcceleration;

		private float zoomAcceleration;

		private float zoomDistance;

		private const float XMax = 60f;

		private const float XMin = 300f;

		private Vector3 mResetCamPos;

		private Vector3 mResetPivotPos;

		private Vector3 mResetCamRot;

		private Vector3 mResetPivotRot;

		private bool leftMouseHeld;

		private bool rightMouseHeld;

		private bool middleMouseHeld;

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
