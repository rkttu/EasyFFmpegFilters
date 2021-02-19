namespace EasyFFmpeg
{
    /// <summary>
    /// Copy the input audio source unchanged to the output. This is mainly useful for testing purposes.
    /// </summary>
    public class AudioCopyFilter : AudioFilter
    {
        public override string Name => "acopy";
    }
}
