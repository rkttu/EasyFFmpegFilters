namespace EasyFFmpeg
{
    public class AudioCrossoverFilter : AudioFilter
    {
        public override string Name => "acrossover";

        /// <summary>
        /// Set split frequencies. Those must be positive and increasing.
        /// </summary>
        [FilterOptionName("split", null)]
        public int[] Split { get; set; } = default;

        /// <summary>
        /// Set filter order for each band split. This controls filter roll-off or steepness of filter transfer function.
        /// </summary>
        [FilterOptionName("order", AudioCrossoverOrder._4th)]
        public AudioCrossoverOrder? Order { get; set; } = default;

        /// <summary>
        /// Set input gain level. Allowed range is from 0 to 1. Default value is 1.
        /// </summary>
        [FilterOptionName("level", 1f, 0f, 1f)]
        public float? Level { get; set; } = default;

        /// <summary>
        /// Set output gain for each band. Default value is 1 for all bands.
        /// </summary>
        [FilterOptionName("gains", 1)]
        public int? Gains { get; set; } = default;
    }
}
