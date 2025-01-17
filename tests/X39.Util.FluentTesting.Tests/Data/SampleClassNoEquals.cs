namespace X39.Util.FluentTesting.Tests.Data;

public class SampleClassNoEquals
{
    public class NestedClass
    {
        public required int IntProperty { get; init; }
        public required float FloatField;
        public required string StringProperty { get; init; }
    }

    public required int IntProperty { get; init; }
    public required float FloatField;
    public required string StringProperty { get; init; }
    public required NestedClass NestedClassProperty { get; init; }
}