Shader "FluidSimulation/Splat"
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
      
      uniform float4 _color;
      
      uniform float2 _point;
      
      uniform float _radius;
      
      uniform sampler2D _uTarget;
      
      
      
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
      
      
      
      
      float2 u_xlat0_d;
      
      float4 u_xlat10_1;
      
      float4 u_xlat2;
      
      OUT_Data_Frag frag(Interpolators in_f)
      {
          
          u_xlat0_d.xy = in_f.texcoord.xy + (-_point.xy);
          
          u_xlat0_d.x = dot(u_xlat0_d.xy, u_xlat0_d.xy);
          
          u_xlat0_d.x = (-u_xlat0_d.x) / _radius;
          
          u_xlat0_d.x = u_xlat0_d.x * 1.44269502;
          
          u_xlat0_d.x = exp2(u_xlat0_d.x);
          
          u_xlat0_d.x = u_xlat0_d.x * 10.0;
          
          u_xlat0_d.x = min(u_xlat0_d.x, 1.0);
          
          u_xlat10_1 = texture2D(_uTarget, in_f.texcoord.xy);
          
          u_xlat2 = (-u_xlat10_1) + _color;
          
          out_f.color = u_xlat0_d.xxxx * u_xlat2 + u_xlat10_1;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
