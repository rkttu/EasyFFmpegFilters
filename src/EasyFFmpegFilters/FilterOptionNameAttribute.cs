using System;

namespace EasyFFmpeg
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FilterOptionNameAttribute : Attribute
    {
        public FilterOptionNameAttribute(string canonicalName, object defaultValue, object minimumValue, object maximumValue)
        {
            CanonicalName = canonicalName ?? throw new ArgumentNullException(nameof(canonicalName));
            DefaultValue = defaultValue;
            MinimumValue = minimumValue;
            MaximumValue = maximumValue;
        }

        public FilterOptionNameAttribute(string canonicalName, object defaultValue)
            : this(canonicalName, defaultValue, null, null)
        {
        }

        public string CanonicalName { get; }

        public object DefaultValue { get; }

        public object MinimumValue { get; }

        public object MaximumValue { get; }

        public bool HasRange => MinimumValue is IComparable && MaximumValue is IComparable && DefaultValue is IComparable;

        public override string ToString() => $"{CanonicalName}={DefaultValue}";
    }
}
