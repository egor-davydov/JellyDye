// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'


Shader "Obi/TopologyBorders" {
Properties {
	_Color ("Main Color", Color) = (1,1,1,1)
}

SubShader {
	Tags { "RenderType"="Opaque" }
	LOD 100
	
	Pass {  

		ZWrite Off 
		ZTest always 
		Cull Off 
		Fog { Mode Off }

		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata_t {
				float4 vertex : POSITION;
			};

			struct Interpolators {
				float4 vertex : SV_POSITION;
			};

			fixed4 _Color;
			
			Interpolators vert (appdata_t v)
			{
				Interpolators o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				return o;
			}
			
			fixed4 frag (Interpolators i) : COLOR
			{
				fixed4 col = _Color;
				UNITY_OPAQUE_ALPHA(col.a);
				return col;
			}
		ENDCG
	}
}

}
