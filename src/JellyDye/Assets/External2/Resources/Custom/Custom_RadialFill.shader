Shader "Custom/RadialFill"
{
  Properties
  {
    [PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
    _Color ("Tint", Color) = (1,1,1,1)
    _Angle ("Angle", Range(0, 360)) = 0
    _Arc1 ("Arc Point 1", Range(0, 360)) = 15
    _Arc2 ("Arc Point 2", Range(0, 360)) = 15
    [MaterialToggle] PixelSnap ("Pixel snap", float) = 0
  }
  SubShader
  {
    Tags
    { 
      "CanUseSpriteAtlas" = "true"
      "IGNOREPROJECTOR" = "true"
      "PreviewType" = "Plane"
      "QUEUE" = "Transparent"
      "RenderType" = "Transparent"
    }
    Pass // ind: 1, name: 
    {
      Tags
      { 
        "CanUseSpriteAtlas" = "true"
        "IGNOREPROJECTOR" = "true"
        "PreviewType" = "Plane"
        "QUEUE" = "Transparent"
        "RenderType" = "Transparent"
      }
      ZWrite Off
      Cull Off
      Blend One OneMinusSrcAlpha
      // m_ProgramMask = 6
      CGPROGRAM
      //#pragma target 4.0
      
      #pragma vertex vert
      #pragma fragment frag
      
      #include "UnityCG.cginc"
      
      
      #define CODE_BLOCK_VERTEX
      
      
      uniform float4 unity_ObjectToWorld[4];
      
      uniform float4 unity_MatrixVP[4];
      
      uniform float4 _Color;
      
      uniform float _Angle;
      
      uniform float _Arc1;
      
      uniform float _Arc2;
      
      uniform sampler2D _MainTex;
      
      
      
      struct appdata_t
      {
          
          float4 vertex : POSITION0;
          
          float4 color : COLOR0;
          
          float2 texcoord : TEXCOORD0;
      
      };
      
      
      struct OUT_Data_Vert
      {
          
          float4 color : COLOR0;
          
          float2 texcoord : TEXCOORD0;
          
          float4 vertex : SV_POSITION;
      
      };
      
      
      struct v2f
      {
          
          float4 color : COLOR0;
          
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
          
          u_xlat0 = in_v.color * _Color;
          
          out_v.color = u_xlat0;
          
          out_v.texcoord.xy = in_v.texcoord.xy;
          
          return;
      
      }
      
      
      #define CODE_BLOCK_FRAGMENT
      
      
      
      
      float u_xlat0_d;
      
      float4 u_xlat16_0;
      
      float4 u_xlat10_0;
      
      int u_xlatb0;
      
      float u_xlat1_d;
      
      int u_xlatb1;
      
      float u_xlat2;
      
      int u_xlatb2;
      
      float u_xlat3;
      
      int u_xlatb3;
      
      float2 u_xlat4;
      
      int u_xlatb4;
      
      float u_xlat5;
      
      float u_xlat6;
      
      int u_xlatb6;
      
      int u_xlatb7;
      
      OUT_Data_Frag frag(v2f in_f)
      {
          
          u_xlat0_d = (-_Arc1) + _Angle;
          
          u_xlat2 = _Arc2 + _Angle;
          
          u_xlat4.xy = in_f.texcoord.yx * float2(2.0, 2.0) + float2(-1.0, -1.0);
          
          u_xlat1_d = min(abs(u_xlat4.y), abs(u_xlat4.x));
          
          u_xlat3 = max(abs(u_xlat4.y), abs(u_xlat4.x));
          
          u_xlat3 = float(1.0) / u_xlat3;
          
          u_xlat1_d = u_xlat3 * u_xlat1_d;
          
          u_xlat3 = u_xlat1_d * u_xlat1_d;
          
          u_xlat5 = u_xlat3 * 0.0208350997 + -0.0851330012;
          
          u_xlat5 = u_xlat3 * u_xlat5 + 0.180141002;
          
          u_xlat5 = u_xlat3 * u_xlat5 + -0.330299497;
          
          u_xlat3 = u_xlat3 * u_xlat5 + 0.999866009;
          
          u_xlat5 = u_xlat3 * u_xlat1_d;
          
          u_xlatb7 = abs(u_xlat4.y)<abs(u_xlat4.x);
          
          u_xlat5 = u_xlat5 * -2.0 + 1.57079637;
          
          u_xlat5 = u_xlatb7 ? u_xlat5 : float(0.0);
          
          u_xlat1_d = u_xlat1_d * u_xlat3 + u_xlat5;
          
          u_xlatb3 = u_xlat4.y<(-u_xlat4.y);
          
          u_xlat3 = u_xlatb3 ? -3.14159274 : float(0.0);
          
          u_xlat1_d = u_xlat3 + u_xlat1_d;
          
          u_xlat3 = min(u_xlat4.y, u_xlat4.x);
          
          u_xlat4.x = max(u_xlat4.y, u_xlat4.x);
          
          u_xlatb6 = u_xlat3<(-u_xlat3);
          
          u_xlatb4 = u_xlat4.x>=(-u_xlat4.x);
          
          u_xlatb4 = u_xlatb4 && u_xlatb6;
          
          u_xlat4.x = (u_xlatb4) ? (-u_xlat1_d) : u_xlat1_d;
          
          u_xlat6 = u_xlat4.x * 57.2999992;
          
          u_xlatb1 = u_xlat4.x<0.0;
          
          u_xlat4.x = u_xlat4.x * 57.2999992 + 360.0;
          
          u_xlat4.x = (u_xlatb1) ? u_xlat4.x : u_xlat6;
          
          u_xlatb6 = u_xlat4.x>=u_xlat0_d;
          
          u_xlatb1 = u_xlat2>=u_xlat4.x;
          
          u_xlatb6 = u_xlatb6 && u_xlatb1;
          
          if(u_xlatb6)
      {
              discard;
      }
          
          u_xlat2 = u_xlat2 + -360.0;
          
          u_xlat2 = min(u_xlat2, 360.0);
          
          u_xlatb2 = u_xlat2>=u_xlat4.x;
          
          if(u_xlatb2)
      {
              discard;
      }
          
          u_xlat0_d = u_xlat0_d + 360.0;
          
          u_xlat0_d = min(u_xlat0_d, 360.0);
          
          u_xlatb0 = u_xlat4.x>=u_xlat0_d;
          
          if(u_xlatb0)
      {
              discard;
      }
          
          u_xlat10_0 = texture2D(_MainTex, in_f.texcoord.xy);
          
          u_xlat16_0 = u_xlat10_0 * in_f.color;
          
          out_f.color.xyz = u_xlat16_0.www * u_xlat16_0.xyz;
          
          out_f.color.w = u_xlat16_0.w;
          
          return;
      
      }
      
      
      ENDCG
      
    } // end phase
  }
  FallBack Off
}
