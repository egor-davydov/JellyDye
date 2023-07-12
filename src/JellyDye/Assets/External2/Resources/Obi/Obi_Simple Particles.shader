Shader "Obi/Simple Particles"
{
  Properties
  {
    _Color ("Particle color", Color) = (1,1,1,1)
  }
  SubShader
  {
    Tags
    { 
    }
    Pass // ind: 1, name: ParticleFwdBase
    {
      Name "ParticleFwdBase"
      Tags
      { 
        "IGNOREPROJECTOR" = "true"
        "QUEUE" = "Geometry"
        "RenderType" = "Opaque"
        "SHADOWSUPPORT" = "true"
      }
      Blend SrcAlpha OneMinusSrcAlpha
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile DIRECTIONAL
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 _WorldSpaceLightPos0;
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_WorldToObject[4];
      
      uniform float4 UNITY_MATRIX_P[4];
      
      uniform float4 unity_MatrixV[4];
      
      uniform float _RadiusScale;
      
      uniform float4 _Color;
      
      uniform float4 glstate_lightmodel_ambient;
      
      uniform float4 _LightColor0;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 color : COLOR0;
          
          float2 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 color : COLOR0;
          
          float2 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float4 u_xlat2;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_MatrixV[1];
          
          u_xlat0 = unity_MatrixV[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_MatrixV[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat0 = unity_MatrixV[3] * in_v.vertex.wwww + u_xlat0;
          
          u_xlat1.x = in_v.texcoord.w * _RadiusScale;
          
          u_xlat2.xy = in_v.normal.xy;
          
          u_xlat2.z = float(0.0);
          
          u_xlat2.w = float(0.0);
          
          u_xlat0 = u_xlat2 * u_xlat1.xxxx + u_xlat0;
          
          u_xlat1 = u_xlat0.yyyy * UNITY_MATRIX_P[1];
          
          u_xlat1 = UNITY_MATRIX_P[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = UNITY_MATRIX_P[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = UNITY_MATRIX_P[3] * u_xlat0.wwww + u_xlat1;
          
          out_v.color = in_v.color * _Color;
          
          out_v.texcoord.xy = in_v.normal.xy * float2(0.5, 0.5) + float2(0.5, 0.5);
          
          u_xlat0.xyz = unity_ObjectToWorld[0].yyy * unity_MatrixV[1].xyz;
          
          u_xlat0.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[0].xxx + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[0].zzz + u_xlat0.xyz;
          
          u_xlat0.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[0].www + u_xlat0.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[1].yyy * unity_MatrixV[1].xyz;
          
          u_xlat1.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[1].xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[1].zzz + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[1].www + u_xlat1.xyz;
          
          u_xlat2.xyz = _WorldSpaceLightPos0.yyy * unity_WorldToObject[1].xyz;
          
          u_xlat2.xyz = unity_WorldToObject[0].xyz * _WorldSpaceLightPos0.xxx + u_xlat2.xyz;
          
          u_xlat2.xyz = unity_WorldToObject[2].xyz * _WorldSpaceLightPos0.zzz + u_xlat2.xyz;
          
          u_xlat2.xyz = unity_WorldToObject[3].xyz * _WorldSpaceLightPos0.www + u_xlat2.xyz;
          
          u_xlat1.xyz = u_xlat1.xyz * u_xlat2.yyy;
          
          u_xlat0.xyz = u_xlat0.xyz * u_xlat2.xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_ObjectToWorld[2].yyy * unity_MatrixV[1].xyz;
          
          u_xlat1.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[2].xxx + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[2].zzz + u_xlat1.xyz;
          
          u_xlat1.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[2].www + u_xlat1.xyz;
          
          out_v.texcoord1.xyz = u_xlat1.xyz * u_xlat2.zzz + u_xlat0.xyz;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat1_d;
      
      float3 u_xlat16_2;
      
      int u_xlatb3;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xy = in_f.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
          
          u_xlat0_d.x = dot(u_xlat0_d.xy, u_xlat0_d.xy);
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlatb3 = u_xlat0_d.x<0.0;
          
          u_xlat1_d.z = sqrt(u_xlat0_d.x);
          
          if(u_xlatb3)
      {
              discard;
      }
          
          u_xlat0_d.x = dot(in_f.texcoord1.xyz, in_f.texcoord1.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * in_f.texcoord1.xyz;
          
          u_xlat1_d.xy = in_f.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
          
          u_xlat0_d.x = dot(u_xlat1_d.xyz, u_xlat0_d.xyz);
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat16_2.xyz = glstate_lightmodel_ambient.xyz + glstate_lightmodel_ambient.xyz;
          
          u_xlat0_d.xyz = _LightColor0.xyz * u_xlat0_d.xxx + u_xlat16_2.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * in_f.color.xyz;
          
          out_f.color.xyz = u_xlat0_d.xyz;
          
          out_f.color.w = in_f.color.w;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
    Pass // ind: 2, name: ShadowCaster
    {
      Name "ShadowCaster"
      Tags
      { 
        "LIGHTMODE" = "SHADOWCASTER"
        "SHADOWSUPPORT" = "true"
      }
      Offset 1, 1
      Fog
      { 
        Mode  Off
      } 
      // m_ProgramMask = 6
      CGPROGRAM
      #pragma multi_compile SHADOWS_DEPTH
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 UNITY_MATRIX_P[4];
      
      uniform float4 unity_MatrixV[4];
      
      uniform float _RadiusScale;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float3 texcoord : TEXCOORD0;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float3 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      float u_xlat2;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0 = in_v.vertex.yyyy * unity_MatrixV[1];
          
          u_xlat0 = unity_MatrixV[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_MatrixV[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat0 = unity_MatrixV[3] * in_v.vertex.wwww + u_xlat0;
          
          u_xlat1.xy = in_v.normal.xy;
          
          u_xlat1.z = float(0.0);
          
          u_xlat1.w = float(0.0);
          
          u_xlat2 = in_v.texcoord.w * _RadiusScale;
          
          u_xlat0 = u_xlat1 * float4(u_xlat2) + u_xlat0;
          
          out_v.texcoord.z = u_xlat2;
          
          u_xlat1 = u_xlat0.yyyy * UNITY_MATRIX_P[1];
          
          u_xlat1 = UNITY_MATRIX_P[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = UNITY_MATRIX_P[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = UNITY_MATRIX_P[3] * u_xlat0.wwww + u_xlat1;
          
          out_v.texcoord.xy = in_v.normal.xy * float2(0.5, 0.5) + float2(0.5, 0.5);
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float2 u_xlat0_d;
      
      int u_xlatb0;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xy = in_f.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
          
          u_xlat0_d.x = dot(u_xlat0_d.xy, u_xlat0_d.xy);
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlatb0 = u_xlat0_d.x<0.0;
          
          if(u_xlatb0)
      {
              discard;
      }
          
          out_f.color = float4(0.0, 0.0, 0.0, 0.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
