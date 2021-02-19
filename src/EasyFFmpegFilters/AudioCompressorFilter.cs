namespace EasyFFmpeg
{
    public class AudioCompressorFilter : AudioFilter
    {
        public override string Name => "acompressor";

        /// <summary>
        /// Set input gain. Default is 1. Range is between 0.015625 and 64.
        /// </summary>
        [FilterOptionName("level_in", 1f, 0.015625f, 64f)]
        public float? LevelIn { get; set; } = default;

        /// <summary>
        /// Set mode of compressor operation. Can be upward or downward. Default is downward.
        /// </summary>
        [FilterOptionName("mode", AudioCompressorMode.Downward)]
        public AudioCompressorMode? Mode { get; set; } = default;

        /// <summary>
        /// If a signal of stream rises above this level it will affect the gain reduction. By default it is 0.125. Range is between 0.00097563 and 1.
        /// </summary>
        [FilterOptionName("threshold", 0.125f, 0.00097563f, 1f)]
        public float? Threshold { get; set; } = default;

        /// <summary>
        /// Set a ratio by which the signal is reduced. 1:2 means that if the level rose 4dB above the threshold, it will be only 2dB above after the reduction. Default is 2. Range is between 1 and 20.
        /// </summary>
        [FilterOptionName("ratio", 2, 1, 20)]
        public int? Ratio { get; set; } = default;

        /// <summary>
        /// Amount of milliseconds the signal has to rise above the threshold before gain reduction starts. Default is 20. Range is between 0.01 and 2000.
        /// </summary>
        [FilterOptionName("attack", 20f, 0.01f, 2000f)]
        public float? Attack { get; set; } = default;

        /// <summary>
        /// Amount of milliseconds the signal has to fall below the threshold before reduction is decreased again. Default is 250. Range is between 0.01 and 9000.
        /// </summary>
        [FilterOptionName("release", 250f, 0.01f, 9000f)]
        public float? Release { get; set; } = default;

        /// <summary>
        /// Set the amount by how much signal will be amplified after processing. Default is 1. Range is from 1 to 64.
        /// </summary>
        [FilterOptionName("makeup", 1, 1, 64)]
        public int? Makeup { get; set; } = default;

        /// <summary>
        /// Curve the sharp knee around the threshold to enter gain reduction more softly. Default is 2.82843. Range is between 1 and 8.
        /// </summary>
        [FilterOptionName("knee", 2.82843f, 1f, 8f)]
        public float? Knee { get; set; } = default;

        /// <summary>
        /// Choose if the average level between all channels of input stream or the louder(maximum) channel of input stream affects the reduction. Default is average.
        /// </summary>
        [FilterOptionName("filter", AudioCompressorLink.Average)]
        public AudioCompressorLink? Link { get; set; } = default;

        /// <summary>
        /// Should the exact signal be taken in case of peak or an RMS one in case of rms. Default is rms which is mostly smoother.
        /// </summary>
        [FilterOptionName("detection", AudioCompressorDetection.RMS)]
        public AudioCompressorDetection? Detection { get; set; } = default;

        /// <summary>
        /// How much to use compressed signal in output. Default is 1. Range is between 0 and 1.
        /// </summary>
        [FilterOptionName("mix", 1f, 0f, 1f)]
        public float? Mix { get; set; } = default;
    }
}
