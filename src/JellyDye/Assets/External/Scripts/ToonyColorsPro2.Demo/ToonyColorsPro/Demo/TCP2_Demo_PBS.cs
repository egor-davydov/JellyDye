using System;
using UnityEngine;
using UnityEngine.UI;

namespace ToonyColorsPro.Demo
{
	public class TCP2_Demo_PBS : MonoBehaviour
	{
		[Serializable]
		public class SkyboxSetting
		{
			public Material SkyMaterial;

			public Color lightColor;

			public Vector3 DirLightEuler;
		}

		public Light DirLight;

		public GameObject PointLights;

		public MeshRenderer Robot;

		public GameObject Canvas;

		public SkyboxSetting[] SkySettings;

		public bool FlipLight;

		public Texture2D[] RampTextures;

		public Slider SmoothnessSlider;

		public Text SmoothnessValue;

		public Slider MetallicSlider;

		public Text MetallicValue;

		public Text BumpScaleValue;

		public Text ShaderText;

		public Text SkyboxValue;

		public Text RampValue;

		public Slider RampThresholdSlider;

		public Text RampThresholdValue;

		public Slider RampSmoothSlider;

		public Text RampSmoothValue;

		public Slider RampSmoothAddSlider;

		public Text RampSmoothAddValue;

		public RawImage RampImage;

		private int currentSky;

		private int currentRamp;

		private Material robotMaterial;

		private bool mUseOutline;

		private bool mRotatePointLights;

		public bool ShowPointLights
		{
			set
			{
			}
		}

		public bool ShowDirLight
		{
			set
			{
			}
		}

		public bool RotatePointLights
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseOutline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseRampTexture
		{
			set
			{
			}
		}

		public bool UseStylizedFresnel
		{
			set
			{
			}
		}

		public bool UseStylizedSpecular
		{
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

		public void ToggleShader()
		{
		}

		public void NextSky()
		{
		}

		public void PrevSky()
		{
		}

		public void NextRamp()
		{
		}

		public void PrevRamp()
		{
		}

		public void SetMetallic(float f)
		{
		}

		public void SetSmoothness(float f)
		{
		}

		public void SetBumpScale(float f)
		{
		}

		public void SetRampThreshold(float f)
		{
		}

		public void SetRampSmooth(float f)
		{
		}

		public void SetRampSmoothAdd(float f)
		{
		}

		private void UpdateRamp()
		{
		}

		private void UpdateSky()
		{
		}

		private void ShowUnityStandardShader()
		{
		}

		public void ShowTCP2Shader()
		{
		}

		private void ToggleKeyword(Material m, bool enabled, string keyword)
		{
		}
	}
}
