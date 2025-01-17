using System.Diagnostics.CodeAnalysis;

namespace X39.Util.FluentTesting.Tests.Data;

[SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
[SuppressMessage("ReSharper", "UnassignedField.Global")]
public class SampleClassYesEquals
{
    public class NestedClass
    {
        public required int IntProperty { get; init; }
        public required float FloatField;
        public required string StringProperty { get; init; }

        public override bool Equals(object? obj)
        {
            return obj is NestedClass other && Equals(other);
        }

        public bool Equals(NestedClass other)
        {
            return FloatField.Equals(other.FloatField)
                   && IntProperty == other.IntProperty
                   && StringProperty == other.StringProperty;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloatField, IntProperty, StringProperty);
        }
    }

    public required int IntProperty { get; init; }
    public required float FloatField;
    public required string StringProperty { get; init; }
    public required NestedClass NestedClassProperty { get; init; }

    public override bool Equals(object? obj)
    {
        return obj is SampleClassYesEquals other && Equals(other);
    }

    public bool Equals(SampleClassYesEquals other)
    {
        return FloatField.Equals(other.FloatField)
               && IntProperty == other.IntProperty
               && StringProperty == other.StringProperty
               && NestedClassProperty.Equals(other.NestedClassProperty);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FloatField, IntProperty, StringProperty, NestedClassProperty);
    }
}