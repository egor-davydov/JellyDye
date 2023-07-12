Shader "FluidSimulation/GradientSubstract"
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
      
      uniform sampler2D _uPressure;
      
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
      
      float2 u_xlat10_0;
      
      float4 u_xlat1_d;
      
      float2 u_xlat2;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.xw = _texelSize.xy;
          
          u_xlat0_d.y = float(0.0);
          
          u_xlat0_d.z = float(0.0);
          
          u_xlat1_d = (-u_xlat0_d) + in_f.texcoord.xyxy;
          
          u_xlat0_d = u_xlat0_d + in_f.texcoord.xyxy;
          
          u_xlat1_d.x = texture2D(_uPressure, u_xlat1_d.xy).x;
          
          u_xlat1_d.y = texture2D(_uPressure, u_xlat1_d.zw).x;
          
          u_xlat0_d.x = texture2D(_uPressure, u_xlat0_d.xy).x;
          
          u_xlat0_d.y = texture2D(_uPressure, u_xlat0_d.zw).x;
          
          u_xlat2.xy = (-u_xlat1_d.xy) + u_xlat0_d.xy;
          
          u_xlat10_0.xy = texture2D(_uVelocity, in_f.texcoord.xy).xy;
          
          out_f.color.xy = (-u_xlat2.xy) + u_xlat10_0.xy;
          
          out_f.color.zw = float2(0.0, 1.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
