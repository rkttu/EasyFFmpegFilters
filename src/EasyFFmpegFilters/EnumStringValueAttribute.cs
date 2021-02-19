using System;

namespace EasyFFmpeg
{
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class EnumStringValueAttribute : Attribute
    {
        public EnumStringValueAttribute(string canonicalName)
        {
            CanonicalName = canonicalName ?? throw new ArgumentNullException(nameof(canonicalName));
        }

        public string CanonicalName { get; }

        public override string ToString() => CanonicalName;
    }
}
