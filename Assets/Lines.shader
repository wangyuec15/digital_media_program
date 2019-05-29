Shader "Custom/Lines"
{
    SubShader
    {

    Tags {"Queue" = "Transparent-1"}
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            ZTest LEqual
            Cull Off
            Fog { Mode Off }

            BindChannels
            {
              Bind "vertex", vertex
              Bind "color", color
            }
        }
    }
}