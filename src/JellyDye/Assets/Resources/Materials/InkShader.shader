Shader "Custom/InkShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _InkTex ("Ink Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _InkAmount ("Ink Amount", Range(0, 1)) = 0
    }
 
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
 
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            sampler2D _InkTex;
            float4 _Color;
            float _InkAmount;
 
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 inkCol = tex2D(_InkTex, i.uv);
                fixed4 finalCol = lerp(col, inkCol, _InkAmount);
                finalCol.rgb *= _Color.rgb;
                finalCol.a *= col.a;
                return finalCol;
            }
            ENDCG
        }
    }
}