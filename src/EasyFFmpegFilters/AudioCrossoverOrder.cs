namespace EasyFFmpeg
{
    public enum AudioCrossoverOrder
    {
        /// <summary>
        /// Default value. 24 dB per octave.
        /// </summary>
        [EnumStringValue("4th")]
        _4th,

        /// <summary>
        /// 12 dB per octave.
        /// </summary>
        [EnumStringValue("2nd")]
        _2nd,

        /// <summary>
        /// 36 dB per octave.
        /// </summary>
        [EnumStringValue("6th")]
        _6th,

        /// <summary>
        /// 48 dB per octave.
        /// </summary>
        [EnumStringValue("8th")]
        _8th,

        /// <summary>
        /// 60 dB per octave.
        /// </summary>
        [EnumStringValue("10th")]
        _10th,

        /// <summary>
        /// 72 dB per octave.
        /// </summary>
        [EnumStringValue("12th")]
        _12th,

        /// <summary>
        /// 84 dB per octave.
        /// </summary>
        [EnumStringValue("14th")]
        _14th,

        /// <summary>
        /// 96 dB per octave.
        /// </summary>
        [EnumStringValue("16th")]
        _16th,

        /// <summary>
        /// 108 dB per octave.
        /// </summary>
        [EnumStringValue("18th")]
        _18th,

        /// <summary>
        /// 120 dB per octave.
        /// </summary>
        [EnumStringValue("20th")]
        _20th,
    }
}
