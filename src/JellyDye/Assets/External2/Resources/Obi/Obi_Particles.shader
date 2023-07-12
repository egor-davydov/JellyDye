Shader "Obi/Particles"
{
  Properties
  {
    _Color ("Particle color", Color) = (1,1,1,1)
    _RadiusScale ("Radius scale", float) = 1
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
      
      uniform float4 unity_MatrixInvV[4];
      
      uniform float4 unity_MatrixVP[4];
      
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
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float3 texcoord4 : TEXCOORD4;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float3 texcoord2 : TEXCOORD2;
          
          float3 texcoord3 : TEXCOORD3;
          
          float3 texcoord4 : TEXCOORD4;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
          
          float SV_Depth : SV_Depth;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      int u_xlatb1;
      
      float3 u_xlat2;
      
      float3 u_xlat3;
      
      float3 u_xlat4;
      
      float3 u_xlat5;
      
      float3 u_xlat6;
      
      float4 u_xlat7;
      
      float3 u_xlat8;
      
      float3 u_xlat9;
      
      float3 u_xlat10;
      
      float3 u_xlat11;
      
      float3 u_xlat12;
      
      float3 u_xlat13;
      
      int u_xlatb36;
      
      float u_xlat37;
      
      float u_xlat38;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          u_xlat0.xy = in_v.vertex.yy * unity_MatrixV[1].xy;
          
          u_xlat0.xy = unity_MatrixV[0].xy * in_v.vertex.xx + u_xlat0.xy;
          
          u_xlat0.xy = unity_MatrixV[2].xy * in_v.vertex.zz + u_xlat0.xy;
          
          u_xlat0.xy = u_xlat0.xy + unity_MatrixV[3].xy;
          
          u_xlat12.xyz = u_xlat0.yyy * unity_MatrixInvV[1].xyz;
          
          u_xlat0.xyz = unity_MatrixInvV[0].xyz * u_xlat0.xxx + u_xlat12.xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + unity_MatrixInvV[3].xyz;
          
          u_xlatb36 = UNITY_MATRIX_P[0].w==0.0;
          
          u_xlatb1 = UNITY_MATRIX_P[1].w==0.0;
          
          u_xlatb36 = u_xlatb36 && u_xlatb1;
          
          u_xlatb1 = UNITY_MATRIX_P[2].w==0.0;
          
          u_xlatb36 = u_xlatb36 && u_xlatb1;
          
          u_xlat0.xyz = (int(u_xlatb36)) ? u_xlat0.xyz : unity_MatrixInvV[3].xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + (-in_v.vertex.xyz);
          
          u_xlat1.x = in_v.texcoord1.w * _RadiusScale;
          
          u_xlat13.x = float(1.0) / u_xlat1.x;
          
          u_xlat1.xzw = u_xlat1.xxx * in_v.texcoord1.xyz;
          
          u_xlat2.xyz = u_xlat13.xxx * in_v.texcoord1.xyz;
          
          u_xlat3.xyz = u_xlat2.xyz * in_v.texcoord1.yyy;
          
          u_xlat13.x = in_v.texcoord.w * _RadiusScale;
          
          u_xlat38 = float(1.0) / u_xlat13.x;
          
          u_xlat4.xyz = u_xlat13.xxx * in_v.texcoord.xyz;
          
          u_xlat5.xyz = float3(u_xlat38) * in_v.texcoord.xyz;
          
          u_xlat3.xyz = u_xlat5.xyz * in_v.texcoord.yyy + u_xlat3.xyz;
          
          u_xlat13.x = in_v.texcoord2.w * _RadiusScale;
          
          u_xlat38 = float(1.0) / u_xlat13.x;
          
          u_xlat6.xyz = u_xlat13.xxx * in_v.texcoord2.xyz;
          
          u_xlat7.xyz = float3(u_xlat38) * in_v.texcoord2.xyz;
          
          u_xlat3.xyz = u_xlat7.xyz * in_v.texcoord2.yyy + u_xlat3.xyz;
          
          u_xlat8.xyz = u_xlat0.yyy * u_xlat3.xyz;
          
          u_xlat9.xyz = u_xlat2.xyz * in_v.texcoord1.xxx;
          
          u_xlat2.xyz = u_xlat2.xyz * in_v.texcoord1.zzz;
          
          u_xlat2.xyz = u_xlat5.xyz * in_v.texcoord.zzz + u_xlat2.xyz;
          
          u_xlat5.xyz = u_xlat5.xyz * in_v.texcoord.xxx + u_xlat9.xyz;
          
          u_xlat5.xyz = u_xlat7.xyz * in_v.texcoord2.xxx + u_xlat5.xyz;
          
          u_xlat2.xyz = u_xlat7.xyz * in_v.texcoord2.zzz + u_xlat2.xyz;
          
          u_xlat7.xyz = u_xlat5.xyz * u_xlat0.xxx + u_xlat8.xyz;
          
          u_xlat0.xyz = u_xlat2.xyz * u_xlat0.zzz + u_xlat7.xyz;
          
          u_xlat7.x = unity_MatrixV[2].y;
          
          u_xlat7.y = unity_MatrixV[0].y;
          
          u_xlat7.z = unity_MatrixV[1].y;
          
          u_xlat8.xyz = (-u_xlat0.xyz) * u_xlat7.xyz;
          
          u_xlat7.xyz = (-u_xlat0.zxy) * u_xlat7.yzx + (-u_xlat8.xyz);
          
          u_xlat13.x = dot(u_xlat7.xyz, u_xlat7.xyz);
          
          u_xlat13.x = inversesqrt(u_xlat13.x);
          
          u_xlat7.xyz = u_xlat13.xxx * u_xlat7.xyz;
          
          u_xlat8.xyz = (-u_xlat0.zxy) * u_xlat7.xyz;
          
          u_xlat8.xyz = (-u_xlat0.yzx) * u_xlat7.yzx + (-u_xlat8.xyz);
          
          u_xlat13.x = dot(u_xlat8.xyz, u_xlat8.xyz);
          
          u_xlat13.x = inversesqrt(u_xlat13.x);
          
          u_xlat8.xyz = u_xlat13.xxx * u_xlat8.xyz;
          
          u_xlat9.xyz = u_xlat1.xzw * in_v.texcoord1.yyy;
          
          u_xlat9.xyz = u_xlat4.xyz * in_v.texcoord.yyy + u_xlat9.xyz;
          
          u_xlat9.xyz = u_xlat6.xyz * in_v.texcoord2.yyy + u_xlat9.xyz;
          
          u_xlat10.xyz = u_xlat8.yyy * u_xlat9.xyz;
          
          u_xlat11.xyz = u_xlat1.xzw * in_v.texcoord1.xxx;
          
          u_xlat1.xyz = u_xlat1.xzw * in_v.texcoord1.zzz;
          
          u_xlat1.xyz = u_xlat4.xyz * in_v.texcoord.zzz + u_xlat1.xyz;
          
          u_xlat4.xyz = u_xlat4.xyz * in_v.texcoord.xxx + u_xlat11.xyz;
          
          u_xlat4.xyz = u_xlat6.xyz * in_v.texcoord2.xxx + u_xlat4.xyz;
          
          u_xlat1.xyz = u_xlat6.xyz * in_v.texcoord2.zzz + u_xlat1.xyz;
          
          u_xlat6.xyz = u_xlat4.xyz * u_xlat8.xxx + u_xlat10.xyz;
          
          u_xlat6.xyz = u_xlat1.xyz * u_xlat8.zzz + u_xlat6.xyz;
          
          u_xlat6.xyz = u_xlat6.xyz * in_v.normal.yyy;
          
          u_xlat8.xyz = u_xlat7.xxx * u_xlat9.xyz;
          
          u_xlat7.xzw = u_xlat4.xyz * u_xlat7.zzz + u_xlat8.xyz;
          
          u_xlat7.xyz = u_xlat1.xyz * u_xlat7.yyy + u_xlat7.xzw;
          
          u_xlat6.xyz = u_xlat7.xyz * in_v.normal.xxx + u_xlat6.xyz;
          
          u_xlat37 = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat38 = float(1.0) / u_xlat37;
          
          u_xlat37 = sqrt(u_xlat37);
          
          out_v.texcoord.z = float(1.0) / u_xlat37;
          
          u_xlat7.xyz = u_xlat0.xyz * float3(u_xlat38);
          
          u_xlat0.x = (-u_xlat38) + 1.0;
          
          u_xlat7.w = sqrt(u_xlat0.x);
          
          u_xlat7 = (int(u_xlatb36)) ? float4(0.0, 0.0, 0.0, 1.0) : u_xlat7;
          
          u_xlat0.xyz = u_xlat7.yyy * u_xlat9.xyz;
          
          u_xlat0.xyz = u_xlat4.xyz * u_xlat7.xxx + u_xlat0.xyz;
          
          u_xlat0.xyz = u_xlat1.xyz * u_xlat7.zzz + u_xlat0.xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + in_v.vertex.xyz;
          
          u_xlat0.xyz = u_xlat7.www * u_xlat6.xyz + u_xlat0.xyz;
          
          out_v.texcoord.w = u_xlat7.w;
          
          u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = unity_MatrixVP[3] * in_v.vertex.wwww + u_xlat1;
          
          out_v.color = in_v.color * _Color;
          
          out_v.texcoord.xy = in_v.normal.xy;
          
          u_xlat1.xy = u_xlat0.yy * unity_MatrixV[1].xy;
          
          u_xlat1.xy = unity_MatrixV[0].xy * u_xlat0.xx + u_xlat1.xy;
          
          u_xlat1.xy = unity_MatrixV[2].xy * u_xlat0.zz + u_xlat1.xy;
          
          u_xlat1.xy = u_xlat1.xy + unity_MatrixV[3].xy;
          
          u_xlat13.xyz = u_xlat1.yyy * unity_MatrixInvV[1].xyz;
          
          u_xlat1.xyz = unity_MatrixInvV[0].xyz * u_xlat1.xxx + u_xlat13.xyz;
          
          u_xlat1.xyz = u_xlat1.xyz + unity_MatrixInvV[3].xyz;
          
          u_xlat1.xyz = (int(u_xlatb36)) ? u_xlat1.xyz : unity_MatrixInvV[3].xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + (-u_xlat1.xyz);
          
          u_xlat1.xyz = u_xlat1.xyz + (-in_v.vertex.xyz);
          
          u_xlat4.xyz = u_xlat0.yyy * unity_MatrixV[1].xyz;
          
          u_xlat4.xyz = unity_MatrixV[0].xyz * u_xlat0.xxx + u_xlat4.xyz;
          
          out_v.texcoord1.xyz = unity_MatrixV[2].xyz * u_xlat0.zzz + u_xlat4.xyz;
          
          u_xlat4.xyz = unity_ObjectToWorld[0].yyy * unity_MatrixV[1].xyz;
          
          u_xlat4.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[0].xxx + u_xlat4.xyz;
          
          u_xlat4.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[0].zzz + u_xlat4.xyz;
          
          u_xlat4.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[0].www + u_xlat4.xyz;
          
          u_xlat6.xyz = unity_ObjectToWorld[1].yyy * unity_MatrixV[1].xyz;
          
          u_xlat6.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[1].xxx + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[1].zzz + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[1].www + u_xlat6.xyz;
          
          u_xlat7.xyz = _WorldSpaceLightPos0.yyy * unity_WorldToObject[1].xyz;
          
          u_xlat7.xyz = unity_WorldToObject[0].xyz * _WorldSpaceLightPos0.xxx + u_xlat7.xyz;
          
          u_xlat7.xyz = unity_WorldToObject[2].xyz * _WorldSpaceLightPos0.zzz + u_xlat7.xyz;
          
          u_xlat7.xyz = unity_WorldToObject[3].xyz * _WorldSpaceLightPos0.www + u_xlat7.xyz;
          
          u_xlat6.xyz = u_xlat6.xyz * u_xlat7.yyy;
          
          u_xlat4.xyz = u_xlat4.xyz * u_xlat7.xxx + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_ObjectToWorld[2].yyy * unity_MatrixV[1].xyz;
          
          u_xlat6.xyz = unity_MatrixV[0].xyz * unity_ObjectToWorld[2].xxx + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_MatrixV[2].xyz * unity_ObjectToWorld[2].zzz + u_xlat6.xyz;
          
          u_xlat6.xyz = unity_MatrixV[3].xyz * unity_ObjectToWorld[2].www + u_xlat6.xyz;
          
          out_v.texcoord2.xyz = u_xlat6.xyz * u_xlat7.zzz + u_xlat4.xyz;
          
          u_xlat4.xyz = u_xlat1.yyy * u_xlat3.xyz;
          
          u_xlat1.xyw = u_xlat5.xyz * u_xlat1.xxx + u_xlat4.xyz;
          
          u_xlat1.xyz = u_xlat2.xyz * u_xlat1.zzz + u_xlat1.xyw;
          
          u_xlat4.xyz = u_xlat1.yyy * u_xlat3.xyz;
          
          u_xlat1.xyw = u_xlat5.xyz * u_xlat1.xxx + u_xlat4.xyz;
          
          u_xlat1.xyz = u_xlat2.xyz * u_xlat1.zzz + u_xlat1.xyw;
          
          u_xlat4.xyz = u_xlat1.yyy * unity_MatrixV[1].xyz;
          
          u_xlat1.xyw = unity_MatrixV[0].xyz * u_xlat1.xxx + u_xlat4.xyz;
          
          out_v.texcoord3.xyz = unity_MatrixV[2].xyz * u_xlat1.zzz + u_xlat1.xyw;
          
          u_xlat1.xyz = u_xlat0.yyy * u_xlat3.xyz;
          
          u_xlat0.xyw = u_xlat5.xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = u_xlat2.xyz * u_xlat0.zzz + u_xlat0.xyw;
          
          u_xlat1.xyz = u_xlat0.yyy * u_xlat3.xyz;
          
          u_xlat0.xyw = u_xlat5.xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          u_xlat0.xyz = u_xlat2.xyz * u_xlat0.zzz + u_xlat0.xyw;
          
          u_xlat1.xyz = u_xlat0.yyy * unity_MatrixV[1].xyz;
          
          u_xlat0.xyw = unity_MatrixV[0].xyz * u_xlat0.xxx + u_xlat1.xyz;
          
          out_v.texcoord4.xyz = unity_MatrixV[2].xyz * u_xlat0.zzz + u_xlat0.xyw;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat1_d;
      
      float3 u_xlat2_d;
      
      float3 u_xlat16_3;
      
      float3 u_xlat4_d;
      
      int u_xlatb4;
      
      float u_xlat12_d;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = dot(in_f.texcoord.xy, in_f.texcoord.xy);
          
          u_xlat0_d.x = u_xlat0_d.x / in_f.texcoord.w;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlatb4 = u_xlat0_d.x<0.0;
          
          u_xlat0_d.x = sqrt(u_xlat0_d.x);
          
          u_xlat0_d.x = in_f.texcoord.z * u_xlat0_d.x + 1.0;
          
          u_xlat0_d.x = float(1.0) / u_xlat0_d.x;
          
          if(u_xlatb4)
      {
              discard;
      }
          
          u_xlat4_d.xyz = u_xlat0_d.xxx * in_f.texcoord4.xyz + in_f.texcoord3.xyz;
          
          u_xlat1_d.xyz = u_xlat0_d.xxx * in_f.texcoord1.xyz;
          
          u_xlat0_d.x = dot(u_xlat4_d.xyz, u_xlat4_d.xyz);
          
          u_xlat0_d.x = inversesqrt(u_xlat0_d.x);
          
          u_xlat0_d.xyz = u_xlat0_d.xxx * u_xlat4_d.xyz;
          
          u_xlat12_d = dot(in_f.texcoord2.xyz, in_f.texcoord2.xyz);
          
          u_xlat12_d = inversesqrt(u_xlat12_d);
          
          u_xlat2_d.xyz = float3(u_xlat12_d) * in_f.texcoord2.xyz;
          
          u_xlat0_d.x = dot(u_xlat0_d.xyz, u_xlat2_d.xyz);
          
          u_xlat0_d.x = clamp(u_xlat0_d.x, 0.0, 1.0);
          
          u_xlat16_3.xyz = glstate_lightmodel_ambient.xyz + glstate_lightmodel_ambient.xyz;
          
          u_xlat0_d.xyz = _LightColor0.xyz * u_xlat0_d.xxx + u_xlat16_3.xyz;
          
          u_xlat0_d.xyz = u_xlat0_d.xyz * in_f.color.xyz;
          
          out_f.color.xyz = u_xlat0_d.xyz;
          
          out_f.color.w = in_f.color.w;
          
          u_xlat0_d.xy = u_xlat1_d.yy * UNITY_MATRIX_P[1].zw;
          
          u_xlat0_d.xy = UNITY_MATRIX_P[0].zw * u_xlat1_d.xx + u_xlat0_d.xy;
          
          u_xlat0_d.xy = UNITY_MATRIX_P[2].zw * u_xlat1_d.zz + u_xlat0_d.xy;
          
          u_xlat0_d.xy = u_xlat0_d.xy + UNITY_MATRIX_P[3].zw;
          
          u_xlat0_d.x = u_xlat0_d.x / u_xlat0_d.y;
          
          gl_FragDepthEXT = u_xlat0_d.x * 0.5 + 0.5;
          
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
      
      uniform float4 unity_MatrixInvV[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float _RadiusScale;
      
      uniform float4 _Color;
      
      uniform float4 unity_LightShadowBias;
      
      uniform sampler3D _DitherMaskLOD;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float3 normal : NORMAL0;
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
          
          float4 texcoord1 : TEXCOORD1;
          
          float4 texcoord2 : TEXCOORD2;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 color : COLOR0;
          
          float4 texcoord : TEXCOORD0;
          
          float3 texcoord1 : TEXCOORD1;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
          
          float SV_Depth : SV_Depth;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
      int u_xlatb1;
      
      float4 u_xlat2;
      
      float4 u_xlat3;
      
      float3 u_xlat4;
      
      float3 u_xlat5;
      
      float3 u_xlat6;
      
      float3 u_xlat7;
      
      float3 u_xlat8;
      
      float3 u_xlat9;
      
      float3 u_xlat10;
      
      int u_xlatb27;
      
      float u_xlat29;
      
      OUT_Data_Vert vert(appdata_t in_v)
      {
          
          out_v.color = in_v.color * _Color;
          
          u_xlat0.xy = in_v.vertex.yy * unity_MatrixV[1].xy;
          
          u_xlat0.xy = unity_MatrixV[0].xy * in_v.vertex.xx + u_xlat0.xy;
          
          u_xlat0.xy = unity_MatrixV[2].xy * in_v.vertex.zz + u_xlat0.xy;
          
          u_xlat0.xy = u_xlat0.xy + unity_MatrixV[3].xy;
          
          u_xlat9.xyz = u_xlat0.yyy * unity_MatrixInvV[1].xyz;
          
          u_xlat0.xyz = unity_MatrixInvV[0].xyz * u_xlat0.xxx + u_xlat9.xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + unity_MatrixInvV[3].xyz;
          
          u_xlatb27 = UNITY_MATRIX_P[0].w==0.0;
          
          u_xlatb1 = UNITY_MATRIX_P[1].w==0.0;
          
          u_xlatb27 = u_xlatb27 && u_xlatb1;
          
          u_xlatb1 = UNITY_MATRIX_P[2].w==0.0;
          
          u_xlatb27 = u_xlatb27 && u_xlatb1;
          
          u_xlat0.xyz = (int(u_xlatb27)) ? u_xlat0.xyz : unity_MatrixInvV[3].xyz;
          
          u_xlat0.xyz = u_xlat0.xyz + (-in_v.vertex.xyz);
          
          u_xlat1.x = in_v.texcoord1.w * _RadiusScale;
          
          u_xlat10.x = float(1.0) / u_xlat1.x;
          
          u_xlat1.xzw = u_xlat1.xxx * in_v.texcoord1.xyz;
          
          u_xlat2.xyz = u_xlat10.xxx * in_v.texcoord1.xyz;
          
          u_xlat3.xyz = u_xlat2.xyz * in_v.texcoord1.yyy;
          
          u_xlat10.x = in_v.texcoord.w * _RadiusScale;
          
          u_xlat29 = float(1.0) / u_xlat10.x;
          
          u_xlat4.xyz = u_xlat10.xxx * in_v.texcoord.xyz;
          
          u_xlat5.xyz = float3(u_xlat29) * in_v.texcoord.xyz;
          
          u_xlat3.xyz = u_xlat5.xyz * in_v.texcoord.yyy + u_xlat3.xyz;
          
          u_xlat10.x = in_v.texcoord2.w * _RadiusScale;
          
          u_xlat29 = float(1.0) / u_xlat10.x;
          
          u_xlat6.xyz = u_xlat10.xxx * in_v.texcoord2.xyz;
          
          u_xlat7.xyz = float3(u_xlat29) * in_v.texcoord2.xyz;
          
          u_xlat3.xyz = u_xlat7.xyz * in_v.texcoord2.yyy + u_xlat3.xyz;
          
          u_xlat3.xyz = u_xlat0.yyy * u_xlat3.xyz;
          
          u_xlat8.xyz = u_xlat2.xyz * in_v.texcoord1.xxx;
          
          u_xlat2.xyz = u_xlat2.xyz * in_v.texcoord1.zzz;
          
          u_xlat2.xyz = u_xlat5.xyz * in_v.texcoord.zzz + u_xlat2.xyz;
          
          u_xlat5.xyz = u_xlat5.xyz * in_v.texcoord.xxx + u_xlat8.xyz;
          
          u_xlat5.xyz = u_xlat7.xyz * in_v.texcoord2.xxx + u_xlat5.xyz;
          
          u_xlat2.xyz = u_xlat7.xyz * in_v.texcoord2.zzz + u_xlat2.xyz;
          
          u_xlat3.xyz = u_xlat5.xyz * u_xlat0.xxx + u_xlat3.xyz;
          
          u_xlat0.xyz = u_xlat2.xyz * u_xlat0.zzz + u_xlat3.xyz;
          
          u_xlat10.x = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat2.x = sqrt(u_xlat10.x);
          
          u_xlat10.x = float(1.0) / u_xlat10.x;
          
          out_v.texcoord.z = float(1.0) / u_xlat2.x;
          
          u_xlat2.xyz = u_xlat0.xyz * u_xlat10.xxx;
          
          u_xlat10.x = (-u_xlat10.x) + 1.0;
          
          u_xlat2.w = sqrt(u_xlat10.x);
          
          u_xlat2 = (int(u_xlatb27)) ? float4(0.0, 0.0, 0.0, 1.0) : u_xlat2;
          
          out_v.texcoord.w = u_xlat2.w;
          
          out_v.texcoord.xy = in_v.normal.xy;
          
          u_xlat3.x = unity_MatrixV[2].y;
          
          u_xlat3.y = unity_MatrixV[0].y;
          
          u_xlat3.z = unity_MatrixV[1].y;
          
          u_xlat5.xyz = (-u_xlat0.xyz) * u_xlat3.xyz;
          
          u_xlat3.xyz = (-u_xlat0.zxy) * u_xlat3.yzx + (-u_xlat5.xyz);
          
          u_xlat10.x = dot(u_xlat3.xyz, u_xlat3.xyz);
          
          u_xlat10.x = inversesqrt(u_xlat10.x);
          
          u_xlat3.xyz = u_xlat10.xxx * u_xlat3.xyz;
          
          u_xlat5.xyz = (-u_xlat0.zxy) * u_xlat3.xyz;
          
          u_xlat0.xyz = (-u_xlat0.yzx) * u_xlat3.yzx + (-u_xlat5.xyz);
          
          u_xlat10.x = dot(u_xlat0.xyz, u_xlat0.xyz);
          
          u_xlat10.x = inversesqrt(u_xlat10.x);
          
          u_xlat0.xyz = u_xlat0.xyz * u_xlat10.xxx;
          
          u_xlat5.xyz = u_xlat1.xzw * in_v.texcoord1.yyy;
          
          u_xlat5.xyz = u_xlat4.xyz * in_v.texcoord.yyy + u_xlat5.xyz;
          
          u_xlat5.xyz = u_xlat6.xyz * in_v.texcoord2.yyy + u_xlat5.xyz;
          
          u_xlat7.xyz = u_xlat0.yyy * u_xlat5.xyz;
          
          u_xlat8.xyz = u_xlat1.xzw * in_v.texcoord1.xxx;
          
          u_xlat1.xyz = u_xlat1.xzw * in_v.texcoord1.zzz;
          
          u_xlat1.xyz = u_xlat4.xyz * in_v.texcoord.zzz + u_xlat1.xyz;
          
          u_xlat4.xyz = u_xlat4.xyz * in_v.texcoord.xxx + u_xlat8.xyz;
          
          u_xlat4.xyz = u_xlat6.xyz * in_v.texcoord2.xxx + u_xlat4.xyz;
          
          u_xlat1.xyz = u_xlat6.xyz * in_v.texcoord2.zzz + u_xlat1.xyz;
          
          u_xlat6.xyz = u_xlat4.xyz * u_xlat0.xxx + u_xlat7.xyz;
          
          u_xlat0.xyz = u_xlat1.xyz * u_xlat0.zzz + u_xlat6.xyz;
          
          u_xlat0.xyz = u_xlat0.xyz * in_v.normal.yyy;
          
          u_xlat6.xyz = u_xlat3.xxx * u_xlat5.xyz;
          
          u_xlat5.xyz = u_xlat2.yyy * u_xlat5.xyz;
          
          u_xlat5.xyz = u_xlat4.xyz * u_xlat2.xxx + u_xlat5.xyz;
          
          u_xlat3.xzw = u_xlat4.xyz * u_xlat3.zzz + u_xlat6.xyz;
          
          u_xlat3.xyz = u_xlat1.xyz * u_xlat3.yyy + u_xlat3.xzw;
          
          u_xlat1.xyz = u_xlat1.xyz * u_xlat2.zzz + u_xlat5.xyz;
          
          u_xlat1.xyz = u_xlat1.xyz + in_v.vertex.xyz;
          
          u_xlat0.xyz = u_xlat3.xyz * in_v.normal.xxx + u_xlat0.xyz;
          
          u_xlat0.xyz = u_xlat2.www * u_xlat0.xyz + u_xlat1.xyz;
          
          u_xlat1.xy = u_xlat0.yy * unity_MatrixV[1].xy;
          
          u_xlat1.xy = unity_MatrixV[0].xy * u_xlat0.xx + u_xlat1.xy;
          
          u_xlat1.xy = unity_MatrixV[2].xy * u_xlat0.zz + u_xlat1.xy;
          
          u_xlat1.xy = u_xlat1.xy + unity_MatrixV[3].xy;
          
          u_xlat10.xyz = u_xlat1.yyy * unity_MatrixInvV[1].xyz;
          
          u_xlat1.xyz = unity_MatrixInvV[0].xyz * u_xlat1.xxx + u_xlat10.xyz;
          
          u_xlat1.xyz = u_xlat1.xyz + unity_MatrixInvV[3].xyz;
          
          u_xlat1.xyz = (int(u_xlatb27)) ? u_xlat1.xyz : unity_MatrixInvV[3].xyz;
          
          u_xlat1.xyz = u_xlat0.xyz + (-u_xlat1.xyz);
          
          u_xlat2.xyz = u_xlat1.yyy * unity_MatrixV[1].xyz;
          
          u_xlat1.xyw = unity_MatrixV[0].xyz * u_xlat1.xxx + u_xlat2.xyz;
          
          out_v.texcoord1.xyz = unity_MatrixV[2].xyz * u_xlat1.zzz + u_xlat1.xyw;
          
          u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat0 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = unity_MatrixVP[3] * in_v.vertex.wwww + u_xlat0;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float4 u_xlat0_d;
      
      float3 u_xlat1_d;
      
      float u_xlat16_2;
      
      float2 u_xlat3_d;
      
      float u_xlat10_3;
      
      int u_xlatb3;
      
      float u_xlat6_d;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          float4 hlslcc_FragCoord = float4(gl_FragCoord.xyz, 1.0/gl_FragCoord.w);
          
          u_xlat0_d.x = dot(in_f.texcoord.xy, in_f.texcoord.xy);
          
          u_xlat0_d.x = u_xlat0_d.x / in_f.texcoord.w;
          
          u_xlat0_d.x = (-u_xlat0_d.x) + 1.0;
          
          u_xlatb3 = u_xlat0_d.x<0.0;
          
          u_xlat0_d.x = sqrt(u_xlat0_d.x);
          
          u_xlat0_d.x = in_f.texcoord.z * u_xlat0_d.x + 1.0;
          
          u_xlat0_d.x = float(1.0) / u_xlat0_d.x;
          
          u_xlat0_d.xzw = u_xlat0_d.xxx * in_f.texcoord1.xyz;
          
          if(u_xlatb3)
      {
              discard;
      }
          
          u_xlat1_d.xy = hlslcc_FragCoord.xy * float2(0.25, 0.25);
          
          u_xlat1_d.z = in_f.color.w * 0.9375;
          
          u_xlat10_3 = texture3D(_DitherMaskLOD, u_xlat1_d.xyz).w;
          
          u_xlat16_2 = u_xlat10_3 + -0.00999999978;
          
          u_xlatb3 = u_xlat16_2<0.0;
          
          if(u_xlatb3)
      {
              discard;
      }
          
          u_xlat3_d.xy = u_xlat0_d.zz * UNITY_MATRIX_P[1].zw;
          
          u_xlat0_d.xy = UNITY_MATRIX_P[0].zw * u_xlat0_d.xx + u_xlat3_d.xy;
          
          u_xlat0_d.xy = UNITY_MATRIX_P[2].zw * u_xlat0_d.ww + u_xlat0_d.xy;
          
          u_xlat0_d.xy = u_xlat0_d.xy + UNITY_MATRIX_P[3].zw;
          
          u_xlat6_d = unity_LightShadowBias.x / u_xlat0_d.y;
          
          u_xlat6_d = clamp(u_xlat6_d, 0.0, 1.0);
          
          u_xlat0_d.x = u_xlat6_d + u_xlat0_d.x;
          
          u_xlat6_d = max((-u_xlat0_d.y), u_xlat0_d.x);
          
          u_xlat6_d = (-u_xlat0_d.x) + u_xlat6_d;
          
          u_xlat0_d.x = unity_LightShadowBias.y * u_xlat6_d + u_xlat0_d.x;
          
          u_xlat0_d = u_xlat0_d.xxxx / u_xlat0_d.yyyy;
          
          out_f.color = u_xlat0_d;
          
          gl_FragDepthEXT = u_xlat0_d.w * 0.5 + 0.5;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack "Diffuse"
}
