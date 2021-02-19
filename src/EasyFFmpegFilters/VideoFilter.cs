namespace EasyFFmpeg
{
    public abstract class VideoFilter : Filter
    {
        public override FilterType Type => FilterType.Video;
    }
}
