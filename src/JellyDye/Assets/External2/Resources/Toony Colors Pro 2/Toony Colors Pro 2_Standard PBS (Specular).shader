// Upgrade NOTE: commented out 'float3 _WorldSpaceCameraPos', a built-in variable

Shader "Toony Colors Pro 2/Standard PBS (Specular)"
{
  Properties
  {
    _Color ("Color", Color) = (1,1,1,1)
    _MainTex ("Albedo", 2D) = "white" {}
    _Cutoff ("Alpha Cutoff", Range(0, 1)) = 0.5
    _Glossiness ("Smoothness", Range(0, 1)) = 0.5
    _GlossMapScale ("Smoothness Factor", Range(0, 1)) = 1
    [Enum(Specular Alpha,0,Albedo Alpha,1)] _SmoothnessTextureChannel ("Smoothness texture channel", float) = 0
    _SpecColor ("Specular", Color) = (0.2,0.2,0.2,1)
    _SpecGlossMap ("Specular", 2D) = "white" {}
    [ToggleOff] _SpecularHighlights ("Specular Highlights", float) = 1
    [ToggleOff] _GlossyReflections ("Glossy Reflections", float) = 1
    _BumpScale ("Scale", float) = 1
    _BumpMap ("Normal Map", 2D) = "bump" {}
    _Parallax ("Height Scale", Range(0.005, 0.08)) = 0.02
    _ParallaxMap ("Height Map", 2D) = "black" {}
    _OcclusionStrength ("Strength", Range(0, 1)) = 1
    _OcclusionMap ("Occlusion", 2D) = "white" {}
    _EmissionColor ("Color", Color) = (0,0,0,1)
    _EmissionMap ("Emission", 2D) = "white" {}
    _DetailMask ("Detail Mask", 2D) = "white" {}
    _DetailAlbedoMap ("Detail Albedo x2", 2D) = "grey" {}
    _DetailNormalMapScale ("Scale", float) = 1
    _DetailNormalMap ("Normal Map", 2D) = "bump" {}
    [Enum(UV0,0,UV1,1)] _UVSec ("UV Set for secondary textures", float) = 0
    [HideInInspector] _Mode ("__mode", float) = 0
    [HideInInspector] _SrcBlend ("__src", float) = 1
    [HideInInspector] _DstBlend ("__dst", float) = 0
    [HideInInspector] _ZWrite ("__zw", float) = 1
    _HColor ("Highlight Color", Color) = (1,1,1,1)
    _SColor ("Shadow Color", Color) = (0.25,0.25,0.25,1)
    [Toggle(TCP2_DISABLE_WRAPPED_LIGHT)] _TCP2_DISABLE_WRAPPED_LIGHT ("Disable Wrapped Lighting", float) = 1
    [Toggle(TCP2_RAMPTEXT)] _TCP2_RAMPTEXT ("Ramp Texture", float) = 0
    [TCP2Gradient] _Ramp ("Toon Ramp (RGB)", 2D) = "gray" {}
    _RampThreshold ("Ramp Threshold", Range(0, 1)) = 0.5
    _RampSmooth ("Ramp Smoothing", Range(0, 1)) = 0.2
    _RampSmoothAdd ("Additive Lights Ramp Smoothing", Range(0, 1)) = 0.2
    [Toggle(TCP2_SPEC_TOON)] _TCP2_SPEC_TOON ("Stylized Specular", float) = 0
    _SpecSmooth ("Specular Smoothing", Range(0, 1)) = 1
    _SpecBlend ("Stylized Specular Blending", Range(0, 1)) = 1
    [Toggle(TCP2_STYLIZED_FRESNEL)] _TCP2_STYLIZED_FRESNEL ("Stylized Fresnel", float) = 0
    _RimColor ("Fresnel Color (RGB) / Strength (A)", Color) = (0.8,0.8,0.8,0.6)
    [PowerSlider(3)] _RimStrength ("Fresnel Strength", Range(0, 2)) = 0.5
    _RimMin ("Fresnel Ramp Min", Range(0, 1)) = 0.6
    _RimMax ("Fresnel Ramp Max", Range(0, 1)) = 0.85
  }
  SubShader
  {
    Tags
    { 
      "PerformanceChecks" = "False"
      "RenderType" = "Opaque"
    }
    LOD 300
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDBASE"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 300
      ZWrite Off
      Blend Zero Zero
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _DetailAlbedoMap_ST;
      
      uniform float _UVSec;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_SpecCube0_HDR;
      
      uniform float4 _HColor;
      
      uniform float4 _SColor;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmooth;
      
      uniform float4 _LightColor0;
      
      uniform float4 _SpecColor;
      
      uniform float4 _Color;
      
      uniform float _Glossiness;
      
      uniform float _OcclusionStrength;
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _OcclusionMap;
      
      uniform sampler2D unity_NHxRoughness;
      
      uniform samplerCUBE unity_SpecCube0;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float2 texcoord : TEXCOORD0;
          
          float2 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float4 texcoord5 : TEXCOORD5;
          
          float4 texcoord7 : TEXCOORD7;
          
          float3 texcoord8 : TEXCOORD8;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord4 : TEXCOORD4;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      int u_xlatb0;
      
      float4 u_xlat1;
      
      float u_xlat6;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
          
          u_xlatb0 = _UVSec==0.0;
          
          u_xlat0.xy = (int(u_xlatb0)) ? in_v.texcoord.xy : in_v.texcoord1.xy;
          
          out_v.texcoord.zw = u_xlat0.xy * _DetailAlbedoMap_ST.xy + _DetailAlbedoMap_ST.zw;
          
          out_v.texcoord.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat0.xyz = in_v.vertex.yyy * unity_ObjectToWorld[1].xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[0].xyz * in_v.vertex.xxx + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[2].xyz * in_v.vertex.zzz + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          out_v.texcoord1.xyz = u_xlat0.xyz + (-_WorldSpaceCameraPos.xyz);
          
          out_v.texcoord8.xyz = u_xlat0.xyz;
          
          out_v.texcoord1.w = 0.0;
          
          out_v.texcoord2 = float4(0.0, 0.0, 0.0, 0.0);
          
          out_v.texcoord3 = float4(0.0, 0.0, 0.0, 0.0);
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat6 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat6 = inversesqrt(u_xlat6);
          
          out_v.texcoord4.xyz = float3(u_xlat6) * u_xlat0.xyz;
          
          out_v.texcoord4.w = 0.0;
          
          out_v.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float4 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      float3 u_xlat16_1;
      
      float3 u_xlat2;
      
      float3 u_xlat3;
      
      float3 u_xlat16_4;
      
      float4 u_xlat10_4;
      
      float3 u_xlat16_5;
      
      float3 u_xlat16_6;
      
      float3 u_xlat16_8;
      
      float3 u_xlat16_12;
      
      float u_xlat16_15;
      
      float u_xlat16_19;
      
      float u_xlat16_22;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat10_0.x = texture2D(_OcclusionMap, in_f.texcoord.xy).y;
          
          u_xlat16_1.x = (-_OcclusionStrength) + 1.0;
          
          u_xlat16_1.x = u_xlat10_0.x * _OcclusionStrength + u_xlat16_1.x;
          
          u_xlat0_d.xw = (-float2(_Glossiness)) + float2(1.0, 1.0);
          
          u_xlat16_8.x = (-u_xlat0_d.x) * 0.699999988 + 1.70000005;
          
          u_xlat16_8.x = u_xlat0_d.x * u_xlat16_8.x;
          
          u_xlat16_8.x = u_xlat16_8.x * 6.0;
          
          u_xlat0_d.x = dot(in_f.texcoord1.xyz, in_f.texcoord1.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat2.xyz = u_xlat0_d.xxx * in_f.texcoord1.xyz;
          
          u_xlat0_d.x = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat3.xyz = u_xlat0_d.xxx * in_f.texcoord4.xyz;
          
          u_xlat16_15 = dot(u_xlat2.xyz, u_xlat3.xyz);
          
          u_xlat16_15 = u_xlat16_15 + u_xlat16_15;
          
          u_xlat16_4.xyz = u_xlat3.xyz * (-float3(u_xlat16_15)) + u_xlat2.xyz;
          
          u_xlat10_4 = textureCube(unity_SpecCube0, u_xlat16_4.xyz, u_xlat16_8.x);
          
          u_xlat16_8.x = u_xlat10_4.w + -1.0;
          
          u_xlat16_8.x = unity_SpecCube0_HDR.w * u_xlat16_8.x + 1.0;
          
          u_xlat16_8.x = u_xlat16_8.x * unity_SpecCube0_HDR.x;
          
          u_xlat16_8.xyz = u_xlat10_4.xyz * u_xlat16_8.xxx;
          
          u_xlat16_1.xyz = u_xlat16_1.xxx * u_xlat16_8.xyz;
          
          u_xlat16_22 = dot((-u_xlat2.xyz), u_xlat3.xyz);
          
          u_xlat16_5.x = u_xlat16_22 + u_xlat16_22;
          
          u_xlat16_22 = u_xlat16_22;
          
          u_xlat16_22 = clamp(u_xlat16_22, 0.0, 1.0);
          
          u_xlat16_6.y = (-u_xlat16_22) + 1.0;
          
          u_xlat16_5.xyz = u_xlat3.xyz * (-u_xlat16_5.xxx) + (-u_xlat2.xyz);
          
          u_xlat16_22 = dot(u_xlat3.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_22 = clamp(u_xlat16_22, 0.0, 1.0);
          
          u_xlat16_22 = u_xlat16_22 * 0.5 + 0.5;
          
          u_xlat16_6.x = dot(u_xlat16_5.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat2.xy = u_xlat16_6.xy * u_xlat16_6.xy;
          
          u_xlat2.xy = u_xlat16_6.xy * u_xlat2.xy;
          
          u_xlat0_d.yz = u_xlat16_6.xy * u_xlat2.xy;
          
          u_xlat16_5.x = max(_SpecColor.y, _SpecColor.x);
          
          u_xlat16_5.x = max(u_xlat16_5.x, _SpecColor.z);
          
          u_xlat16_5.x = (-u_xlat16_5.x) + 1.0;
          
          u_xlat16_12.x = (-u_xlat16_5.x) + 1.0;
          
          u_xlat16_12.x = u_xlat16_12.x + _Glossiness;
          
          u_xlat16_12.x = clamp(u_xlat16_12.x, 0.0, 1.0);
          
          u_xlat16_12.xyz = u_xlat16_12.xxx + (-_SpecColor.xyz);
          
          u_xlat16_12.xyz = u_xlat0_d.zzz * u_xlat16_12.xyz + _SpecColor.xyz;
          
          u_xlat0_d.x = texture2D(unity_NHxRoughness, u_xlat0_d.yw).x;
          
          u_xlat0_d.x = u_xlat0_d.x * 16.0;
          
          u_xlat16_6.xyz = u_xlat0_d.xxx * _SpecColor.xyz;
          
          u_xlat16_1.xyz = u_xlat16_1.xyz * u_xlat16_12.xyz;
          
          u_xlat16_12.x = (-_RampSmooth) * 0.5 + _RampThreshold;
          
          u_xlat16_22 = u_xlat16_22 + (-u_xlat16_12.x);
          
          u_xlat16_19 = _RampSmooth * 0.5 + _RampThreshold;
          
          u_xlat16_12.x = (-u_xlat16_12.x) + u_xlat16_19;
          
          u_xlat16_12.x = float(1.0) / u_xlat16_12.x;
          
          u_xlat16_22 = u_xlat16_22 * u_xlat16_12.x;
          
          u_xlat16_22 = clamp(u_xlat16_22, 0.0, 1.0);
          
          u_xlat16_12.x = u_xlat16_22 * -2.0 + 3.0;
          
          u_xlat16_22 = u_xlat16_22 * u_xlat16_22;
          
          u_xlat16_22 = u_xlat16_22 * u_xlat16_12.x;
          
          u_xlat16_12.xyz = _HColor.xyz + (-_SColor.xyz);
          
          u_xlat16_12.xyz = float3(u_xlat16_22) * u_xlat16_12.xyz + _SColor.xyz;
          
          u_xlat16_12.xyz = u_xlat16_12.xyz * _LightColor0.xyz;
          
          u_xlat10_0.xyz = texture2D(_MainTex, in_f.texcoord.xy).xyz;
          
          u_xlat0_d.xyz = u_xlat10_0.xyz * _Color.xyz;
          
          u_xlat16_6.xyz = u_xlat0_d.xyz * u_xlat16_5.xxx + u_xlat16_6.xyz;
          
          out_f.color.xyz = u_xlat16_6.xyz * u_xlat16_12.xyz + u_xlat16_1.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: FORWARD_DELTA
    {
      Name "FORWARD_DELTA"
      Tags
      { 
        "LIGHTMODE" = "FORWARDADD"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 300
      ZWrite Off
      Blend Zero One
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile POINT
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _DetailAlbedoMap_ST;
      
      uniform float _UVSec;
      
      uniform float4 unity_WorldToLight[4];
      
      uniform float4 _HColor;
      
      uniform float4 _SColor;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmoothAdd;
      
      uniform float4 _LightColor0;
      
      uniform float4 _SpecColor;
      
      uniform float4 _Color;
      
      uniform float _Glossiness;
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _LightTexture0;
      
      uniform sampler2D unity_NHxRoughness;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float2 texcoord : TEXCOORD0;
          
          float2 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
          
          float3 texcoord6 : TEXCOORD6;
          
          float4 texcoord7 : TEXCOORD7;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      int u_xlatb1;
      
      float4 u_xlat2;
      
      float u_xlat10;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat0 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat0;
          
          u_xlat2 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat2;
          
          u_xlat2 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat2;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat2;
          
          u_xlatb1 = _UVSec==0.0;
          
          u_xlat1.xy = (int(u_xlatb1)) ? in_v.texcoord.xy : in_v.texcoord1.xy;
          
          out_v.texcoord.zw = u_xlat1.xy * _DetailAlbedoMap_ST.xy + _DetailAlbedoMap_ST.zw;
          
          out_v.texcoord.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat1.xyz = in_v.vertex.yyy * unity_ObjectToWorld[1].xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[0].xyz * in_v.vertex.xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[2].xyz * in_v.vertex.zzz + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat1.xyz;
          
          out_v.texcoord1.xyz = u_xlat1.xyz + (-_WorldSpaceCameraPos.xyz);
          
          out_v.texcoord1.w = 0.0;
          
          u_xlat2.xyz = (-u_xlat1.xyz) * _WorldSpaceLightPos0.www + _WorldSpaceLightPos0.xyz;
          
          out_v.texcoord5.xyz = u_xlat1.xyz;
          
          u_xlat2.w = 0.0;
          
          out_v.texcoord2 = u_xlat2.wwwx;
          
          out_v.texcoord3 = u_xlat2.wwwy;
          
          out_v.texcoord4.w = u_xlat2.z;
          
          u_xlat1.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat1.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat1.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat10 = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat10 = inversesqrt(u_xlat10);
          
          out_v.texcoord4.xyz = float3(u_xlat10) * u_xlat1.xyz;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat1.xyz = unity_WorldToLight[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = unity_WorldToLight[2].xyz * u_xlat0.zzz + u_xlat1.xyz;
          
          out_v.texcoord6.xyz = unity_WorldToLight[3].xyz * u_xlat0.www + u_xlat0.xyz;
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      float3 u_xlat1_d;
      
      float4 u_xlat16_2;
      
      float3 u_xlat16_3;
      
      float3 u_xlat16_4;
      
      float u_xlat16_7;
      
      float u_xlat16_8;
      
      float u_xlat15;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = dot(in_f.texcoord1.xyz, in_f.texcoord1.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * in_f.texcoord1.xyz;
          
          u_xlat15 = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          
          u_xlat15 = inversesqrt(u_xlat15);
          
          u_xlat1_d.xyz = float3(u_xlat15) * in_f.texcoord4.xyz;
          
          u_xlat16_2.x = dot((-u_xlat0_d.xyz), u_xlat1_d.xyz);
          
          u_xlat16_2.x = u_xlat16_2.x + u_xlat16_2.x;
          
          u_xlat16_2.xyz = u_xlat1_d.xyz * (-u_xlat16_2.xxx) + (-u_xlat0_d.xyz);
          
          u_xlat0_d.x = in_f.texcoord2.w;
          
          u_xlat0_d.y = in_f.texcoord3.w;
          
          u_xlat0_d.z = in_f.texcoord4.w;
          
          u_xlat15 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat15 = inversesqrt(u_xlat15);
          
          u_xlat0_d.xyz = float3(u_xlat15) * u_xlat0_d.xyz;
          
          u_xlat16_2.x = dot(u_xlat16_2.xyz, u_xlat0_d.xyz);
          
          u_xlat16_7 = dot(u_xlat1_d.xyz, u_xlat0_d.xyz);
          
          u_xlat16_7 = clamp(u_xlat16_7, 0.0, 1.0);
          
          u_xlat16_7 = u_xlat16_7 * 0.5 + 0.5;
          
          u_xlat0_d.x = u_xlat16_2.x * u_xlat16_2.x;
          
          u_xlat0_d.x = u_xlat16_2.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat16_2.x * u_xlat0_d.x;
          
          u_xlat0_d.y = (-_Glossiness) + 1.0;
          
          u_xlat0_d.x = texture2D(unity_NHxRoughness, u_xlat0_d.xy).x;
          
          u_xlat0_d.x = u_xlat0_d.x * 16.0;
          
          u_xlat16_2.xzw = u_xlat0_d.xxx * _SpecColor.xyz;
          
          u_xlat16_3.x = max(_SpecColor.y, _SpecColor.x);
          
          u_xlat16_3.x = max(u_xlat16_3.x, _SpecColor.z);
          
          u_xlat16_3.x = (-u_xlat16_3.x) + 1.0;
          
          u_xlat10_0.xyz = texture2D(_MainTex, in_f.texcoord.xy).xyz;
          
          u_xlat0_d.xyz = u_xlat10_0.xyz * _Color.xyz;
          
          u_xlat16_2.xzw = u_xlat0_d.xyz * u_xlat16_3.xxx + u_xlat16_2.xzw;
          
          u_xlat16_3.x = (-_RampSmoothAdd) * 0.5 + _RampThreshold;
          
          u_xlat16_7 = u_xlat16_7 + (-u_xlat16_3.x);
          
          u_xlat16_8 = _RampSmoothAdd * 0.5 + _RampThreshold;
          
          u_xlat16_3.x = (-u_xlat16_3.x) + u_xlat16_8;
          
          u_xlat16_3.x = float(1.0) / u_xlat16_3.x;
          
          u_xlat16_7 = u_xlat16_7 * u_xlat16_3.x;
          
          u_xlat16_7 = clamp(u_xlat16_7, 0.0, 1.0);
          
          u_xlat16_3.x = u_xlat16_7 * -2.0 + 3.0;
          
          u_xlat16_7 = u_xlat16_7 * u_xlat16_7;
          
          u_xlat16_7 = u_xlat16_7 * u_xlat16_3.x;
          
          u_xlat16_3.xyz = _HColor.xyz + (-_SColor.xyz);
          
          u_xlat16_3.xyz = float3(u_xlat16_7) * u_xlat16_3.xyz + _SColor.xyz;
          
          u_xlat0_d.xyz = in_f.texcoord5.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat0_d.xyz = unity_WorldToLight[0].xyz * in_f.texcoord5.xxx + u_xlat0_d.xyz;
          
          u_xlat0_d.xyz = unity_WorldToLight[2].xyz * in_f.texcoord5.zzz + u_xlat0_d.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz + unity_WorldToLight[3].xyz;
          
          u_xlat0_d.x = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat0_d.x = texture2D(_LightTexture0, u_xlat0_d.xx).x;
          
          u_xlat16_4.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat16_3.xyz = u_xlat16_3.xyz * u_xlat16_4.xyz;
          
          out_f.color.xyz = u_xlat16_2.xzw * u_xlat16_3.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 3, name: ShadowCaster
    {
      Name "ShadowCaster"
      Tags
      { 
        "LIGHTMODE" = "SHADOWCASTER"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 300
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile SHADOWS_DEPTH
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_LightShadowBias;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 vertex : Position;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      float u_xlat6;
      
      float u_xlat9;
      
      int u_xlatb9;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat9 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat9 = inversesqrt(u_xlat9);
          
          u_xlat0.xyz = float3(u_xlat9) * u_xlat0.xyz;
          
          u_xlat1 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat1 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat1;
          
          u_xlat1 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat1;
          
          u_xlat1 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat1;
          
          u_xlat2.xyz = (-u_xlat1.xyz) * _WorldSpaceLightPos0.www + _WorldSpaceLightPos0.xyz;
          
          u_xlat9 = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat9 = inversesqrt(u_xlat9);
          
          u_xlat2.xyz = float3(u_xlat9) * u_xlat2.xyz;
          
          u_xlat9 = dot(u_xlat0.xyz, u_xlat2.xyz);
          
          u_xlat9 = (-u_xlat9) * u_xlat9 + 1.0;
          
          u_xlat9 = sqrt(u_xlat9);
          
          u_xlat9 = u_xlat9 * unity_LightShadowBias.z;
          
          u_xlat0.xyz = (-u_xlat0.xyz) * float3(u_xlat9) + u_xlat1.xyz;
          
          u_xlatb9 = unity_LightShadowBias.z!=0.0;
          
          u_xlat0.xyz = (int(u_xlatb9)) ? u_xlat0.xyz : u_xlat1.xyz;
          
          u_xlat2 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat2;
          
          u_xlat0 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat2;
          
          u_xlat0 = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat0;
          
          u_xlat1.x = unity_LightShadowBias.x / u_xlat0.w;
          
          u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
          
          u_xlat6 = u_xlat0.z + u_xlat1.x;
          
          u_xlat1.x = max((-u_xlat0.w), u_xlat6);
          
          out_v.vertex.xyw = u_xlat0.xyw;
          
          u_xlat0.x = (-u_xlat6) + u_xlat1.x;
          
          out_v.vertex.z = unity_LightShadowBias.y * u_xlat0.x + u_xlat6;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          out_f.color = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  SubShader
  {
    Tags
    { 
      "PerformanceChecks" = "False"
      "RenderType" = "Opaque"
    }
    LOD 150
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDBASE"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 150
      ZWrite Off
      Blend Zero Zero
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _DetailAlbedoMap_ST;
      
      uniform float _UVSec;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_SpecCube0_HDR;
      
      uniform float4 _HColor;
      
      uniform float4 _SColor;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmooth;
      
      uniform float4 _LightColor0;
      
      uniform float4 _SpecColor;
      
      uniform float4 _Color;
      
      uniform float _Glossiness;
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _OcclusionMap;
      
      uniform sampler2D unity_NHxRoughness;
      
      uniform samplerCUBE unity_SpecCube0;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float2 texcoord : TEXCOORD0;
          
          float2 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float4 texcoord5 : TEXCOORD5;
          
          float4 texcoord7 : TEXCOORD7;
          
          float3 texcoord8 : TEXCOORD8;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord4 : TEXCOORD4;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      int u_xlatb0;
      
      float4 u_xlat1;
      
      float u_xlat6;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
          
          u_xlatb0 = _UVSec==0.0;
          
          u_xlat0.xy = (int(u_xlatb0)) ? in_v.texcoord.xy : in_v.texcoord1.xy;
          
          out_v.texcoord.zw = u_xlat0.xy * _DetailAlbedoMap_ST.xy + _DetailAlbedoMap_ST.zw;
          
          out_v.texcoord.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat0.xyz = in_v.vertex.yyy * unity_ObjectToWorld[1].xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[0].xyz * in_v.vertex.xxx + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[2].xyz * in_v.vertex.zzz + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat1.xyz = u_xlat0.xyz + (-_WorldSpaceCameraPos.xyz);
          
          out_v.texcoord8.xyz = u_xlat0.xyz;
          
          u_xlat0.x = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat0.x = inversesqrt(u_xlat0.x);
          
          out_v.texcoord1.xyz = u_xlat0.xxx * u_xlat1.xyz;
          
          out_v.texcoord1.w = 0.0;
          
          out_v.texcoord2 = float4(0.0, 0.0, 0.0, 0.0);
          
          out_v.texcoord3 = float4(0.0, 0.0, 0.0, 0.0);
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat6 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat6 = inversesqrt(u_xlat6);
          
          out_v.texcoord4.xyz = float3(u_xlat6) * u_xlat0.xyz;
          
          out_v.texcoord4.w = 0.0;
          
          out_v.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float4 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      float u_xlat16_1;
      
      float4 u_xlat10_1;
      
      float3 u_xlat2;
      
      float3 u_xlat16_3;
      
      float3 u_xlat16_4;
      
      float3 u_xlat16_5;
      
      float3 u_xlat16_7;
      
      float3 u_xlat16_10;
      
      float u_xlat16_16;
      
      float u_xlat16_21;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xw = (-float2(_Glossiness)) + float2(1.0, 1.0);
          
          u_xlat16_1 = (-u_xlat0_d.x) * 0.699999988 + 1.70000005;
          
          u_xlat16_1 = u_xlat0_d.x * u_xlat16_1;
          
          u_xlat16_1 = u_xlat16_1 * 6.0;
          
          u_xlat0_d.x = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat2.xyz = u_xlat0_d.xxx * in_f.texcoord4.xyz;
          
          u_xlat16_7.x = dot(in_f.texcoord1.xyz, u_xlat2.xyz);
          
          u_xlat16_7.x = u_xlat16_7.x + u_xlat16_7.x;
          
          u_xlat16_7.xyz = u_xlat2.xyz * (-u_xlat16_7.xxx) + in_f.texcoord1.xyz;
          
          u_xlat10_1 = textureCube(unity_SpecCube0, u_xlat16_7.xyz, u_xlat16_1);
          
          u_xlat16_3.x = u_xlat10_1.w + -1.0;
          
          u_xlat16_3.x = unity_SpecCube0_HDR.w * u_xlat16_3.x + 1.0;
          
          u_xlat16_3.x = u_xlat16_3.x * unity_SpecCube0_HDR.x;
          
          u_xlat16_3.xyz = u_xlat10_1.xyz * u_xlat16_3.xxx;
          
          u_xlat10_0.x = texture2D(_OcclusionMap, in_f.texcoord.xy).y;
          
          u_xlat16_3.xyz = u_xlat10_0.xxx * u_xlat16_3.xyz;
          
          u_xlat16_21 = dot((-in_f.texcoord1.xyz), u_xlat2.xyz);
          
          u_xlat16_4.x = u_xlat16_21 + u_xlat16_21;
          
          u_xlat16_21 = u_xlat16_21;
          
          u_xlat16_21 = clamp(u_xlat16_21, 0.0, 1.0);
          
          u_xlat16_5.y = (-u_xlat16_21) + 1.0;
          
          u_xlat16_4.xyz = u_xlat2.xyz * (-u_xlat16_4.xxx) + (-in_f.texcoord1.xyz);
          
          u_xlat16_21 = dot(u_xlat2.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_21 = clamp(u_xlat16_21, 0.0, 1.0);
          
          u_xlat16_5.x = dot(u_xlat16_4.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat2.xy = u_xlat16_5.xy * u_xlat16_5.xy;
          
          u_xlat2.xy = u_xlat16_5.xy * u_xlat2.xy;
          
          u_xlat0_d.yz = u_xlat16_5.xy * u_xlat2.xy;
          
          u_xlat16_4.x = (-_SpecColor.x) + 1.0;
          
          u_xlat16_10.x = (-u_xlat16_4.x) + 1.0;
          
          u_xlat16_10.x = u_xlat16_10.x + _Glossiness;
          
          u_xlat16_10.x = clamp(u_xlat16_10.x, 0.0, 1.0);
          
          u_xlat16_10.xyz = u_xlat16_10.xxx + (-_SpecColor.xyz);
          
          u_xlat16_10.xyz = u_xlat0_d.zzz * u_xlat16_10.xyz + _SpecColor.xyz;
          
          u_xlat0_d.x = texture2D(unity_NHxRoughness, u_xlat0_d.yw).x;
          
          u_xlat0_d.x = u_xlat0_d.x * 16.0;
          
          u_xlat16_5.xyz = u_xlat0_d.xxx * _SpecColor.xyz;
          
          u_xlat16_3.xyz = u_xlat16_3.xyz * u_xlat16_10.xyz;
          
          u_xlat16_10.x = (-_RampSmooth) * 0.5 + _RampThreshold;
          
          u_xlat16_21 = u_xlat16_21 + (-u_xlat16_10.x);
          
          u_xlat16_16 = _RampSmooth * 0.5 + _RampThreshold;
          
          u_xlat16_10.x = (-u_xlat16_10.x) + u_xlat16_16;
          
          u_xlat16_10.x = float(1.0) / u_xlat16_10.x;
          
          u_xlat16_21 = u_xlat16_21 * u_xlat16_10.x;
          
          u_xlat16_21 = clamp(u_xlat16_21, 0.0, 1.0);
          
          u_xlat16_10.x = u_xlat16_21 * -2.0 + 3.0;
          
          u_xlat16_21 = u_xlat16_21 * u_xlat16_21;
          
          u_xlat16_21 = u_xlat16_21 * u_xlat16_10.x;
          
          u_xlat16_10.xyz = _HColor.xyz + (-_SColor.xyz);
          
          u_xlat16_10.xyz = float3(u_xlat16_21) * u_xlat16_10.xyz + _SColor.xyz;
          
          u_xlat16_10.xyz = u_xlat16_10.xyz * _LightColor0.xyz;
          
          u_xlat10_0.xyz = texture2D(_MainTex, in_f.texcoord.xy).xyz;
          
          u_xlat0_d.xyz = u_xlat10_0.xyz * _Color.xyz;
          
          u_xlat16_5.xyz = u_xlat0_d.xyz * u_xlat16_4.xxx + u_xlat16_5.xyz;
          
          out_f.color.xyz = u_xlat16_5.xyz * u_xlat16_10.xyz + u_xlat16_3.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: FORWARD_DELTA
    {
      Name "FORWARD_DELTA"
      Tags
      { 
        "LIGHTMODE" = "FORWARDADD"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 150
      ZWrite Off
      Blend Zero One
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile POINT
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _DetailAlbedoMap_ST;
      
      uniform float _UVSec;
      
      uniform float4 unity_WorldToLight[4];
      
      uniform float4 _HColor;
      
      uniform float4 _SColor;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmoothAdd;
      
      uniform float4 _LightColor0;
      
      uniform float4 _SpecColor;
      
      uniform float4 _Color;
      
      uniform float _Glossiness;
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _LightTexture0;
      
      uniform sampler2D unity_NHxRoughness;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float2 texcoord : TEXCOORD0;
          
          float2 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
          
          float3 texcoord6 : TEXCOORD6;
          
          float4 texcoord7 : TEXCOORD7;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      int u_xlatb1;
      
      float4 u_xlat2;
      
      float u_xlat10;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat0 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat0;
          
          u_xlat2 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat2;
          
          u_xlat2 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat2;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat2;
          
          u_xlatb1 = _UVSec==0.0;
          
          u_xlat1.xy = (int(u_xlatb1)) ? in_v.texcoord.xy : in_v.texcoord1.xy;
          
          out_v.texcoord.zw = u_xlat1.xy * _DetailAlbedoMap_ST.xy + _DetailAlbedoMap_ST.zw;
          
          out_v.texcoord.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat1.xyz = in_v.vertex.yyy * unity_ObjectToWorld[1].xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[0].xyz * in_v.vertex.xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[2].xyz * in_v.vertex.zzz + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat1.xyz;
          
          u_xlat2.xyz = u_xlat1.xyz + (-_WorldSpaceCameraPos.xyz);
          
          u_xlat10 = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat10 = inversesqrt(u_xlat10);
          
          out_v.texcoord1.xyz = float3(u_xlat10) * u_xlat2.xyz;
          
          out_v.texcoord1.w = 0.0;
          
          u_xlat2.xyz = (-u_xlat1.xyz) * _WorldSpaceLightPos0.www + _WorldSpaceLightPos0.xyz;
          
          out_v.texcoord5.xyz = u_xlat1.xyz;
          
          u_xlat1.x = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat1.x = inversesqrt(u_xlat1.x);
          
          u_xlat1.xyz = u_xlat1.xxx * u_xlat2.xyz;
          
          u_xlat1.w = 0.0;
          
          out_v.texcoord2 = u_xlat1.wwwx;
          
          out_v.texcoord3 = u_xlat1.wwwy;
          
          out_v.texcoord4.w = u_xlat1.z;
          
          u_xlat1.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat1.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat1.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat10 = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat10 = inversesqrt(u_xlat10);
          
          out_v.texcoord4.xyz = float3(u_xlat10) * u_xlat1.xyz;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat1.xyz = unity_WorldToLight[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = unity_WorldToLight[2].xyz * u_xlat0.zzz + u_xlat1.xyz;
          
          out_v.texcoord6.xyz = unity_WorldToLight[3].xyz * u_xlat0.www + u_xlat0.xyz;
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      float3 u_xlat16_1;
      
      float3 u_xlat16_2;
      
      float3 u_xlat3;
      
      float u_xlat16_6;
      
      float u_xlat16_13;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xyz = in_f.texcoord5.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat0_d.xyz = unity_WorldToLight[0].xyz * in_f.texcoord5.xxx + u_xlat0_d.xyz;
          
          u_xlat0_d.xyz = unity_WorldToLight[2].xyz * in_f.texcoord5.zzz + u_xlat0_d.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz + unity_WorldToLight[3].xyz;
          
          u_xlat0_d.x = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat0_d.x = texture2D(_LightTexture0, u_xlat0_d.xx).x;
          
          u_xlat16_1.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat16_13 = _RampSmoothAdd * 0.5 + _RampThreshold;
          
          u_xlat16_2.x = (-_RampSmoothAdd) * 0.5 + _RampThreshold;
          
          u_xlat16_13 = u_xlat16_13 + (-u_xlat16_2.x);
          
          u_xlat16_13 = float(1.0) / u_xlat16_13;
          
          u_xlat0_d.x = dot(in_f.texcoord4.xyz, in_f.texcoord4.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * in_f.texcoord4.xyz;
          
          u_xlat3.x = in_f.texcoord2.w;
          
          u_xlat3.y = in_f.texcoord3.w;
          
          u_xlat3.z = in_f.texcoord4.w;
          
          u_xlat16_6 = dot(u_xlat0_d.xyz, u_xlat3.xyz);
          
          u_xlat16_6 = clamp(u_xlat16_6, 0.0, 1.0);
          
          u_xlat16_2.x = (-u_xlat16_2.x) + u_xlat16_6;
          
          u_xlat16_13 = u_xlat16_13 * u_xlat16_2.x;
          
          u_xlat16_13 = clamp(u_xlat16_13, 0.0, 1.0);
          
          u_xlat16_2.x = u_xlat16_13 * -2.0 + 3.0;
          
          u_xlat16_13 = u_xlat16_13 * u_xlat16_13;
          
          u_xlat16_13 = u_xlat16_13 * u_xlat16_2.x;
          
          u_xlat16_2.xyz = _HColor.xyz + (-_SColor.xyz);
          
          u_xlat16_2.xyz = float3(u_xlat16_13) * u_xlat16_2.xyz + _SColor.xyz;
          
          u_xlat16_1.xyz = u_xlat16_1.xyz * u_xlat16_2.xyz;
          
          u_xlat16_13 = dot((-in_f.texcoord1.xyz), u_xlat0_d.xyz);
          
          u_xlat16_13 = u_xlat16_13 + u_xlat16_13;
          
          u_xlat16_2.xyz = u_xlat0_d.xyz * (-float3(u_xlat16_13)) + (-in_f.texcoord1.xyz);
          
          u_xlat16_13 = dot(u_xlat16_2.xyz, u_xlat3.xyz);
          
          u_xlat0_d.x = u_xlat16_13 * u_xlat16_13;
          
          u_xlat0_d.x = u_xlat16_13 * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat16_13 * u_xlat0_d.x;
          
          u_xlat0_d.y = (-_Glossiness) + 1.0;
          
          u_xlat0_d.x = texture2D(unity_NHxRoughness, u_xlat0_d.xy).x;
          
          u_xlat0_d.x = u_xlat0_d.x * 16.0;
          
          u_xlat16_2.xyz = u_xlat0_d.xxx * _SpecColor.xyz;
          
          u_xlat10_0.xyz = texture2D(_MainTex, in_f.texcoord.xy).xyz;
          
          u_xlat0_d.xyz = u_xlat10_0.xyz * _Color.xyz;
          
          u_xlat16_13 = (-_SpecColor.x) + 1.0;
          
          u_xlat16_2.xyz = u_xlat0_d.xyz * float3(u_xlat16_13) + u_xlat16_2.xyz;
          
          out_f.color.xyz = u_xlat16_1.xyz * u_xlat16_2.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 3, name: ShadowCaster
    {
      Name "ShadowCaster"
      Tags
      { 
        "LIGHTMODE" = "SHADOWCASTER"
        "PerformanceChecks" = "False"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 150
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile SHADOWS_DEPTH
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_LightShadowBias;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 vertex : Position;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      float u_xlat6;
      
      float u_xlat9;
      
      int u_xlatb9;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat9 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat9 = inversesqrt(u_xlat9);
          
          u_xlat0.xyz = float3(u_xlat9) * u_xlat0.xyz;
          
          u_xlat1 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat1 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat1;
          
          u_xlat1 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat1;
          
          u_xlat1 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat1;
          
          u_xlat2.xyz = (-u_xlat1.xyz) * _WorldSpaceLightPos0.www + _WorldSpaceLightPos0.xyz;
          
          u_xlat9 = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat9 = inversesqrt(u_xlat9);
          
          u_xlat2.xyz = float3(u_xlat9) * u_xlat2.xyz;
          
          u_xlat9 = dot(u_xlat0.xyz, u_xlat2.xyz);
          
          u_xlat9 = (-u_xlat9) * u_xlat9 + 1.0;
          
          u_xlat9 = sqrt(u_xlat9);
          
          u_xlat9 = u_xlat9 * unity_LightShadowBias.z;
          
          u_xlat0.xyz = (-u_xlat0.xyz) * float3(u_xlat9) + u_xlat1.xyz;
          
          u_xlatb9 = unity_LightShadowBias.z!=0.0;
          
          u_xlat0.xyz = (int(u_xlatb9)) ? u_xlat0.xyz : u_xlat1.xyz;
          
          u_xlat2 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat2;
          
          u_xlat0 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat2;
          
          u_xlat0 = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat0;
          
          u_xlat1.x = unity_LightShadowBias.x / u_xlat0.w;
          
          u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
          
          u_xlat6 = u_xlat0.z + u_xlat1.x;
          
          u_xlat1.x = max((-u_xlat0.w), u_xlat6);
          
          out_v.vertex.xyw = u_xlat0.xyw;
          
          u_xlat0.x = (-u_xlat6) + u_xlat1.x;
          
          out_v.vertex.z = unity_LightShadowBias.y * u_xlat0.x + u_xlat6;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          out_f.color = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "VertexLit"
}
