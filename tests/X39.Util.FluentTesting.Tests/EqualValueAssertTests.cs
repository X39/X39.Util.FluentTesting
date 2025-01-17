using System.Diagnostics.CodeAnalysis;
using X39.Util.FluentTesting.Tests.Data;
using X39.Util.FluentTesting.Value.Extensions;
using Xunit.Sdk;

namespace X39.Util.FluentTesting.Tests;

// @formatter:max_line_length 20000
/// <summary>
/// Provides unit tests for verifying equality assertions using the Expect library.
/// </summary>
/// <remarks>
/// This test class verifies the correctness of equality checks for multiple data types, ensuring that assertions throw exceptions for mismatched values and do not throw exceptions for matching values.
/// Coverage includes tests on primitive data types, floating-point numbers, and classes implementing equality.
/// </remarks>
[SuppressMessage("ReSharper", "RedundantTypeArgumentsOfMethod")]
public class EqualValueAssertTests
{
    [Fact]
    public void ThrowsOnBoolEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value(true).Is().Equal().To(false));
    }

    [Fact]
    public void ThrowsOnStringEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value("foobar").Is().Equal().To("raboof"));
    }

    [Fact]
    public void ThrowsOnByteEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<byte>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnSbyteEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<sbyte>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnUshortEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<ushort>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnShortEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<short>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnUintEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<uint>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnIntEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<int>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnUlongEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<ulong>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnLongEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<long>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnFloatEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<float>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnDoubleEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<double>(1).Is().Equal().To(2));
    }

    [Fact]
    public void ThrowsOnDecimalEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value<decimal>(1).Is().Equal().To(2));
    }


    [Fact]
    public void DoesNotThrowOnBoolEqualityMatch()
    {
        Expect.That.Value(true).Is().Equal().To(true);
    }

    [Fact]
    public void DoesNotThrowOnStringEqualityMatch()
    {
        Expect.That.Value("foobar").Is().Equal().To("foobar");
    }

    [Fact]
    public void DoesNotThrowOnByteEqualityMatch()
    {
        Expect.That.Value<byte>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnSbyteEqualityMatch()
    {
        Expect.That.Value<sbyte>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnUshortEqualityMatch()
    {
        Expect.That.Value<ushort>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnShortEqualityMatch()
    {
        Expect.That.Value<short>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnUintEqualityMatch()
    {
        Expect.That.Value<uint>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnIntEqualityMatch()
    {
        Expect.That.Value<int>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnUlongEqualityMatch()
    {
        Expect.That.Value<ulong>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnLongEqualityMatch()
    {
        Expect.That.Value<long>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnFloatEqualityMatch()
    {
        Expect.That.Value<float>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnDoubleEqualityMatch()
    {
        Expect.That.Value<double>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnDecimalEqualityMatch()
    {
        Expect.That.Value<decimal>(1).Is().Equal().To(1);
    }

    [Fact]
    public void DoesNotThrowOnClassWithEqualImplementedEqualityMatch()
    {
        var actual = new SampleClassYesEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };
        var expected = new SampleClassYesEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };

        Expect.That.Value(actual).Is().Equal().To(expected);
        Expect.That.Value(default(SampleClassYesEquals)).Is().Equal().To(null);
    }

    [Fact]
    public void DoesThrowOnClassWithEqualImplementedEqualityMismatch()
    {
        var actual = new SampleClassYesEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };
        var expected1 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "raboof",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "raboof",
            },
        };
        var expected2 = new SampleClassYesEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "raboof",
            },
        };

        Assert.ThrowsAny<XunitException>(() => Expect.That.Value(actual).Is().Equal().To(expected1));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value(actual).Is().Equal().To(expected2));
    }


    [SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped")]
    [Fact(Skip = "XUnit does not support Equal check on classes without an Equals method. This test exists to document that behavior.")]
    public void DoesNotThrowOnClassWithNoEqualImplementedEqualityMatch()
    {
        var actual = new SampleClassNoEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };
        var expected = new SampleClassNoEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };

        Expect.That.Value(actual).Is().Equal().To(expected);
        Expect.That.Value(default(SampleClassNoEquals)).Is().Equal().To(null);
    }

    [Fact]
    public void DoesThrowOnClassWithNoEqualImplementedEqualityMismatch()
    {
        var actual = new SampleClassNoEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "foobar",
            },
        };
        var expected1 = new SampleClassNoEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "raboof",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "raboof",
            },
        };
        var expected2 = new SampleClassNoEquals
        {
            FloatField = 1.5F,
            IntProperty = 1,
            StringProperty = "foobar",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 1.5F,
                IntProperty = 1,
                StringProperty = "raboof",
            },
        };

        Assert.ThrowsAny<XunitException>(() => Expect.That.Value(actual).Is().Equal().To(expected1));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Value(actual).Is().Equal().To(expected2));
    }
}
// @formatter:max_line_length restore