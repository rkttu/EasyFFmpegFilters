namespace EasyFFmpeg
{
    public abstract class AudioFilter : Filter
    {
        public override FilterType Type => FilterType.Audio;
    }
}
