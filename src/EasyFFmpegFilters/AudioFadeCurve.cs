namespace EasyFFmpeg
{
    public enum AudioFadeCurve
    {
        /// <summary>
        /// select triangular, linear slope (default)
        /// </summary>
        [EnumStringValue("tri")]
        Tri,

        /// <summary>
        /// select quarter of sine wave
        /// </summary>
        [EnumStringValue("qsin")]
        Qsin,

        /// <summary>
        /// select half of sine wave
        /// </summary>
        [EnumStringValue("hsin")]
        Hsin,

        /// <summary>
        /// select exponential sine wave
        /// </summary>
        [EnumStringValue("esin")]
        Esin,

        /// <summary>
        /// select logarithmic
        /// </summary>
        [EnumStringValue("log")]
        Log,

        /// <summary>
        /// select inverted parabola
        /// </summary>
        [EnumStringValue("ipar")]
        Ipar,

        /// <summary>
        /// select quadratic
        /// </summary>
        [EnumStringValue("qua")]
        Qua,

        /// <summary>
        /// select cubic
        /// </summary>
        [EnumStringValue("cub")]
        Cub,

        /// <summary>
        /// select square root
        /// </summary>
        [EnumStringValue("squ")]
        Squ,

        /// <summary>
        /// select cubic root
        /// </summary>
        [EnumStringValue("cbr")]
        Cbr,

        /// <summary>
        /// select parabola
        /// </summary>
        [EnumStringValue("par")]
        Par,

        /// <summary>
        /// select exponential
        /// </summary>
        [EnumStringValue("exp")]
        Exp,

        /// <summary>
        /// select inverted quarter of sine wave
        /// </summary>
        [EnumStringValue("iqsin")]
        Iqsin,

        /// <summary>
        /// select inverted half of sine wave
        /// </summary>
        [EnumStringValue("ihsin")]
        Ihsin,

        /// <summary>
        /// select double-exponential seat
        /// </summary>
        [EnumStringValue("dese")]
        Dese,

        /// <summary>
        /// select double-exponential sigmoid
        /// </summary>
        [EnumStringValue("desi")]
        Desi,

        /// <summary>
        /// select logistic sigmoid
        /// </summary>
        [EnumStringValue("losi")]
        Losi,

        /// <summary>
        /// select sine cardinal function
        /// </summary>
        [EnumStringValue("sinc")]
        Sinc,

        /// <summary>
        /// select inverted sine cardinal function
        /// </summary>
        [EnumStringValue("isinc")]
        Isinc,

        /// <summary>
        /// no fade applied
        /// </summary>
        [EnumStringValue("nofade")]
        NoFade,
    }
}
