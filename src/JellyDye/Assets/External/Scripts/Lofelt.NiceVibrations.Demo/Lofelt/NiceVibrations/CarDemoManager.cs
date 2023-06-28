using System.Collections.Generic;
using UnityEngine;

namespace Lofelt.NiceVibrations
{
	public class CarDemoManager : DemoManager
	{
		public MMKnob Knob;

		public float MinimumKnobValue;

		public float MaximumPowerDuration;

		public float ChargingSpeed;

		public float CarSpeed;

		public float Power;

		public float StartClickDuration;

		public float DentDuration;

		public List<float> Dents;

		public AudioSource CarEngineAudioSource;

		public Transform LeftWheel;

		public Transform RightWheel;

		public RectTransform CarBody;

		public Vector3 WheelRotationSpeed;

		public GameObject ReloadingPrompt;

		public AnimationCurve StartClickCurve;

		public MMProgressBar PowerBar;

		public List<PowerBarElement> SpeedBars;

		public Color ActiveColor;

		public Color InactiveColor;

		public bool _carStarted;

		public float _carStartedAt;

		public float _lastStartClickAt;

		protected float _knobValueLastFrame;

		protected float _lastDentAt;

		protected float _knobValue;

		protected Vector3 _initialCarPosition;

		protected Vector3 _carPosition;

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void HandlePower()
		{
		}

		protected virtual void UpdateCar()
		{
		}

		protected virtual void UpdateUI()
		{
		}
	}
}
