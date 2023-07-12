// Upgrade NOTE: commented out 'float3 _WorldSpaceCameraPos', a built-in variable

Shader "Pro 2/User/JellyShader"
{
  Properties
  {
    [TCP2HeaderHelp(Base)] _Color ("Color", Color) = (1,1,1,1)
    [TCP2ColorNoAlpha] _HColor ("Highlight Color", Color) = (0.75,0.75,0.75,1)
    [TCP2ColorNoAlpha] _SColor ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _MainTex ("Albedo", 2D) = "white" {}
    _BumpMap ("Normal Map", 2D) = "bump" {}
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
    _Location ("Location", Vector) = (0,0,1,0)
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
      
      uniform float4 unity_WorldTransformParams;
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _BumpMap_ST;
      
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
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _BumpMap;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
          
          float4 tangent : TANGENT0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
          
          float4 texcoord7 : TEXCOORD7;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float4 texcoord4 : TEXCOORD4;
          
          float3 texcoord5 : TEXCOORD5;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat16_0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      float3 u_xlat3;
      
      float u_xlat16_4;
      
      float3 u_xlat16_5;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat0.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat2 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat2 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat2;
          
          u_xlat2 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat2;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat2;
          
          out_v.texcoord.w = u_xlat0.x;
          
          u_xlat1.xyz = in_v.tangent.yyy * unity_ObjectToWorld[1].yzx;
          
          u_xlat1.xyz = unity_ObjectToWorld[0].yzx * in_v.tangent.xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[2].yzx * in_v.tangent.zzz + u_xlat1.xyz;
          
          u_xlat0.x = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat0.x = inversesqrt(u_xlat0.x);
          
          u_xlat1.xyz = u_xlat0.xxx * u_xlat1.xyz;
          
          out_v.texcoord.x = u_xlat1.z;
          
          u_xlat2.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat2.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat2.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat0.x = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat0.x = inversesqrt(u_xlat0.x);
          
          u_xlat2 = u_xlat0.xxxx * u_xlat2.xyzz;
          
          u_xlat3.xyz = u_xlat1.xyz * u_xlat2.wxy;
          
          u_xlat3.xyz = u_xlat2.ywx * u_xlat1.yzx + (-u_xlat3.xyz);
          
          u_xlat0.x = in_v.tangent.w * unity_WorldTransformParams.w;
          
          u_xlat3.xyz = u_xlat0.xxx * u_xlat3.xyz;
          
          out_v.texcoord.y = u_xlat3.x;
          
          out_v.texcoord.z = u_xlat2.x;
          
          out_v.texcoord1.x = u_xlat1.x;
          
          out_v.texcoord2.x = u_xlat1.y;
          
          out_v.texcoord1.w = u_xlat0.y;
          
          out_v.texcoord2.w = u_xlat0.z;
          
          out_v.texcoord1.y = u_xlat3.y;
          
          out_v.texcoord2.y = u_xlat3.z;
          
          out_v.texcoord1.z = u_xlat2.y;
          
          out_v.texcoord2.z = u_xlat2.w;
          
          out_v.texcoord3.xyz = float3(0.0, 0.0, 0.0);
          
          out_v.texcoord4.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          out_v.texcoord4.zw = in_v.texcoord.xy * _BumpMap_ST.xy + _BumpMap_ST.zw;
          
          u_xlat16_4 = u_xlat2.y * u_xlat2.y;
          
          u_xlat16_4 = u_xlat2.x * u_xlat2.x + (-u_xlat16_4);
          
          u_xlat16_0 = u_xlat2.ywzx * u_xlat2;
          
          u_xlat16_5.x = dot(unity_SHBr, u_xlat16_0);
          
          u_xlat16_5.y = dot(unity_SHBg, u_xlat16_0);
          
          u_xlat16_5.z = dot(unity_SHBb, u_xlat16_0);
          
          out_v.texcoord5.xyz = unity_SHC.xyz * float3(u_xlat16_4) + u_xlat16_5.xyz;
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float4 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      float3 u_xlat16_1;
      
      float4 u_xlat2_d;
      
      float3 u_xlat16_2;
      
      float3 u_xlat16_3;
      
      float3 u_xlat4;
      
      float3 u_xlat5;
      
      float3 u_xlat6;
      
      float3 u_xlat16_8;
      
      float u_xlat11;
      
      float u_xlat18;
      
      float u_xlat21;
      
      float u_xlat16_22;
      
      float u_xlat25;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = in_f.texcoord.w;
          
          u_xlat0_d.y = in_f.texcoord1.w;
          
          u_xlat0_d.z = in_f.texcoord2.w;
          
          u_xlat0_d.xyz = (-u_xlat0_d.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat21 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat21 = inversesqrt(u_xlat21);
          
          u_xlat16_1.xyz = u_xlat0_d.xyz * float3(u_xlat21) + _WorldSpaceLightPos0.xyz;
          
          u_xlat16_22 = dot(u_xlat16_1.xyz, u_xlat16_1.xyz);
          
          u_xlat16_22 = inversesqrt(u_xlat16_22);
          
          u_xlat16_1.xyz = float3(u_xlat16_22) * u_xlat16_1.xyz;
          
          u_xlat10_0.xyz = texture2D(_BumpMap, in_f.texcoord4.zw).xyz;
          
          u_xlat16_2.xyz = u_xlat10_0.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
          
          u_xlat16_3.x = dot(in_f.texcoord.xyz, u_xlat16_2.xyz);
          
          u_xlat16_3.y = dot(in_f.texcoord1.xyz, u_xlat16_2.xyz);
          
          u_xlat16_3.z = dot(in_f.texcoord2.xyz, u_xlat16_2.xyz);
          
          u_xlat0_d.x = dot(u_xlat16_3.xyz, u_xlat16_3.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * u_xlat16_3.xyz;
          
          u_xlat16_1.x = dot(u_xlat0_d.xyz, u_xlat16_1.xyz);
          
          u_xlat16_1.x = max(u_xlat16_1.x, 0.0);
          
          u_xlat4.x = _SpecularToonSmoothness + 1.0;
          
          u_xlat4.x = u_xlat16_1.x / u_xlat4.x;
          
          u_xlat4.x = (-u_xlat4.x) + 1.0;
          
          u_xlat11 = _SpecularToonSmoothness + _SpecularToonSize;
          
          u_xlat4.x = (-u_xlat11) + u_xlat4.x;
          
          u_xlat18 = (-_SpecularToonSmoothness) + _SpecularToonSize;
          
          u_xlat11 = (-u_xlat11) + u_xlat18;
          
          u_xlat11 = float(1.0) / u_xlat11;
          
          u_xlat4.x = u_xlat11 * u_xlat4.x;
          
          u_xlat4.x = clamp(u_xlat4.x, 0.0, 1.0);
          
          u_xlat11 = u_xlat4.x * -2.0 + 3.0;
          
          u_xlat4.x = u_xlat4.x * u_xlat4.x;
          
          u_xlat4.x = u_xlat4.x * u_xlat11;
          
          u_xlat16_1.x = dot(u_xlat0_d.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_1.x = clamp(u_xlat16_1.x, 0.0, 1.0);
          
          u_xlat4.x = u_xlat16_1.x * u_xlat4.x;
          
          u_xlat4.xyz = u_xlat4.xxx * _LightColor0.xyz;
          
          u_xlat0_d.w = 1.0;
          
          u_xlat16_2.x = dot(unity_SHAr, u_xlat0_d);
          
          u_xlat16_2.y = dot(unity_SHAg, u_xlat0_d);
          
          u_xlat16_2.z = dot(unity_SHAb, u_xlat0_d);
          
          u_xlat16_8.xyz = u_xlat16_2.xyz + in_f.texcoord5.xyz;
          
          u_xlat16_8.xyz = max(u_xlat16_8.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat0_d.xyz = log2(u_xlat16_8.xyz);
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * float3(0.416666657, 0.416666657, 0.416666657);
          
          u_xlat0_d.xyz = exp2(u_xlat0_d.xyz);
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * float3(1.05499995, 1.05499995, 1.05499995) + float3(-0.0549999997, -0.0549999997, -0.0549999997);
          
          u_xlat0_d.xyz = max(u_xlat0_d.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat5.xyz = (-_Color.xyz) + float3(1.0, 1.0, 1.0);
          
          u_xlat2_d = texture2D(_MainTex, in_f.texcoord4.xy);
          
          u_xlat5.xyz = u_xlat2_d.www * u_xlat5.xyz + _Color.xyz;
          
          u_xlat5.xyz = u_xlat2_d.xyz * u_xlat5.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * u_xlat5.xyz;
          
          u_xlat16_8.xyz = u_xlat5.xyz * _LightColor0.xyz;
          
          u_xlat21 = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat25 = (-u_xlat21) + u_xlat16_1.x;
          
          u_xlat5.x = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat21 = (-u_xlat21) + u_xlat5.x;
          
          u_xlat21 = float(1.0) / u_xlat21;
          
          u_xlat21 = u_xlat21 * u_xlat25;
          
          u_xlat21 = clamp(u_xlat21, 0.0, 1.0);
          
          u_xlat25 = u_xlat21 * -2.0 + 3.0;
          
          u_xlat21 = u_xlat21 * u_xlat21;
          
          u_xlat21 = u_xlat21 * u_xlat25;
          
          u_xlat5.xyz = (-_HColor.xyz) + float3(1.0, 1.0, 1.0);
          
          u_xlat5.xyz = u_xlat2_d.www * u_xlat5.xyz + _HColor.xyz;
          
          u_xlat6.xyz = (-_SColor.xyz) + float3(0.800000012, 0.800000012, 0.800000012);
          
          u_xlat6.xyz = u_xlat2_d.www * u_xlat6.xyz + _SColor.xyz;
          
          u_xlat5.xyz = u_xlat5.xyz + (-u_xlat6.xyz);
          
          u_xlat5.xyz = float3(u_xlat21) * u_xlat5.xyz + u_xlat6.xyz;
          
          u_xlat16_1.xyz = u_xlat16_8.xyz * u_xlat5.xyz + u_xlat0_d.xyz;
          
          u_xlat2_d.xyz = u_xlat4.xyz * _SpecularColor.xyz + u_xlat16_1.xyz;
          
          out_f.color = u_xlat2_d;
          
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
      
      uniform float4 unity_WorldTransformParams;
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 unity_WorldToLight[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _BumpMap_ST;
      
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
      
      uniform sampler2D _MainTex;
      
      uniform sampler2D _BumpMap;
      
      uniform sampler2D _LightTexture0;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
          
          float4 tangent : TANGENT0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float3 texcoord4 : TEXCOORD4;
          
          float4 texcoord5 : TEXCOORD5;
          
          float3 texcoord6 : TEXCOORD6;
          
          float4 texcoord7 : TEXCOORD7;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float4 texcoord5 : TEXCOORD5;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      float3 u_xlat3;
      
      float u_xlat13;
      
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
          
          u_xlat1.y = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat1.z = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat1.x = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat13 = dot(u_xlat1.xyz, u_xlat1.xyz);
          
          u_xlat13 = inversesqrt(u_xlat13);
          
          u_xlat1.xyz = float3(u_xlat13) * u_xlat1.xyz;
          
          u_xlat2.xyz = in_v.tangent.yyy * unity_ObjectToWorld[1].yzx;
          
          u_xlat2.xyz = unity_ObjectToWorld[0].yzx * in_v.tangent.xxx + u_xlat2.xyz;
          
          u_xlat2.xyz = unity_ObjectToWorld[2].yzx * in_v.tangent.zzz + u_xlat2.xyz;
          
          u_xlat13 = dot(u_xlat2.xyz, u_xlat2.xyz);
          
          u_xlat13 = inversesqrt(u_xlat13);
          
          u_xlat2.xyz = float3(u_xlat13) * u_xlat2.xyz;
          
          u_xlat3.xyz = u_xlat1.xyz * u_xlat2.xyz;
          
          u_xlat3.xyz = u_xlat1.zxy * u_xlat2.yzx + (-u_xlat3.xyz);
          
          u_xlat13 = in_v.tangent.w * unity_WorldTransformParams.w;
          
          u_xlat3.xyz = float3(u_xlat13) * u_xlat3.xyz;
          
          out_v.texcoord.y = u_xlat3.x;
          
          out_v.texcoord.x = u_xlat2.z;
          
          out_v.texcoord.z = u_xlat1.y;
          
          out_v.texcoord1.x = u_xlat2.x;
          
          out_v.texcoord2.x = u_xlat2.y;
          
          out_v.texcoord1.z = u_xlat1.z;
          
          out_v.texcoord2.z = u_xlat1.x;
          
          out_v.texcoord1.y = u_xlat3.y;
          
          out_v.texcoord2.y = u_xlat3.z;
          
          out_v.texcoord3.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat0 = unity_ObjectToWorld[3] * in_v.vertex.wwww + u_xlat0;
          
          out_v.texcoord4.xyz = float3(0.0, 0.0, 0.0);
          
          out_v.texcoord5.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          out_v.texcoord5.zw = in_v.texcoord.xy * _BumpMap_ST.xy + _BumpMap_ST.zw;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat1.xyz = unity_WorldToLight[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = unity_WorldToLight[2].xyz * u_xlat0.zzz + u_xlat1.xyz;
          
          out_v.texcoord6.xyz = unity_WorldToLight[3].xyz * u_xlat0.www + u_xlat0.xyz;
          
          out_v.texcoord7 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat1_d;
      
      float3 u_xlat10_1;
      
      float4 u_xlat16_2;
      
      float4 u_xlat3_d;
      
      float3 u_xlat16_3;
      
      float3 u_xlat16_4;
      
      float3 u_xlat5;
      
      float3 u_xlat6;
      
      float u_xlat7;
      
      float u_xlat16_8;
      
      float u_xlat12;
      
      float u_xlat16_14;
      
      float u_xlat18;
      
      float u_xlat16_20;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xyz = (-in_f.texcoord3.xyz) + _WorldSpaceLightPos0.xyz;
          
          u_xlat18 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat18 = inversesqrt(u_xlat18);
          
          u_xlat0_d.xyz = float3(u_xlat18) * u_xlat0_d.xyz;
          
          u_xlat1_d.xyz = (-in_f.texcoord3.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat18 = dot(u_xlat1_d.xyz, u_xlat1_d.xyz);
          
          u_xlat18 = inversesqrt(u_xlat18);
          
          u_xlat16_2.xyz = u_xlat1_d.xyz * float3(u_xlat18) + u_xlat0_d.xyz;
          
          u_xlat16_20 = dot(u_xlat16_2.xyz, u_xlat16_2.xyz);
          
          u_xlat16_20 = inversesqrt(u_xlat16_20);
          
          u_xlat16_2.xyz = float3(u_xlat16_20) * u_xlat16_2.xyz;
          
          u_xlat10_1.xyz = texture2D(_BumpMap, in_f.texcoord5.zw).xyz;
          
          u_xlat16_3.xyz = u_xlat10_1.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
          
          u_xlat16_4.x = dot(in_f.texcoord.xyz, u_xlat16_3.xyz);
          
          u_xlat16_4.y = dot(in_f.texcoord1.xyz, u_xlat16_3.xyz);
          
          u_xlat16_4.z = dot(in_f.texcoord2.xyz, u_xlat16_3.xyz);
          
          u_xlat18 = dot(u_xlat16_4.xyz, u_xlat16_4.xyz);
          
          u_xlat18 = inversesqrt(u_xlat18);
          
          u_xlat1_d.xyz = float3(u_xlat18) * u_xlat16_4.xyz;
          
          u_xlat16_2.x = dot(u_xlat1_d.xyz, u_xlat16_2.xyz);
          
          u_xlat16_8 = dot(u_xlat1_d.xyz, u_xlat0_d.xyz);
          
          u_xlat16_8 = clamp(u_xlat16_8, 0.0, 1.0);
          
          u_xlat16_2.x = max(u_xlat16_2.x, 0.0);
          
          u_xlat0_d.x = _SpecularToonSmoothness + 1.0;
          
          u_xlat0_d.x = u_xlat16_2.x / u_xlat0_d.x;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlat6.x = _SpecularToonSmoothness + _SpecularToonSize;
          
          u_xlat0_d.x = (-u_xlat6.x) + u_xlat0_d.x;
          
          u_xlat12 = (-_SpecularToonSmoothness) + _SpecularToonSize;
          
          u_xlat6.x = (-u_xlat6.x) + u_xlat12;
          
          u_xlat6.x = float(1.0) / u_xlat6.x;
          
          u_xlat0_d.x = u_xlat6.x * u_xlat0_d.x;
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat6.x = u_xlat0_d.x * -2.0 + 3.0;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat6.x;
          
          u_xlat0_d.x = u_xlat16_8 * u_xlat0_d.x;
          
          u_xlat6.xyz = in_f.texcoord3.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat6.xyz = unity_WorldToLight[0].xyz * in_f.texcoord3.xxx + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_WorldToLight[2].xyz * in_f.texcoord3.zzz + u_xlat6.xyz;
          
          u_xlat6.xyz = u_xlat6.xyz + unity_WorldToLight[3].xyz;
          
          u_xlat6.x = dot(u_xlat6.xyz, u_xlat6.xyz);
          
          u_xlat6.x = texture2D(_LightTexture0, u_xlat6.xx).x;
          
          u_xlat16_2.xzw = u_xlat6.xxx * _LightColor0.xyz;
          
          u_xlat16_14 = max(u_xlat16_2.w, u_xlat16_2.z);
          
          u_xlat16_2.x = max(u_xlat16_14, u_xlat16_2.x);
          
          u_xlat16_14 = max(_LightColor0.z, _LightColor0.y);
          
          u_xlat16_14 = max(u_xlat16_14, _LightColor0.x);
          
          u_xlat16_2.x = u_xlat16_2.x / u_xlat16_14;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat16_2.x;
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * _SpecularColor.xyz;
          
          u_xlat18 = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat1_d.x = (-u_xlat18) + u_xlat16_8;
          
          u_xlat7 = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat18 = (-u_xlat18) + u_xlat7;
          
          u_xlat18 = float(1.0) / u_xlat18;
          
          u_xlat18 = u_xlat18 * u_xlat1_d.x;
          
          u_xlat18 = clamp(u_xlat18, 0.0, 1.0);
          
          u_xlat1_d.x = u_xlat18 * -2.0 + 3.0;
          
          u_xlat18 = u_xlat18 * u_xlat18;
          
          u_xlat18 = u_xlat18 * u_xlat1_d.x;
          
          u_xlat16_2.x = u_xlat16_2.x * u_xlat18;
          
          u_xlat1_d.xyz = (-_HColor.xyz) + float3(1.0, 1.0, 1.0);
          
          u_xlat3_d = texture2D(_MainTex, in_f.texcoord5.xy);
          
          u_xlat1_d.xyz = u_xlat3_d.www * u_xlat1_d.xyz + _HColor.xyz;
          
          u_xlat1_d.xyz = u_xlat1_d.xyz * u_xlat16_2.xxx;
          
          u_xlat5.xyz = (-_Color.xyz) + float3(1.0, 1.0, 1.0);
          
          u_xlat5.xyz = u_xlat3_d.www * u_xlat5.xyz + _Color.xyz;
          
          u_xlat5.xyz = u_xlat3_d.xyz * u_xlat5.xyz;
          
          u_xlat16_2.xyz = u_xlat5.xyz * _LightColor0.xyz;
          
          u_xlat3_d.xyz = u_xlat16_2.xyz * u_xlat1_d.xyz + u_xlat0_d.xyz;
          
          out_f.color = u_xlat3_d;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
