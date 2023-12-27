Shader "Fluxy/Rendering/DebugFluid"
{
    SubShader
    {
        Cull Off
        Tags {"Queue"="Geometry" "IgnoreProjector"="True" "RenderType"="Opaque"}

        Pass
        {
            Name "Render"
            
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"
            #include "../FluidUtils.hlsl"

            struct MeshData
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Interpolators
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float4 _Detail_ST;

            Interpolators vert (MeshData v)
            {
                Interpolators o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;

                return o;
            }
   
            float4 frag (Interpolators i) : SV_Target
            {
                float2 uv = TileToUV(i.uv,_TileIndex);
                float4 velocity = tex2D(_Velocity,uv);
                return float4(velocity.rg * 0.5 + 0.5,velocity.a * 2,1);
            }
            ENDHLSL
        }
      
    }
}
