Shader "Obi/PropertyGradientMaterial" {

	Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }

	SubShader { 

		Pass {
       
            Offset 0, -50
			Cull Back 
			Fog { Mode Off }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

			struct vin{
				float4 vertex   : POSITION;
				fixed4 color    : COLOR;
				float2 texcoord  : TEXCOORD0;
			};

            struct Interpolators {
                float4 pos: POSITION;
                fixed4 color    : COLOR;
				float2 texcoord  : TEXCOORD0;
            };

			sampler2D _MainTex;

            Interpolators vert(vin v) {
                Interpolators o;
                o.pos = UnityObjectToClipPos (v.vertex);
                o.texcoord = v.texcoord;
				o.color = v.color;
                return o;
            }

            fixed4 frag(Interpolators i) : SV_Target {
                return i.color;
            }

            ENDCG
        }

        Pass {

            Offset 0, -100
            Cull Back 
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            Fog { Mode Off }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct vin{
                float4 vertex   : POSITION;
                fixed4 color    : COLOR;
                float2 texcoord  : TEXCOORD0;
            };

            struct Interpolators {
                float4 pos: POSITION;
                fixed4 color    : COLOR;
                float2 texcoord  : TEXCOORD0;
            };

            sampler2D _MainTex;

            Interpolators vert(vin v) {
                Interpolators o;
                o.pos = UnityObjectToClipPos (v.vertex);
                o.texcoord = v.texcoord;
                o.color = v.color;
                return o;
            }

            fixed4 frag(Interpolators i) : SV_Target {
                return i.color;
            }

            ENDCG
        }
 
	} 
}

