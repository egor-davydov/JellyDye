using UnityEngine;

namespace ToonyColorsPro.Demo
{
	public class TCP2_Demo : MonoBehaviour
	{
		public Material[] AffectedMaterials;

		public Texture2D[] RampTextures;

		public GUISkin GuiSkin;

		public Light DirLight;

		public GameObject Robot;

		public GameObject Ethan;

		private bool mUnityShader;

		private bool mShaderSpecular;

		private bool mShaderBump;

		private bool mShaderReflection;

		private bool mShaderRim;

		private bool mShaderRimOutline;

		private bool mShaderOutline;

		private float mRimMin;

		private float mRimMax;

		private bool mRampTextureFlag;

		private Texture2D mRampTexture;

		private float mRampSmoothing;

		private float mLightRotationX;

		private float mLightRotationY;

		private bool mViewRobot;

		private bool mRobotOutlineNormals;

		private TCP2_Demo_View DemoView;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnGUI()
		{
		}

		private void UnityDiffuseShader()
		{
		}

		private void UpdateShader()
		{
		}

		private void RimOutlineColor()
		{
		}

		private void RestoreRimColors()
		{
		}

		private void ToggleKeyword(Material m, bool enabled, string keyword)
		{
		}

		private void PrevRamp()
		{
		}

		private void NextRamp()
		{
		}
	}
}
