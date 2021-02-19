namespace EasyFFmpeg
{
    public abstract class Filter
    {
        public abstract string Name { get; }

        public abstract FilterType Type { get; }
    }
}
