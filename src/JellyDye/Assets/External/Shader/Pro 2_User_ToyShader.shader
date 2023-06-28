Shader "Pro 2/User/ToyShader" {
	Properties {
		[TCP2HeaderHelp(Base)] _Color ("Color", Vector) = (1,1,1,1)
		[TCP2ColorNoAlpha] _HColor ("Highlight Color", Vector) = (0.75,0.75,0.75,1)
		[TCP2ColorNoAlpha] _SColor ("Shadow Color", Vector) = (0.2,0.2,0.2,1)
		_MainTex ("Albedo", 2D) = "white" {}
		[TCP2Separator] [TCP2Header(Ramp Shading)] _RampThreshold ("Threshold", Range(0.01, 1)) = 0.5
		_RampSmoothing ("Smoothing", Range(0.001, 1)) = 0.1
		[TCP2Separator] [TCP2HeaderHelp(Specular)] [TCP2ColorNoAlpha] _SpecularColor ("Specular Color", Vector) = (0.5,0.5,0.5,1)
		_SpecularToonSize ("Toon Size", Range(0, 1)) = 0.25
		_SpecularToonSmoothness ("Toon Smoothness", Range(0.001, 0.5)) = 0.05
		[TCP2Separator] [TCP2HeaderHelp(Rim Outline)] [Toggle(TCP2_RIM_OUTLINE)] _UseRim ("Enable Rim Outline", Float) = 0
		[TCP2ColorNoAlpha] _RimColor ("Rim Color", Vector) = (0.8,0.8,0.8,0.5)
		_RimMin ("Rim Min", Range(0, 2)) = 0.5
		_RimMax ("Rim Max", Range(0, 2)) = 1
		_RimDir ("Rim Direction", Vector) = (0,0,1,1)
		[TCP2Separator] [HideInInspector] __dummy__ ("unused", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ToonyColorsPro.ShaderGenerator.MaterialInspector_SG2"
}