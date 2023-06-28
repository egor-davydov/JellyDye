using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ToonyColorsPro.Demo
{
	public class TCP2_Demo_Cat : MonoBehaviour
	{
		[Serializable]
		public class Ambience
		{
			public string name;

			public GameObject[] activate;

			public Material skybox;
		}

		[Serializable]
		public class ShaderStyle
		{
			[Serializable]
			public class CharacterSettings
			{
				public Material material;

				public Renderer[] renderers;
			}

			public string name;

			public CharacterSettings[] settings;
		}

		public Ambience[] ambiences;

		public int amb;

		[Space]
		public ShaderStyle[] styles;

		public int style;

		[Space]
		public GameObject shadedGroup;

		public GameObject flatGroup;

		[Space]
		public Animation[] catAnimation;

		public Animation[] unityChanAnimation;

		[Space]
		public GameObject[] cats;

		public GameObject[] unityChans;

		public GameObject unityChanCopyright;

		[Space]
		public Light catDirLight;

		public Light unityChanDirLight;

		[Space]
		public AnimationClip[] catAnimations;

		private int catAnim;

		public AnimationClip[] unityChanAnimations;

		private int uchanAnim;

		[Space]
		public Light[] dirLights;

		public Light[] otherLights;

		public Transform rotatingPointLights;

		[Space]
		public Button[] ambiencesButtons;

		public Button[] stylesButtons;

		public Button[] characterButtons;

		public Button[] textureButtons;

		public Button[] animationButtons;

		[Space]
		public Canvas canvas;

		private bool animationPaused;

		private float playingSpeed;

		public bool rotateLights
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool rotatePointLights
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetAmbience(int index)
		{
		}

		public void SetStyle(int index)
		{
		}

		public void SetFlat(bool flat)
		{
		}

		public void SetCat(bool cat)
		{
		}

		public void SetLightShadows(bool on)
		{
		}

		public void SetAnimation(int index)
		{
		}

		public void SetAnimationSpeed(float speed)
		{
		}

		public void PauseUnpauseAnimation(bool play)
		{
		}

		private void UpdateAnimSpeed()
		{
		}

		private void PlayCurrentAnimation(float time = -1f)
		{
		}
	}
}
