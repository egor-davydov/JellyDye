// Upgrade NOTE: commented out 'float3 _WorldSpaceCameraPos', a built-in variable

Shader "Pro 2/User/RefShader"
{
  Properties
  {
    [TCP2HeaderHelp(Base)] _Color ("Color", Color) = (1,1,1,1)
    [TCP2ColorNoAlpha] _HColor ("Highlight Color", Color) = (0.75,0.75,0.75,1)
    [TCP2ColorNoAlpha] _SColor ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _MainTex ("Albedo", 2D) = "white" {}
    [TCP2Separator] [TCP2Header(Ramp Shading)] _RampThreshold ("Threshold", Range(0.01, 1)) = 0.5
    _RampSmoothing ("Smoothing", Range(0.001, 1)) = 0.1
    [TCP2Separator] [TCP2HeaderHelp(Specular)] [TCP2ColorNoAlpha] _SpecularColor ("Specular Color", Color) = (0.5,0.5,0.5,1)
    _SpecularToonSize ("Toon Size", Range(0, 1)) = 0.25
    _SpecularToonSmoothness ("Toon Smoothness", Range(0.001, 0.5)) = 0.05
    [TCP2Separator] [TCP2HeaderHelp(Rim Outline)] [Toggle(TCP2_RIM_OUTLINE)] _UseRim ("Enable Rim Outline", float) = 0
    [TCP2ColorNoAlpha] _RimColor ("Rim Color", Color) = (0.8,0.8,0.8,0.5)
    _RimMin ("Rim Min", Range(0, 2)) = 0.5
    _RimMax ("Rim Max", Range(0, 2)) = 1
    _RimDir ("Rim Direction", Vector) = (0,0,1,1)
    [TCP2Separator] [HideInInspector] __dummy__ ("unused", float) = 0
  }
  SubShader
  {
    Tags
    { 
      "IgnoreProjectors" = "true"
      "QUEUE" = "Transparent"
      "RenderType" = "Transparent"
    }
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "IgnoreProjectors" = "true"
        "LIGHTMODE" = "FORWARDBASE"
        "QUEUE" = "Transparent"
        "RenderType" = "Transparent"
        "SHADOWSUPPORT" = "true"
      }
      Blend One OneMinusSrcAlpha
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_SHBr;
      
      uniform float4 unity_SHBg;
      
      uniform float4 unity_SHBb;
      
      uniform float4 unity_SHC;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_SHAr;
      
      uniform float4 unity_SHAg;
      
      uniform float4 unity_SHAb;
      
      uniform float4 _LightColor0;
      
      uniform float4 _Color;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmoothing;
      
      uniform float3 _HColor;
      
      uniform float3 _SColor;
      
      uniform float _SpecularToonSize;
      
      uniform float _SpecularToonSmoothness;
      
      uniform float3 _SpecularColor;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float2 texcoord3 : TEXCOORD3;
          
          float3 texcoord4 : TEXCOORD4;
          
          float4 texcoord6 : TEXCOORD6;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord4 : TEXCOORD4;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat16_0;
      
      float4 u_xlat1;
      
      float u_xlat16_2;
      
      float3 u_xlat16_3;
      
      float u_xlat12;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          out_v.texcoord1.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat0 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat0 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat0;
          
          u_xlat0 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat0;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat0;
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat12 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat12 = inversesqrt(u_xlat12);
          
          u_xlat0.xyz = float3(u_xlat12) * u_xlat0.xyz;
          
          out_v.texcoord.xyz = u_xlat0.xyz;
          
          out_v.texcoord2.xyz = float3(0.0, 0.0, 0.0);
          
          out_v.texcoord3.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat16_2 = u_xlat0.y * u_xlat0.y;
          
          u_xlat16_2 = u_xlat0.x * u_xlat0.x + (-u_xlat16_2);
          
          u_xlat16_0 = u_xlat0.yzzx * u_xlat0.xyzz;
          
          u_xlat16_3.x = dot(unity_SHBr, u_xlat16_0);
          
          u_xlat16_3.y = dot(unity_SHBg, u_xlat16_0);
          
          u_xlat16_3.z = dot(unity_SHBb, u_xlat16_0);
          
          out_v.texcoord4.xyz = unity_SHC.xyz * float3(u_xlat16_2) + u_xlat16_3.xyz;
          
          out_v.texcoord6 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float4 u_xlat1_d;
      
      float3 u_xlat16_1;
      
      float3 u_xlat16_2_d;
      
      float3 u_xlat3;
      
      float3 u_xlat4;
      
      float u_xlat5;
      
      float u_xlat16_6;
      
      float u_xlat8;
      
      float u_xlat10;
      
      float u_xlat15;
      
      float u_xlat16_16;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat15 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat15 = inversesqrt(u_xlat15);
          
          u_xlat16_1.xyz = u_xlat0_d.xyz * float3(u_xlat15) + _WorldSpaceLightPos0.xyz;
          
          u_xlat16_16 = dot(u_xlat16_1.xyz, u_xlat16_1.xyz);
          
          u_xlat16_16 = inversesqrt(u_xlat16_16);
          
          u_xlat16_1.xyz = float3(u_xlat16_16) * u_xlat16_1.xyz;
          
          u_xlat16_16 = dot(in_f.texcoord.xyz, in_f.texcoord.xyz);
          
          u_xlat16_16 = inversesqrt(u_xlat16_16);
          
          u_xlat16_2_d.xyz = float3(u_xlat16_16) * in_f.texcoord.xyz;
          
          u_xlat16_1.x = dot(u_xlat16_2_d.xyz, u_xlat16_1.xyz);
          
          u_xlat16_6 = dot(u_xlat16_2_d.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_6 = clamp(u_xlat16_6, 0.0, 1.0);
          
          u_xlat16_1.x = max(u_xlat16_1.x, 0.0);
          
          u_xlat0_d.x = _SpecularToonSmoothness + 1.0;
          
          u_xlat0_d.x = u_xlat16_1.x / u_xlat0_d.x;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlat5 = _SpecularToonSmoothness + _SpecularToonSize;
          
          u_xlat0_d.x = (-u_xlat5) + u_xlat0_d.x;
          
          u_xlat10 = (-_SpecularToonSmoothness) + _SpecularToonSize;
          
          u_xlat5 = (-u_xlat5) + u_xlat10;
          
          u_xlat5 = float(1.0) / u_xlat5;
          
          u_xlat0_d.x = u_xlat5 * u_xlat0_d.x;
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat5 = u_xlat0_d.x * -2.0 + 3.0;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat5;
          
          u_xlat0_d.x = u_xlat16_6 * u_xlat0_d.x;
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat15 = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat3.x = (-u_xlat15) + u_xlat16_6;
          
          u_xlat8 = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat15 = (-u_xlat15) + u_xlat8;
          
          u_xlat15 = float(1.0) / u_xlat15;
          
          u_xlat15 = u_xlat15 * u_xlat3.x;
          
          u_xlat15 = clamp(u_xlat15, 0.0, 1.0);
          
          u_xlat3.x = u_xlat15 * -2.0 + 3.0;
          
          u_xlat15 = u_xlat15 * u_xlat15;
          
          u_xlat15 = u_xlat15 * u_xlat3.x;
          
          u_xlat3.xyz = _HColor.xyz + (-_SColor.xyz);
          
          u_xlat3.xyz = float3(u_xlat15) * u_xlat3.xyz + _SColor.xyz;
          
          u_xlat1_d.xyz = in_f.texcoord.xyz;
          
          u_xlat1_d.w = 1.0;
          
          u_xlat16_2_d.x = dot(unity_SHAr, u_xlat1_d);
          
          u_xlat16_2_d.y = dot(unity_SHAg, u_xlat1_d);
          
          u_xlat16_2_d.z = dot(unity_SHAb, u_xlat1_d);
          
          u_xlat16_2_d.xyz = u_xlat16_2_d.xyz + in_f.texcoord4.xyz;
          
          u_xlat16_2_d.xyz = max(u_xlat16_2_d.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat4.xyz = log2(u_xlat16_2_d.xyz);
          
          u_xlat4.xyz = u_xlat4.xyz * float3(0.416666657, 0.416666657, 0.416666657);
          
          u_xlat4.xyz = exp2(u_xlat4.xyz);
          
          u_xlat4.xyz = u_xlat4.xyz * float3(1.05499995, 1.05499995, 1.05499995) + float3(-0.0549999997, -0.0549999997, -0.0549999997);
          
          u_xlat4.xyz = max(u_xlat4.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat4.xyz = u_xlat4.xyz * _Color.xyz;
          
          u_xlat16_2_d.xyz = _LightColor0.xyz * _Color.xyz;
          
          u_xlat16_2_d.xyz = u_xlat16_2_d.xyz * u_xlat3.xyz + u_xlat4.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * _SpecularColor.xyz + u_xlat16_2_d.xyz;
          
          out_f.color.xyz = u_xlat0_d.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "IgnoreProjectors" = "true"
        "LIGHTMODE" = "FORWARDADD"
        "QUEUE" = "Transparent"
        "RenderType" = "Transparent"
      }
      ZWrite Off
      Blend One One
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile POINT
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 unity_WorldToLight[4];
      
      uniform float4 _MainTex_ST;
      
      // uniform float3 _WorldSpaceCameraPos;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 _LightColor0;
      
      uniform float4 _Color;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmoothing;
      
      uniform float3 _HColor;
      
      uniform float _SpecularToonSize;
      
      uniform float _SpecularToonSmoothness;
      
      uniform float3 _SpecularColor;
      
      uniform sampler2D _LightTexture0;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float2 texcoord3 : TEXCOORD3;
          
          float3 texcoord4 : TEXCOORD4;
          
          float4 texcoord5 : TEXCOORD5;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      float u_xlat10;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat2 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat2;
          
          u_xlat2 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat2;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat2;
          
          u_xlat1.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat1.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat1.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat10 = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat10 = inversesqrt(u_xlat10);
          
          out_v.texcoord.xyz = float3(u_xlat10) * u_xlat1.xyz;
          
          out_v.texcoord1.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat0 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat0;
          
          out_v.texcoord2.xyz = float3(0.0, 0.0, 0.0);
          
          out_v.texcoord3.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat1.xyz = unity_WorldToLight[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = unity_WorldToLight[2].xyz * u_xlat0.zzz + u_xlat1.xyz;
          
          out_v.texcoord4.xyz = unity_WorldToLight[3].xyz * u_xlat0.www + u_xlat0.xyz;
          
          out_v.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat1_d;
      
      float4 u_xlat16_2;
      
      float3 u_xlat16_3;
      
      float3 u_xlat4;
      
      float u_xlat5;
      
      float u_xlat16_6;
      
      float u_xlat8;
      
      float u_xlat16_10;
      
      float u_xlat12;
      
      float u_xlat16_14;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceLightPos0.xyz;
          
          u_xlat12 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat12 = inversesqrt(u_xlat12);
          
          u_xlat0_d.xyz = float3(u_xlat12) * u_xlat0_d.xyz;
          
          u_xlat1_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat12 = dot(u_xlat1_d.xyz, u_xlat1_d.xyz);
          
          u_xlat12 = inversesqrt(u_xlat12);
          
          u_xlat16_2.xyz = u_xlat1_d.xyz * float3(u_xlat12) + u_xlat0_d.xyz;
          
          u_xlat16_14 = dot(u_xlat16_2.xyz, u_xlat16_2.xyz);
          
          u_xlat16_14 = inversesqrt(u_xlat16_14);
          
          u_xlat16_2.xyz = float3(u_xlat16_14) * u_xlat16_2.xyz;
          
          u_xlat16_14 = dot(in_f.texcoord.xyz, in_f.texcoord.xyz);
          
          u_xlat16_14 = inversesqrt(u_xlat16_14);
          
          u_xlat16_3.xyz = float3(u_xlat16_14) * in_f.texcoord.xyz;
          
          u_xlat16_2.x = dot(u_xlat16_3.xyz, u_xlat16_2.xyz);
          
          u_xlat16_6 = dot(u_xlat16_3.xyz, u_xlat0_d.xyz);
          
          u_xlat16_6 = clamp(u_xlat16_6, 0.0, 1.0);
          
          u_xlat16_2.x = max(u_xlat16_2.x, 0.0);
          
          u_xlat0_d.x = _SpecularToonSmoothness + 1.0;
          
          u_xlat0_d.x = u_xlat16_2.x / u_xlat0_d.x;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlat4.x = _SpecularToonSmoothness + _SpecularToonSize;
          
          u_xlat0_d.x = (-u_xlat4.x) + u_xlat0_d.x;
          
          u_xlat8 = (-_SpecularToonSmoothness) + _SpecularToonSize;
          
          u_xlat4.x = (-u_xlat4.x) + u_xlat8;
          
          u_xlat4.x = float(1.0) / u_xlat4.x;
          
          u_xlat0_d.x = u_xlat4.x * u_xlat0_d.x;
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat4.x = u_xlat0_d.x * -2.0 + 3.0;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat4.x;
          
          u_xlat0_d.x = u_xlat16_6 * u_xlat0_d.x;
          
          u_xlat4.xyz = in_f.texcoord1.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat4.xyz = unity_WorldToLight[0].xyz * in_f.texcoord1.xxx + u_xlat4.xyz;
          
          u_xlat4.xyz = unity_WorldToLight[2].xyz * in_f.texcoord1.zzz + u_xlat4.xyz;
          
          u_xlat4.xyz = u_xlat4.xyz + unity_WorldToLight[3].xyz;
          
          u_xlat4.x = dot(u_xlat4.xyz, u_xlat4.xyz);
          
          u_xlat4.x = texture2D(_LightTexture0, u_xlat4.xx).x;
          
          u_xlat16_2.xzw = u_xlat4.xxx * _LightColor0.xyz;
          
          u_xlat16_10 = max(u_xlat16_2.w, u_xlat16_2.z);
          
          u_xlat16_2.x = max(u_xlat16_10, u_xlat16_2.x);
          
          u_xlat16_10 = max(_LightColor0.z, _LightColor0.y);
          
          u_xlat16_10 = max(u_xlat16_10, _LightColor0.x);
          
          u_xlat16_2.x = u_xlat16_2.x / u_xlat16_10;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat16_2.x;
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * _SpecularColor.xyz;
          
          u_xlat12 = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat1_d.x = (-u_xlat12) + u_xlat16_6;
          
          u_xlat5 = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat12 = (-u_xlat12) + u_xlat5;
          
          u_xlat12 = float(1.0) / u_xlat12;
          
          u_xlat12 = u_xlat12 * u_xlat1_d.x;
          
          u_xlat12 = clamp(u_xlat12, 0.0, 1.0);
          
          u_xlat1_d.x = u_xlat12 * -2.0 + 3.0;
          
          u_xlat12 = u_xlat12 * u_xlat12;
          
          u_xlat12 = u_xlat12 * u_xlat1_d.x;
          
          u_xlat16_2.x = u_xlat16_2.x * u_xlat12;
          
          u_xlat1_d.xyz = u_xlat16_2.xxx * _HColor.xyz;
          
          u_xlat16_2.xyz = _LightColor0.xyz * _Color.xyz;
          
          u_xlat0_d.xyz = u_xlat16_2.xyz * u_xlat1_d.xyz + u_xlat0_d.xyz;
          
          out_f.color.xyz = u_xlat0_d.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
