Shader "Obi/DistanceFieldSlice"
{
  Properties
  {
    _MainTex ("Texture", 2D) = "white" {}
  }
  SubShader
  {
    Tags
    { 
      "RenderType" = "Opaque"
    }
    LOD 100
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "RenderType" = "Opaque"
      }
      LOD 100
      Cull Off
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _MainTex_ST;
      
      uniform sampler2D _MainTex;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float2 texcoord : TEXCOORD0;
      
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
          
          out_v.texcoord.xy = in_v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
          
          u_xlat0 = in_v.vertex.yyyy * unity_ObjectToWorld[1];
          
          u_xlat0 = unity_ObjectToWorld[0] * in_v.vertex.xxxx + u_xlat0;
          
          u_xlat0 = unity_ObjectToWorld[2] * in_v.vertex.zzzz + u_xlat0;
          
          u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
          
          u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
          
          u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
          
          u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
          
          out_v.vertex = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float u_xlat16_0;
      
      float u_xlat10_0;
      
      float u_xlat16_1;
      
      float u_xlat16_2;
      
      float u_xlat16_4;
      
      float u_xlat16_7;
      
      float u_xlat16_10;
      
      OUT_Data_Frag frag(Interpolators in_f)
      {
          
          u_xlat10_0 = texture2D(_MainTex, in_f.texcoord.xy).x;
          
          u_xlat16_0 = u_xlat10_0 + -0.5;
          
          u_xlat16_1 = dFdx(u_xlat16_0);
          
          u_xlat16_4 = dFdy(u_xlat16_0);
          
          u_xlat16_1 = abs(u_xlat16_4) + abs(u_xlat16_1);
          
          u_xlat16_4 = u_xlat16_0 + u_xlat16_1;
          
          u_xlat16_1 = u_xlat16_1 + u_xlat16_1;
          
          u_xlat16_1 = float(1.0) / u_xlat16_1;
          
          u_xlat16_1 = u_xlat16_1 * u_xlat16_4;
          
          u_xlat16_1 = clamp(u_xlat16_1, 0.0, 1.0);
          
          u_xlat16_4 = u_xlat16_1 * -2.0 + 3.0;
          
          u_xlat16_1 = u_xlat16_1 * u_xlat16_1;
          
          u_xlat16_1 = u_xlat16_1 * u_xlat16_4;
          
          u_xlat16_4 = abs(u_xlat16_0) * 40.0;
          
          u_xlat16_7 = -abs(u_xlat16_0) + 1.0;
          
          u_xlat16_4 = sin(u_xlat16_4);
          
          u_xlat16_10 = dFdx(u_xlat16_4);
          
          u_xlat16_2 = dFdy(u_xlat16_4);
          
          u_xlat16_10 = abs(u_xlat16_10) + abs(u_xlat16_2);
          
          u_xlat16_4 = u_xlat16_10 + u_xlat16_4;
          
          u_xlat16_10 = u_xlat16_10 + u_xlat16_10;
          
          u_xlat16_10 = float(1.0) / u_xlat16_10;
          
          u_xlat16_4 = u_xlat16_10 * u_xlat16_4;
          
          u_xlat16_4 = clamp(u_xlat16_4, 0.0, 1.0);
          
          u_xlat16_10 = u_xlat16_4 * -2.0 + 3.0;
          
          u_xlat16_4 = u_xlat16_4 * u_xlat16_4;
          
          u_xlat16_4 = u_xlat16_4 * u_xlat16_10;
          
          u_xlat16_4 = u_xlat16_4 * 0.150000006 + 0.850000024;
          
          u_xlat16_4 = u_xlat16_4 * u_xlat16_7;
          
          out_f.color.yz = float2(u_xlat16_1) * float2(u_xlat16_4);
          
          out_f.color.x = u_xlat16_4;
          
          out_f.color.w = 1.0;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
