namespace EasyFFmpeg
{
    /// <summary>
    /// Simple audio dynamic range compression/expansion filter.
    /// </summary>
    public class AudioContrastFilter : AudioFilter
    {
        public override string Name => "aconstrast";

        [FilterOptionName("contrast", 33, 0, 100)]
        public int? Contrast { get; set; } = default;
    }
}
