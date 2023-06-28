using System;
using UnityEngine;

namespace ToonyColorsPro.Demo
{
	[ExecuteInEditMode]
	public class TCP2_Demo_GammaLinear : MonoBehaviour
	{
		[Serializable]
		public class LightSettings
		{
			public Light light;

			public float gammaIntensity;

			public float linearIntensity;
		}

		[Serializable]
		public class MaterialSettings
		{
			public Material material;

			public Color gammaColor;

			public Color linearColor;
		}

		public LightSettings[] lights;

		public MaterialSettings[] materials;

		private ColorSpace lastColorSpace;
	}
}
