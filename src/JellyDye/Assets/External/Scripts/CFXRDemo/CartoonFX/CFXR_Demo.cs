using System;
using UnityEngine;
using UnityEngine.UI;

namespace CartoonFX
{
	public class CFXR_Demo : MonoBehaviour
	{
		public Image btnSlowMotion;

		public Text lblSlowMotion;

		public Image btnCameraRotation;

		public Text lblCameraRotation;

		public Image btnShowGround;

		public Text lblShowGround;

		public Image btnCamShake;

		public Text lblCamShake;

		public Image btnLights;

		public Text lblLights;

		public Image btnBloom;

		public Text lblBloom;

		[Space]
		public Text labelEffect;

		public Text labelIndex;

		[Space]
		public GameObject ground;

		public Collider groundCollider;

		public Transform demoCamera;

		public MonoBehaviour bloom;

		public float rotationSpeed;

		private bool slowMotion;

		private bool rotateCamera;

		private bool showGround;

		[NonSerialized]
		public GameObject currentEffect;

		private GameObject[] effectsList;

		private int index;

		private Vector3 camInitialPosition;

		private Quaternion camInitialRotation;

		public void NextEffect()
		{
		}

		public void PreviousEffect()
		{
		}

		public void ToggleSlowMo()
		{
		}

		public void ToggleCamera()
		{
		}

		public void ToggleGround()
		{
		}

		public void ToggleCameraShake()
		{
		}

		public void ToggleEffectsLights()
		{
		}

		public void ToggleBloom()
		{
		}

		public void ResetCam()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void PlayAtIndex()
		{
		}

		private void WrapIndex()
		{
		}

		private void UpdateLabels()
		{
		}
	}
}
