using System;
using System.Collections.Generic;
using UnityEngine;

namespace CartoonFX
{
	public class CFXR_Effect : MonoBehaviour
	{
		[Serializable]
		public class CameraShake
		{
			public enum ShakeSpace
			{
				Screen = 0,
				World = 1
			}

			public static bool editorPreview;

			public bool enabled;

			[Space]
			public bool useMainCamera;

			public List<Camera> cameras;

			[Space]
			public float delay;

			public float duration;

			public ShakeSpace shakeSpace;

			public Vector3 shakeStrength;

			public AnimationCurve shakeCurve;

			[Space]
			public float shakesDelay;

			[NonSerialized]
			public bool isShaking;

			private Dictionary<Camera, Vector3> camerasPreRenderPosition;

			private Vector3 shakeVector;

			private float delaysTimer;

			private static bool s_CallbackRegistered;

			private static List<CameraShake> s_CameraShakes;

			private static void OnPreRenderCamera_Static(Camera cam)
			{
			}

			private static void OnPostRenderCamera_Static(Camera cam)
			{
			}

			private static void RegisterStaticCallback(CameraShake cameraShake)
			{
			}

			private static void UnregisterStaticCallback(CameraShake cameraShake)
			{
			}

			private void onPreRenderCamera(Camera cam)
			{
			}

			private void onPostRenderCamera(Camera cam)
			{
			}

			public void fetchCameras()
			{
			}

			public void StartShake()
			{
			}

			public void StopShake()
			{
			}

			public void animate(float time)
			{
			}
		}

		public enum ClearBehavior
		{
			None = 0,
			Disable = 1,
			Destroy = 2
		}

		[Serializable]
		public class AnimatedLight
		{
			public static bool editorPreview;

			public Light light;

			public bool loop;

			public bool animateIntensity;

			public float intensityStart;

			public float intensityEnd;

			public float intensityDuration;

			public AnimationCurve intensityCurve;

			public bool perlinIntensity;

			public float perlinIntensitySpeed;

			public bool fadeIn;

			public float fadeInDuration;

			public bool fadeOut;

			public float fadeOutDuration;

			public bool animateRange;

			public float rangeStart;

			public float rangeEnd;

			public float rangeDuration;

			public AnimationCurve rangeCurve;

			public bool perlinRange;

			public float perlinRangeSpeed;

			public bool animateColor;

			public Gradient colorGradient;

			public float colorDuration;

			public AnimationCurve colorCurve;

			public bool perlinColor;

			public float perlinColorSpeed;

			public void animate(float time)
			{
			}

			public void animateFadeOut(float time)
			{
			}

			public void reset()
			{
			}
		}

		private const float GLOBAL_CAMERA_SHAKE_MULTIPLIER = 1f;

		public static bool GlobalDisableCameraShake;

		public static bool GlobalDisableLights;

		public ClearBehavior clearBehavior;

		[Space]
		public CameraShake cameraShake;

		[Space]
		public AnimatedLight[] animatedLights;

		public ParticleSystem fadeOutReference;

		private float time;

		private ParticleSystem rootParticleSystem;

		private const int CHECK_EVERY_N_FRAME = 20;

		private static int GlobalStartFrameOffset;

		private int startFrameOffset;

		private bool isFadingOut;

		private float fadingOutStartTime;

		public void ResetState()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void Animate(float time)
		{
		}

		public void FadeOut(float time)
		{
		}
	}
}
