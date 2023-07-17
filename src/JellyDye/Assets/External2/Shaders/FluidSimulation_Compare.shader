Shader "FluidSimulation/Compare"
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
      
      uniform float4 _targetColor;
      
      uniform float _radius;
      
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
      
      
      
      
      float3 u_xlat0_d;
      
      float3 u_xlat10_0;
      
      int u_xlatb0;
      
      float u_xlat16_1;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d.x = texture2D(_uBoundary, in_f.texcoord.xy).x;
          
          u_xlatb0 = 0.800000012<u_xlat0_d.x;
          
          if(u_xlatb0)
      {
              
              out_f.color = float4(0.200000003, 0.0, 0.0, 1.0);
              
              return;
      
      }
          
          u_xlat10_0.xyz = texture2D(_uTarget, in_f.texcoord.xy).xyz;
          
          u_xlat0_d.xyz = u_xlat10_0.xyz + (-_targetColor.xyz);
          
          u_xlat16_1 = abs(u_xlat0_d.y) + abs(u_xlat0_d.x);
          
          u_xlat16_1 = abs(u_xlat0_d.z) + u_xlat16_1;
          
          u_xlatb0 = u_xlat16_1<_radius;
          
          out_f.color = (int(u_xlatb0)) ? float4(1.0, 0.0, 0.0, 1.0) : float4(0.0, 0.0, 0.0, 1.0);
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
