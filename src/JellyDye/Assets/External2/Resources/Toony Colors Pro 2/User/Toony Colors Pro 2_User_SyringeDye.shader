// Upgrade NOTE: commented out 'float3 _WorldSpaceCameraPos', a built-in variable

Shader "Toony Colors Pro 2/User/SyringeDye"
{
  Properties
  {
    [TCP2HeaderHelp(Base)] _Color ("Color", Color) = (1,1,1,1)
    [TCP2ColorNoAlpha] _HColor ("Highlight Color", Color) = (0.75,0.75,0.75,1)
    [TCP2ColorNoAlpha] _SColor ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _MainTex ("Albedo", 2D) = "white" {}
    [TCP2Separator] [TCP2Header(Ramp Shading)] _RampThreshold ("Threshold", Range(0.01, 1)) = 0.5
    _RampSmoothing ("Smoothing", Range(0.001, 1)) = 0.1
    [TCP2Separator] [TCP2Header(Dye)] _DyePercentages ("DyeSize", Vector) = (0,0,0,0)
    _DyeSize ("DyeSize", Range(0.001, 1)) = 0.1
    _ColorCount ("ColorCount", Range(0.001, 3)) = 0.1
    _Color1 ("Color", Color) = (1,1,1,1)
    _SColor1 ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _Color2 ("Color", Color) = (1,1,1,1)
    _SColor2 ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _Color3 ("Color", Color) = (1,1,1,1)
    _SColor3 ("Shadow Color", Color) = (0.2,0.2,0.2,1)
    _Highlight ("Highlight", Range(0, 1)) = 0
    [TCP2Separator] [TCP2HeaderHelp(Specular)] [TCP2ColorNoAlpha] _SpecularColor ("Specular Color", Color) = (0.5,0.5,0.5,1)
    _SpecularToonSize ("Toon Size", Range(0, 1)) = 0.25
    _SpecularToonSmoothness ("Toon Smoothness", Range(0.001, 0.5)) = 0.05
    [TCP2Separator] [HideInInspector] __dummy__ ("unused", float) = 0
  }
  SubShader
  {
    Tags
    { 
      "RenderType" = "Opaque"
    }
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDBASE"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
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
      
      uniform float4 _Color1;
      
      uniform float4 _Color2;
      
      uniform float4 _Color3;
      
      uniform float4 _SColor1;
      
      uniform float4 _SColor2;
      
      uniform float4 _SColor3;
      
      uniform float _RampThreshold;
      
      uniform float _Highlight;
      
      uniform float _RampSmoothing;
      
      uniform float _DyeSize;
      
      uniform float3 _HColor;
      
      uniform float3 _SColor;
      
      uniform float _SpecularToonSize;
      
      uniform float _SpecularToonSmoothness;
      
      uniform float3 _SpecularColor;
      
      uniform float4 _DyePercentages;
      
      uniform sampler2D _MainTex;
      
      
      
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
          
          float2 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float4 texcoord5 : TEXCOORD5;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float2 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
      
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
          
          out_v.texcoord2.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat16_2 = u_xlat0.y * u_xlat0.y;
          
          u_xlat16_2 = u_xlat0.x * u_xlat0.x + (-u_xlat16_2);
          
          u_xlat16_0 = u_xlat0.yzzx * u_xlat0.xyzz;
          
          u_xlat16_3.x = dot(unity_SHBr, u_xlat16_0);
          
          u_xlat16_3.y = dot(unity_SHBg, u_xlat16_0);
          
          u_xlat16_3.z = dot(unity_SHBb, u_xlat16_0);
          
          out_v.texcoord3.xyz = unity_SHC.xyz * float3(u_xlat16_2) + u_xlat16_3.xyz;
          
          out_v.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      int u_xlatb0;
      
      float3 u_xlat16_1;
      
      float4 u_xlat2;
      
      float4 u_xlat3;
      
      float4 u_xlat10_3;
      
      float4 u_xlat4;
      
      float3 u_xlat16_5;
      
      float3 u_xlat16_6;
      
      float3 u_xlat7;
      
      float u_xlat9;
      
      float u_xlat14;
      
      float u_xlat16;
      
      float u_xlat21;
      
      float u_xlat16_22;
      
      float u_xlat16_26;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = (-in_f.texcoord2.y) + _DyeSize;
          
          u_xlatb0 = u_xlat0_d.x<0.0;
          
          if(u_xlatb0)
      {
              discard;
      }
          
          u_xlat0_d.x = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat7.x = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat0_d.x = (-u_xlat7.x) + u_xlat0_d.x;
          
          u_xlat0_d.x = float(1.0) / u_xlat0_d.x;
          
          u_xlat16_1.x = dot(in_f.texcoord.xyz, in_f.texcoord.xyz);
          
          u_xlat16_1.x = inversesqrt(u_xlat16_1.x);
          
          u_xlat16_1.xyz = u_xlat16_1.xxx * in_f.texcoord.xyz;
          
          u_xlat16_22 = dot(u_xlat16_1.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_22 = clamp(u_xlat16_22, 0.0, 1.0);
          
          u_xlat7.x = (-u_xlat7.x) + u_xlat16_22;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat7.x;
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat7.x = u_xlat0_d.x * -2.0 + 3.0;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat7.x;
          
          u_xlat7.xyz = _SColor1.xyz + (-_SColor.xyz);
          
          u_xlat2.x = in_f.texcoord2.y + (-_DyeSize);
          
          u_xlat2.x = u_xlat2.x + 1.0;
          
          u_xlat2.x = u_xlat2.x + (-_DyePercentages.x);
          
          u_xlat9 = u_xlat2.x * 1000.0;
          
          u_xlat9 = clamp(u_xlat9, 0.0, 1.0);
          
          u_xlat2.x = u_xlat2.x + (-_DyePercentages.y);
          
          u_xlat7.xyz = float3(u_xlat9) * u_xlat7.xyz + _SColor.xyz;
          
          u_xlat3.xyz = (-u_xlat7.xyz) + _SColor2.xyz;
          
          u_xlat16 = u_xlat2.x * 1000.0;
          
          u_xlat16 = clamp(u_xlat16, 0.0, 1.0);
          
          u_xlat2.x = u_xlat2.x + (-_DyePercentages.z);
          
          u_xlat2.x = u_xlat2.x * 1000.0;
          
          u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
          
          u_xlat7.xyz = float3(u_xlat16) * u_xlat3.xyz + u_xlat7.xyz;
          
          u_xlat3.xyz = (-u_xlat7.xyz) + _SColor3.xyz;
          
          u_xlat7.xyz = u_xlat2.xxx * u_xlat3.xyz + u_xlat7.xyz;
          
          u_xlat3.xyz = (-u_xlat7.xyz) + float3(1.0, 1.0, 1.0);
          
          u_xlat7.xyz = float3(float3(_Highlight, _Highlight, _Highlight)) * u_xlat3.xyz + u_xlat7.xyz;
          
          u_xlat3.xyz = (-u_xlat7.xyz) + _HColor.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * u_xlat3.xyz + u_xlat7.xyz;
          
          u_xlat3 = (-_Color.wxyz) + _Color1.wxyz;
          
          u_xlat3 = float4(u_xlat9) * u_xlat3 + _Color.wxyz;
          
          u_xlat4 = (-u_xlat3) + _Color2.wxyz;
          
          u_xlat3 = float4(u_xlat16) * u_xlat4 + u_xlat3;
          
          u_xlat4 = (-u_xlat3) + _Color3.wxyz;
          
          u_xlat2 = u_xlat2.xxxx * u_xlat4 + u_xlat3;
          
          u_xlat10_3 = texture2D(_MainTex, in_f.texcoord2.xy);
          
          u_xlat4.xyz = (-u_xlat10_3.xyz) * u_xlat2.yzw + float3(1.0, 1.0, 1.0);
          
          u_xlat2 = u_xlat2.yzwx * u_xlat10_3;
          
          u_xlat3.xyz = float3(float3(_Highlight, _Highlight, _Highlight)) * u_xlat4.xyz + u_xlat2.xyz;
          
          u_xlat4.xyz = in_f.texcoord.xyz;
          
          u_xlat4.w = 1.0;
          
          u_xlat16_5.x = dot(unity_SHAr, u_xlat4);
          
          u_xlat16_5.y = dot(unity_SHAg, u_xlat4);
          
          u_xlat16_5.z = dot(unity_SHAb, u_xlat4);
          
          u_xlat16_5.xyz = u_xlat16_5.xyz + in_f.texcoord3.xyz;
          
          u_xlat16_5.xyz = max(u_xlat16_5.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat4.xyz = log2(u_xlat16_5.xyz);
          
          u_xlat4.xyz = u_xlat4.xyz * float3(0.416666657, 0.416666657, 0.416666657);
          
          u_xlat4.xyz = exp2(u_xlat4.xyz);
          
          u_xlat4.xyz = u_xlat4.xyz * float3(1.05499995, 1.05499995, 1.05499995) + float3(-0.0549999997, -0.0549999997, -0.0549999997);
          
          u_xlat4.xyz = max(u_xlat4.xyz, float3(0.0, 0.0, 0.0));
          
          u_xlat4.xyz = u_xlat3.xyz * u_xlat4.xyz;
          
          u_xlat16_5.xyz = u_xlat3.xyz * _LightColor0.xyz;
          
          u_xlat16_5.xyz = u_xlat16_5.xyz * u_xlat0_d.xyz + u_xlat4.xyz;
          
          u_xlat0_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat21 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat21 = inversesqrt(u_xlat21);
          
          u_xlat16_6.xyz = u_xlat0_d.xyz * float3(u_xlat21) + _WorldSpaceLightPos0.xyz;
          
          u_xlat16_26 = dot(u_xlat16_6.xyz, u_xlat16_6.xyz);
          
          u_xlat16_26 = inversesqrt(u_xlat16_26);
          
          u_xlat16_6.xyz = float3(u_xlat16_26) * u_xlat16_6.xyz;
          
          u_xlat16_1.x = dot(u_xlat16_1.xyz, u_xlat16_6.xyz);
          
          u_xlat16_1.x = max(u_xlat16_1.x, 0.0);
          
          u_xlat0_d.x = _SpecularToonSmoothness + 1.0;
          
          u_xlat0_d.x = u_xlat16_1.x / u_xlat0_d.x;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlat7.x = _SpecularToonSmoothness + _SpecularToonSize;
          
          u_xlat0_d.x = (-u_xlat7.x) + u_xlat0_d.x;
          
          u_xlat14 = (-_SpecularToonSmoothness) + _SpecularToonSize;
          
          u_xlat7.x = (-u_xlat7.x) + u_xlat14;
          
          u_xlat7.x = float(1.0) / u_xlat7.x;
          
          u_xlat0_d.x = u_xlat7.x * u_xlat0_d.x;
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat7.x = u_xlat0_d.x * -2.0 + 3.0;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat0_d.x * u_xlat7.x;
          
          u_xlat0_d.x = u_xlat16_22 * u_xlat0_d.x;
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * _LightColor0.xyz;
          
          u_xlat2.xyz = u_xlat0_d.xyz * _SpecularColor.xyz + u_xlat16_5.xyz;
          
          out_f.color = u_xlat2;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDADD"
        "RenderType" = "Opaque"
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
      
      uniform float4 _Color1;
      
      uniform float4 _Color2;
      
      uniform float4 _Color3;
      
      uniform float _RampThreshold;
      
      uniform float _Highlight;
      
      uniform float _RampSmoothing;
      
      uniform float _DyeSize;
      
      uniform float3 _HColor;
      
      uniform float _SpecularToonSize;
      
      uniform float _SpecularToonSmoothness;
      
      uniform float3 _SpecularColor;
      
      uniform float4 _DyePercentages;
      
      uniform sampler2D _MainTex;
      
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
          
          float2 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float4 texcoord4 : TEXCOORD4;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float2 texcoord2 : TEXCOORD2;
      
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
          
          out_v.texcoord2.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat1.xyz = unity_WorldToLight[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = unity_WorldToLight[2].xyz * u_xlat0.zzz + u_xlat1.xyz;
          
          out_v.texcoord3.xyz = unity_WorldToLight[3].xyz * u_xlat0.www + u_xlat0.xyz;
          
          out_v.texcoord4 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      int u_xlatb0;
      
      float4 u_xlat1_d;
      
      float4 u_xlat16_2;
      
      float4 u_xlat3;
      
      float3 u_xlat16_3;
      
      float4 u_xlat10_3;
      
      float3 u_xlat4;
      
      float3 u_xlat16_5;
      
      float3 u_xlat6;
      
      float u_xlat16_8;
      
      float u_xlat10_d;
      
      float u_xlat12;
      
      float u_xlat16_14;
      
      float u_xlat18;
      
      float u_xlat16_20;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = (-in_f.texcoord2.y) + _DyeSize;
          
          u_xlatb0 = u_xlat0_d.x<0.0;
          
          if(u_xlatb0)
      {
              discard;
      }
          
          u_xlat0_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceLightPos0.xyz;
          
          u_xlat18 = dot(u_xlat0_d.xyz, u_xlat0_d.xyz);
          
          u_xlat18 = inversesqrt(u_xlat18);
          
          u_xlat0_d.xyz = float3(u_xlat18) * u_xlat0_d.xyz;
          
          u_xlat1_d.xyz = (-in_f.texcoord1.xyz) + _WorldSpaceCameraPos.xyz;
          
          u_xlat18 = dot(u_xlat1_d.xyz, u_xlat1_d.xyz);
          
          u_xlat18 = inversesqrt(u_xlat18);
          
          u_xlat16_2.xyz = u_xlat1_d.xyz * float3(u_xlat18) + u_xlat0_d.xyz;
          
          u_xlat16_20 = dot(u_xlat16_2.xyz, u_xlat16_2.xyz);
          
          u_xlat16_20 = inversesqrt(u_xlat16_20);
          
          u_xlat16_2.xyz = float3(u_xlat16_20) * u_xlat16_2.xyz;
          
          u_xlat16_20 = dot(in_f.texcoord.xyz, in_f.texcoord.xyz);
          
          u_xlat16_20 = inversesqrt(u_xlat16_20);
          
          u_xlat16_3.xyz = float3(u_xlat16_20) * in_f.texcoord.xyz;
          
          u_xlat16_2.x = dot(u_xlat16_3.xyz, u_xlat16_2.xyz);
          
          u_xlat16_8 = dot(u_xlat16_3.xyz, u_xlat0_d.xyz);
          
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
          
          u_xlat6.xyz = in_f.texcoord1.yyy * unity_WorldToLight[1].xyz;
          
          u_xlat6.xyz = unity_WorldToLight[0].xyz * in_f.texcoord1.xxx + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_WorldToLight[2].xyz * in_f.texcoord1.zzz + u_xlat6.xyz;
          
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
          
          u_xlat18 = in_f.texcoord2.y + (-_DyeSize);
          
          u_xlat18 = u_xlat18 + 1.0;
          
          u_xlat18 = u_xlat18 + (-_DyePercentages.x);
          
          u_xlat1_d.x = u_xlat18 * 1000.0;
          
          u_xlat1_d.x = clamp(u_xlat1_d.x, 0.0, 1.0);
          
          u_xlat18 = u_xlat18 + (-_DyePercentages.y);
          
          u_xlat3 = (-_Color.wxyz) + _Color1.wxyz;
          
          u_xlat1_d = u_xlat1_d.xxxx * u_xlat3 + _Color.wxyz;
          
          u_xlat3 = (-u_xlat1_d) + _Color2.wxyz;
          
          u_xlat4.x = u_xlat18 * 1000.0;
          
          u_xlat4.x = clamp(u_xlat4.x, 0.0, 1.0);
          
          u_xlat18 = u_xlat18 + (-_DyePercentages.z);
          
          u_xlat18 = u_xlat18 * 1000.0;
          
          u_xlat18 = clamp(u_xlat18, 0.0, 1.0);
          
          u_xlat1_d = u_xlat4.xxxx * u_xlat3 + u_xlat1_d;
          
          u_xlat3 = (-u_xlat1_d) + _Color3.wxyz;
          
          u_xlat1_d = float4(u_xlat18) * u_xlat3 + u_xlat1_d;
          
          u_xlat10_3 = texture2D(_MainTex, in_f.texcoord2.xy);
          
          u_xlat4.xyz = (-u_xlat10_3.xyz) * u_xlat1_d.yzw + float3(1.0, 1.0, 1.0);
          
          u_xlat1_d = u_xlat1_d.yzwx * u_xlat10_3;
          
          u_xlat4.xyz = float3(float3(_Highlight, _Highlight, _Highlight)) * u_xlat4.xyz + u_xlat1_d.xyz;
          
          u_xlat16_5.xyz = u_xlat4.xyz * _LightColor0.xyz;
          
          u_xlat18 = (-_RampSmoothing) * 0.5 + _RampThreshold;
          
          u_xlat4.x = (-u_xlat18) + u_xlat16_8;
          
          u_xlat10_d = _RampSmoothing * 0.5 + _RampThreshold;
          
          u_xlat18 = (-u_xlat18) + u_xlat10_d;
          
          u_xlat18 = float(1.0) / u_xlat18;
          
          u_xlat18 = u_xlat18 * u_xlat4.x;
          
          u_xlat18 = clamp(u_xlat18, 0.0, 1.0);
          
          u_xlat4.x = u_xlat18 * -2.0 + 3.0;
          
          u_xlat18 = u_xlat18 * u_xlat18;
          
          u_xlat18 = u_xlat18 * u_xlat4.x;
          
          u_xlat16_2.x = u_xlat16_2.x * u_xlat18;
          
          u_xlat4.xyz = u_xlat16_2.xxx * _HColor.xyz;
          
          u_xlat1_d.xyz = u_xlat16_5.xyz * u_xlat4.xyz + u_xlat0_d.xyz;
          
          out_f.color = u_xlat1_d;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
