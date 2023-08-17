Shader "FluidSimulation/Curl"
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
      
      float u_xlat10_2;
      
      float u_xlat10_3;
      
      OUT_Data_Frag frag(Interpolators in_f)
      {
          
          u_xlat0_d.xw = _texelSize.xy;
          
          u_xlat0_d.y = float(0.0);
          
          u_xlat0_d.z = float(0.0);
          
          u_xlat1_d = (-u_xlat0_d) + in_f.texcoord.xyxy;
          
          u_xlat0_d = u_xlat0_d + in_f.texcoord.xyxy;
          
          u_xlat10_1 = texture2D(_uVelocity, u_xlat1_d.xy).y;
          
          u_xlat10_3 = texture2D(_uVelocity, u_xlat1_d.zw).x;
          
          u_xlat10_0 = texture2D(_uVelocity, u_xlat0_d.xy).y;
          
          u_xlat10_2 = texture2D(_uVelocity, u_xlat0_d.zw).x;
          
          u_xlat0_d.x = (-u_xlat10_1) + u_xlat10_0;
          
          u_xlat0_d.x = (-u_xlat10_2) + u_xlat0_d.x;
          
          u_xlat0_d.x = u_xlat10_3 + u_xlat0_d.x;
          
          out_f.color.x = u_xlat0_d.x * 0.5;
          
          out_f.color.yzw = float3(0.0, 0.0, 1.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
