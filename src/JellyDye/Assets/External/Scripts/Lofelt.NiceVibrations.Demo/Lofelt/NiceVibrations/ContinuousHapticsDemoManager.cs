using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class ContinuousHapticsDemoManager : DemoManager
	{
		public float ContinuousAmplitude;

		public float ContinuousFrequency;

		public float ContinuousDuration;

		public Text ContinuousAmplitudeText;

		public Text ContinuousFrequencyText;

		public Text ContinuousDurationText;

		public Text ContinuousButtonText;

		public MMTouchButton ContinuousButton;

		public MMProgressBar AmplitudeProgressBar;

		public MMProgressBar FrequencyProgressBar;

		public MMProgressBar DurationProgressBar;

		public MMProgressBar ContinuousProgressBar;

		public HapticCurve TargetCurve;

		public Slider DurationSlider;

		protected float _timeLeft;

		protected Color _continuousButtonOnColor;

		protected Color _continuousButtonOffColor;

		protected bool _continuousActive;

		protected float _amplitudeLastFrame;

		protected float _frequencyLastFrame;

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void UpdateContinuousDemo()
		{
		}

		public virtual void UpdateContinuousAmplitude(float newAmplitude)
		{
		}

		public virtual void UpdateContinuousFrequency(float newFrequency)
		{
		}

		public virtual void UpdateContinuousDuration(float newDuration)
		{
		}

		protected virtual void UpdateContinuous()
		{
		}

		public virtual void ContinuousHapticsButton()
		{
		}

		protected virtual void OnHapticsStopped()
		{
		}

		protected virtual void ResetPlayState()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
