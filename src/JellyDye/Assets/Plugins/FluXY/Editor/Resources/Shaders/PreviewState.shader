Shader "Fluxy/Editor/PreviewState"
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


            sampler2D _MainTex;

            Interpolators vert (MeshData v)
            {
                Interpolators o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;

                return o;
            }
   
            float4 frag (Interpolators i) : SV_Target
            {
                float4 state = tex2D(_MainTex,i.uv);
                return float4(state.rgba);
            }
            ENDHLSL
        }
      
    }
}
