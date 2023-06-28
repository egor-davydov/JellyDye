using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class EmphasisHapticsDemoManager : DemoManager
	{
		public MMProgressBar AmplitudeProgressBar;

		public MMProgressBar FrequencyProgressBar;

		public HapticCurve TargetCurve;

		public float EmphasisAmplitude;

		public float EmphasisFrequency;

		public Text EmphasisAmplitudeText;

		public Text EmphasisFrequencyText;

		protected virtual void Start()
		{
		}

		public virtual void UpdateEmphasisAmplitude(float newAmplitude)
		{
		}

		public virtual void UpdateEmphasisFrequency(float newFrequency)
		{
		}

		public virtual void EmphasisHapticsButton()
		{
		}
	}
}
