// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Skybox/Rorschach"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _BlackLevel("Black Level", Range(0, 1)) = 0.27
        _Contrast("Contrast", float) = 60
        _Speed("Speed", float) = .1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            // Most of this is boilerplate Unity creates for us
            // when we create a new shader. I removed the fog stuff...
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
            float4 _MainTex_ST;
            // ...and added these variables to tune the blobbiness:
            float _BlackLevel;
            float _Contrast;
			float _Speed;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);

                // Convert texture coordinates into range [-1, 1].
                // This makes our symmetry calculations neater.
                o.uv = v.uv * 2.0f - 1.0f;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 mirrored = abs(i.uv);
                // Mirror the x direction to get the classic symmetrical look,
                // and multiply by texture scale so we can handle rectangular quads.
                float2 uv = float2(mirrored.x, i.uv.y) * _MainTex_ST.xy;

                // These arbitrary magic numbers just scroll two samples of the noise texture
                // at different scales/directions/offsets so it doesn't look too regular.
                // Changing these values will change the movement speed/direction/blobbiness.
                float noise = tex2D(_MainTex, 0.3f * uv + (_Time.x*_Speed) * float2(0.2f, 0.1f)).r
                    * tex2D(_MainTex, uv + (_Time.x*_Speed) * float2(-0.3f, -0.1f) + float2(0.2f, 0.3f)).r;

                // Calculate a gradient that's brightest at the edges, to feather out the blob.
                float mask = max(mirrored.x, mirrored.y);
                mask *= mask * mask * _BlackLevel;

                // Threshold the sum to get the desired blobbiness.
                return saturate((noise + mask - _BlackLevel) * _Contrast);
            }
            ENDCG
        }
    }
}