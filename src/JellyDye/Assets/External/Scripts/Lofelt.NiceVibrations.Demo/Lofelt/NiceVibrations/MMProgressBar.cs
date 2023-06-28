using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Lofelt.NiceVibrations
{
	public class MMProgressBar : MonoBehaviour
	{
		public enum FillModes
		{
			LocalScale = 0,
			FillAmount = 1,
			Width = 2,
			Height = 3
		}

		public enum BarDirections
		{
			LeftToRight = 0,
			RightToLeft = 1,
			UpToDown = 2,
			DownToUp = 3
		}

		public enum TimeScales
		{
			UnscaledTime = 0,
			Time = 1
		}

		public float StartValue;

		public float EndValue;

		public BarDirections BarDirection;

		public FillModes FillMode;

		public TimeScales TimeScale;

		public bool LerpForegroundBar;

		public float LerpForegroundBarSpeed;

		public float Delay;

		public bool LerpDelayedBar;

		public float LerpDelayedBarSpeed;

		public string PlayerID;

		public Transform DelayedBar;

		public Transform ForegroundBar;

		public bool BumpScaleOnChange;

		public bool BumpOnIncrease;

		public float BumpDuration;

		public bool ChangeColorWhenBumping;

		public Color BumpColor;

		public AnimationCurve BumpAnimationCurve;

		public AnimationCurve BumpColorAnimationCurve;

		public bool AutoUpdating;

		public float BarProgress;

		protected float _targetFill;

		protected Vector3 _targetLocalScale;

		protected float _newPercent;

		protected float _lastPercent;

		protected float _lastUpdateTimestamp;

		protected bool _bump;

		protected Color _initialColor;

		protected Vector3 _initialScale;

		protected Vector3 _newScale;

		protected Image _foregroundImage;

		protected Image _delayedImage;

		protected bool _initialized;

		protected Vector2 _initialFrontBarSize;

		public bool Bumping
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void AutoUpdate()
		{
		}

		protected virtual void UpdateFrontBar()
		{
		}

		protected virtual void UpdateDelayedBar()
		{
		}

		public virtual void UpdateBar(float currentValue, float minValue, float maxValue)
		{
		}

		public virtual void Bump()
		{
		}

		protected virtual IEnumerator BumpCoroutine()
		{
			return null;
		}

		protected virtual float Remap(float x, float A, float B, float C, float D)
		{
			return 0f;
		}
	}
}
