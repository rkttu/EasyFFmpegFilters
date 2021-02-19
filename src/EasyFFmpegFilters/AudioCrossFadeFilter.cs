namespace EasyFFmpeg
{
    public class AudioCrossFadeFilter : AudioFilter
    {
        public override string Name => "acrossfade";

        /// <summary>
        /// Specify the number of samples for which the cross fade effect has to last. At the end of the cross fade effect the first input audio will be completely silent. Default is 44100.
        /// </summary>
        [FilterOptionName("ns", 44100)]
        public int? NumberOfSamples { get; set; } = default;

        /// <summary>
        /// Specify the duration of the cross fade effect. See (ffmpeg-utils)the Time duration section in the ffmpeg-utils(1) manual for the accepted syntax. By default the duration is determined by nb_samples. If set this option is used instead of nb_samples.
        /// </summary>
        [FilterOptionName("d", null)]
        public float? Duration { get; set; } = default;

        /// <summary>
        /// Should first stream end overlap with second stream start. Default is enabled.
        /// </summary>
        [FilterOptionName("o", 1, 0, 1)]
        public int? Overlap { get; set; } = default;

        /// <summary>
        /// Set curve for cross fade transition for first stream.
        /// </summary>
        [FilterOptionName("curve1", AudioFadeCurve.Tri)]
        public AudioFadeCurve? Curve1 { get; set; } = default;

        /// <summary>
        /// Set curve for cross fade transition for second stream.
        /// </summary>
        [FilterOptionName("curve1", AudioFadeCurve.Tri)]
        public AudioFadeCurve? Curve2 { get; set; } = default;
    }
}
