Shader "FluidSimulation/Vorticity"
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
      
      uniform float _curl;
      
      uniform float _dt;
      
      uniform sampler2D _uCurl;
      
      uniform sampler2D _uVelocity;
      
      
      
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
      
      
      struct Interpolators
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
      
      float u_xlat10_0;
      
      float4 u_xlat1_d;
      
      float u_xlat10_1;
      
      float3 u_xlat10_2;
      
      float u_xlat4;
      
      float u_xlat10_4;
      
      float u_xlat10_5;
      
      OUT_Data_Frag frag(Interpolators in_f)
      {
          
          u_xlat0_d.xw = _texelSize.xy;
          
          u_xlat0_d.y = float(0.0);
          
          u_xlat0_d.z = float(0.0);
          
          u_xlat1_d = u_xlat0_d + in_f.texcoord.xyxy;
          
          u_xlat0_d = (-u_xlat0_d) + in_f.texcoord.xyxy;
          
          u_xlat10_5 = texture2D(_uCurl, u_xlat1_d.zw).x;
          
          u_xlat10_1 = texture2D(_uCurl, u_xlat1_d.xy).x;
          
          u_xlat10_4 = texture2D(_uCurl, u_xlat0_d.zw).x;
          
          u_xlat10_0 = texture2D(_uCurl, u_xlat0_d.xy).x;
          
          u_xlat0_d.y = -abs(u_xlat10_0) + abs(u_xlat10_1);
          
          u_xlat0_d.x = -abs(u_xlat10_4) + abs(u_xlat10_5);
          
          u_xlat0_d.xy = u_xlat0_d.xy * float2(0.5, 0.5);
          
          u_xlat4 = dot(u_xlat0_d.xy, u_xlat0_d.xy);
          
          u_xlat4 = sqrt(u_xlat4);
          
          u_xlat4 = u_xlat4 + 9.99999975e-05;
          
          u_xlat0_d.xy = u_xlat0_d.xy / float2(u_xlat4);
          
          u_xlat10_4 = texture2D(_uCurl, in_f.texcoord.xy).x;
          
          u_xlat4 = u_xlat10_4 * _curl;
          
          u_xlat0_d.xy = float2(u_xlat4) * u_xlat0_d.xy;
          
          u_xlat0_d.z = u_xlat0_d.y * _dt;
          
          u_xlat10_2.xz = texture2D(_uVelocity, in_f.texcoord.xy).xy;
          
          u_xlat1_d.x = _dt;
          
          u_xlat1_d.y = -1.0;
          
          u_xlat0_d.xy = u_xlat0_d.xz * u_xlat1_d.xy + u_xlat10_2.xz;
          
          u_xlat0_d.xy = max(u_xlat0_d.xy, float2(-1000.0, -1000.0));
          
          out_f.color.xy = min(u_xlat0_d.xy, float2(1000.0, 1000.0));
          
          out_f.color.zw = float2(0.0, 1.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
