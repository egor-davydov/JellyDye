Shader "Toony Colors Pro 2/Mobile"
{
  Properties
  {
    _Color ("Color", Color) = (1,1,1,1)
    _HColor ("Highlight Color", Color) = (0.785,0.785,0.785,1)
    _SColor ("Shadow Color", Color) = (0.195,0.195,0.195,1)
    _MainTex ("Main Texture (RGB) Spec/MatCap Mask (A) ", 2D) = "white" {}
    [TCP2Gradient] _Ramp ("#RAMPT# Toon Ramp (RGB)", 2D) = "gray" {}
    _RampThreshold ("#RAMPF# Ramp Threshold", Range(0, 1)) = 0.5
    _RampSmooth ("#RAMPF# Ramp Smoothing", Range(0.01, 1)) = 0.1
    _BumpMap ("#NORM# Normal map (RGB)", 2D) = "bump" {}
  }
  SubShader
  {
    Tags
    { 
      "RenderType" = "Opaque"
    }
    LOD 200
    Pass // ind: 1, name: FORWARD
    {
      Name "FORWARD"
      Tags
      { 
        "LIGHTMODE" = "FORWARDBASE"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      LOD 200
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 _LightColor0;
      
      uniform float _RampThreshold;
      
      uniform float _RampSmooth;
      
      uniform float4 _HColor;
      
      uniform float4 _SColor;
      
      uniform float4 _Color;
      
      uniform sampler2D _MainTex;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float2 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float4 texcoord5 : TEXCOORD5;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float2 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord3 : TEXCOORD3;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float u_xlat6;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat1 = u_xlat0 + unity_ObjectToWorld[3];
          
          out_v.texcoord2.xyz = unity_ObjectToWorld[3].xyz * in_v.vertex.www + u_xlat0.xyz;
          
          u_xlat0 = u_xlat1.yyyy * unity_MatrixVP[1];
          
          u_xlat0 = unity_MatrixVP[0] * u_xlat1.xxxx + u_xlat0;
          
          u_xlat0 = unity_MatrixVP[2] * u_xlat1.zzzz + u_xlat0;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat1.wwww + u_xlat0;
          
          u_xlat0.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          out_v.texcoord.xy = u_xlat0.xy;
          
          u_xlat0.x = dot(in_v.normal.xyz, unity_WorldToObject[0].xyz);
          
          u_xlat0.y = dot(in_v.normal.xyz, unity_WorldToObject[1].xyz);
          
          u_xlat0.z = dot(in_v.normal.xyz, unity_WorldToObject[2].xyz);
          
          u_xlat6 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat6 = inversesqrt(u_xlat6);
          
          out_v.texcoord1.xyz = float3(u_xlat6) * u_xlat0.xyz;
          
          out_v.texcoord2.w = 0.0;
          
          out_v.texcoord3.xyz = float3(0.0, 0.0, 0.0);
          
          out_v.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat16_0;
      
      float u_xlat1_d;
      
      float3 u_xlat10_1;
      
      float3 u_xlat16_2;
      
      float3 u_xlat16_3;
      
      float u_xlat5;
      
      float u_xlat9;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat16_0.x = dot(in_f.texcoord1.xyz, _WorldSpaceLightPos0.xyz);
          
          u_xlat16_0.x = u_xlat16_0.x * 0.5 + 0.5;
          
          u_xlat16_0.x = max(u_xlat16_0.x, 0.0);
          
          u_xlat1_d = (-_RampSmooth) * 0.5 + _RampThreshold;
          
          u_xlat5 = u_xlat16_0.x + (-u_xlat1_d);
          
          u_xlat9 = _RampSmooth * 0.5 + _RampThreshold;
          
          u_xlat1_d = (-u_xlat1_d) + u_xlat9;
          
          u_xlat1_d = float(1.0) / u_xlat1_d;
          
          u_xlat1_d = u_xlat1_d * u_xlat5;
          
          u_xlat1_d = clamp(u_xlat1_d, 0.0, 1.0);
          
          u_xlat5 = u_xlat1_d * -2.0 + 3.0;
          
          u_xlat1_d = u_xlat1_d * u_xlat1_d;
          
          u_xlat1_d = u_xlat1_d * u_xlat5;
          
          u_xlat16_0.xyz = (-_HColor.xyz) + _SColor.xyz;
          
          u_xlat16_0.xyz = _SColor.www * u_xlat16_0.xyz + _HColor.xyz;
          
          u_xlat16_2.xyz = (-u_xlat16_0.xyz) + _HColor.xyz;
          
          u_xlat16_0.xyz = float3(u_xlat1_d) * u_xlat16_2.xyz + u_xlat16_0.xyz;
          
          u_xlat10_1.xyz = texture2D(_MainTex, in_f.texcoord.xy).xyz;
          
          u_xlat16_2.xyz = u_xlat10_1.xyz * _Color.xyz;
          
          u_xlat16_3.xyz = u_xlat16_2.xyz * _LightColor0.xyz;
          
          u_xlat16_0.xyz = u_xlat16_0.xyz * u_xlat16_3.xyz;
          
          out_f.color.xyz = u_xlat16_2.xyz * in_f.texcoord3.xyz + u_xlat16_0.xyz;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
