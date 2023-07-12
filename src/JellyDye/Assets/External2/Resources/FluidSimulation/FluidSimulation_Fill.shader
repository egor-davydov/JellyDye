Shader "FluidSimulation/Fill"
{
  Properties
  {
  }
  SubShader
  {
    Tags
    { 
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
      }
      ZTest Always
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float2 _texelSize;
      
      uniform float _power;
      
      uniform sampler2D _uTarget;
      
      uniform sampler2D _uBoundary;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float4 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float2 texcoord : TEXCOORD0;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float2 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Frag
      {
          
          float4 color : SV_Target0;
      
      };
      
      
      float4 u_xlat0;
      
      float4 u_xlat1;
      
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
          
          out_v.texcoord.xy = in_v.texcoord.xy;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float4 u_xlat0_d;
      
      float4 u_xlat1_d;
      
      float4 u_xlat2;
      
      float u_xlat10_2;
      
      float3 u_xlat3;
      
      float4 u_xlat4;
      
      float4 u_xlat10_5;
      
      float u_xlat8;
      
      float u_xlat9;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xw = _texelSize.xy;
          
          u_xlat0_d.y = float(0.0);
          
          u_xlat0_d.z = float(0.0);
          
          u_xlat1_d = u_xlat0_d + in_f.texcoord.xyxy;
          
          u_xlat0_d = (-u_xlat0_d) + in_f.texcoord.xyxy;
          
          u_xlat2 = texture2D(_uTarget, u_xlat1_d.xy);
          
          u_xlat1_d = texture2D(_uTarget, u_xlat1_d.zw);
          
          u_xlat3.x = u_xlat2.w + -0.949999988;
          
          u_xlat3.x = u_xlat3.x * 100.0;
          
          u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
          
          u_xlat2.w = u_xlat2.w * u_xlat3.x;
          
          u_xlat3.x = dot(u_xlat2, u_xlat2);
          
          u_xlat4 = texture2D(_uTarget, u_xlat0_d.xy);
          
          u_xlat0_d = texture2D(_uTarget, u_xlat0_d.zw);
          
          u_xlat9 = u_xlat4.w + -0.949999988;
          
          u_xlat9 = u_xlat9 * 100.0;
          
          u_xlat9 = clamp(u_xlat9, 0.0, 1.0);
          
          u_xlat4.w = u_xlat4.w * u_xlat9;
          
          u_xlat3.y = dot(u_xlat4, u_xlat4);
          
          u_xlat10_5 = texture2D(_uTarget, in_f.texcoord.xy);
          
          u_xlat3.z = dot(u_xlat10_5, u_xlat10_5);
          
          u_xlat3.xyz = sqrt(u_xlat3.xyz);
          
          u_xlat9 = (-u_xlat3.z) + u_xlat3.y;
          
          u_xlat9 = u_xlat9 * 1000.0;
          
          u_xlat9 = clamp(u_xlat9, 0.0, 1.0);
          
          u_xlat4 = u_xlat4 + (-u_xlat10_5);
          
          u_xlat4 = float4(u_xlat9) * u_xlat4 + u_xlat10_5;
          
          u_xlat9 = dot(u_xlat4, u_xlat4);
          
          u_xlat9 = sqrt(u_xlat9);
          
          u_xlat3.x = (-u_xlat9) + u_xlat3.x;
          
          u_xlat3.x = u_xlat3.x * 1000.0;
          
          u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
          
          u_xlat2 = u_xlat2 + (-u_xlat4);
          
          u_xlat2 = u_xlat3.xxxx * u_xlat2 + u_xlat4;
          
          u_xlat3.x = dot(u_xlat2, u_xlat2);
          
          u_xlat9 = u_xlat1_d.w + -0.949999988;
          
          u_xlat9 = u_xlat9 * 100.0;
          
          u_xlat9 = clamp(u_xlat9, 0.0, 1.0);
          
          u_xlat1_d.w = u_xlat1_d.w * u_xlat9;
          
          u_xlat3.y = dot(u_xlat1_d, u_xlat1_d);
          
          u_xlat1_d = (-u_xlat2) + u_xlat1_d;
          
          u_xlat3.xy = sqrt(u_xlat3.xy);
          
          u_xlat3.x = (-u_xlat3.x) + u_xlat3.y;
          
          u_xlat3.x = u_xlat3.x * 1000.0;
          
          u_xlat3.x = clamp(u_xlat3.x, 0.0, 1.0);
          
          u_xlat1_d = u_xlat3.xxxx * u_xlat1_d + u_xlat2;
          
          u_xlat2.x = dot(u_xlat1_d, u_xlat1_d);
          
          u_xlat8 = u_xlat0_d.w + -0.949999988;
          
          u_xlat8 = u_xlat8 * 100.0;
          
          u_xlat8 = clamp(u_xlat8, 0.0, 1.0);
          
          u_xlat0_d.w = u_xlat0_d.w * u_xlat8;
          
          u_xlat2.y = dot(u_xlat0_d, u_xlat0_d);
          
          u_xlat0_d = (-u_xlat1_d) + u_xlat0_d;
          
          u_xlat2.xy = sqrt(u_xlat2.xy);
          
          u_xlat2.x = (-u_xlat2.x) + u_xlat2.y;
          
          u_xlat2.x = u_xlat2.x * 1000.0;
          
          u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
          
          u_xlat0_d = u_xlat2.xxxx * u_xlat0_d + u_xlat1_d;
          
          u_xlat1_d = (-u_xlat0_d) + u_xlat10_5;
          
          u_xlat2.x = u_xlat10_5.w + -0.980000019;
          
          u_xlat2.x = u_xlat2.x * 100.0;
          
          u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
          
          u_xlat0_d = u_xlat2.xxxx * u_xlat1_d + u_xlat0_d;
          
          u_xlat0_d = (-u_xlat10_5) + u_xlat0_d;
          
          u_xlat0_d = float4(_power) * u_xlat0_d + u_xlat10_5;
          
          u_xlat1_d = (-u_xlat0_d) + u_xlat10_5;
          
          u_xlat10_2 = texture2D(_uBoundary, in_f.texcoord.xy).x;
          
          u_xlat2.x = u_xlat10_2;
          
          u_xlat2.x = clamp(u_xlat2.x, 0.0, 1.0);
          
          out_f.color = u_xlat2.xxxx * u_xlat1_d + u_xlat0_d;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
