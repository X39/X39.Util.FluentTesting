using System.Diagnostics.CodeAnalysis;
using X39.Util.FluentTesting.Sequence.Extensions;
using X39.Util.FluentTesting.Tests.Data;
using X39.Util.FluentTesting.Value.Extensions;
using Xunit.Sdk;

namespace X39.Util.FluentTesting.Tests;

// @formatter:max_line_length 20000
[SuppressMessage("ReSharper", "RedundantTypeArgumentsOfMethod")]
public class EqualSequenceAssertTests
{
    [Fact]
    public void ThrowsOnBoolSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(true, true, true).Is().Equal().To(true, true, false));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(true, false, true, false).Is().Equal().To(false, true, false, true));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(true, false).Is().Equal().To(true, false, true));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(true, false, true).Is().Equal().To(true, false));
    }

    [Fact]
    public void ThrowsOnStringSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence("foo", "bar", "foobar").Is().Equal().To("foo", "bar", "raboof"));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence("foo", "bar", "foobar").Is().Equal().To("foobar", "bar", "foo"));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence("foo", "bar").Is().Equal().To("foo", "bar", "foobar"));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence("foo", "bar", "foobar").Is().Equal().To("foo", "bar"));
    }

    [Fact]
    public void ThrowsOnByteSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<byte>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<byte>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<byte>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<byte>(1, 2).Is().Equal().To(1, 2, 3));
    }


    [Fact]
    public void ThrowsOnSbyteSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<sbyte>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<sbyte>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<sbyte>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<sbyte>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnShortSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<short>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<short>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<short>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<short>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnUshortSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ushort>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ushort>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ushort>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ushort>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnIntSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<int>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<int>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<int>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<int>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnUintSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<uint>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<uint>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<uint>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<uint>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnLongSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<long>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<long>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<long>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<long>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnUlongSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ulong>(1, 2, 3).Is().Equal().To(1, 2, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ulong>(1, 2).Is().Equal().To(3, 4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ulong>(1, 2, 3).Is().Equal().To(1, 2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<ulong>(1, 2).Is().Equal().To(1, 2, 3));
    }

    [Fact]
    public void ThrowsOnFloatSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<float>(1.1f, 2.2f, 3.3f).Is().Equal().To(1.1f, 2.2f, 4.4f));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<float>(1.1f, 2.2f).Is().Equal().To(3.3f, 4.4f));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<float>(1.1f, 2.2f, 3.3f).Is().Equal().To(1.1f, 2.2f));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<float>(1.1f, 2.2f).Is().Equal().To(1.1f, 2.2f, 3.3f));
    }

    [Fact]
    public void ThrowsOnDoubleSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<double>(1.1, 2.2, 3.3).Is().Equal().To(1.1, 2.2, 4.4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<double>(1.1, 2.2).Is().Equal().To(3.3, 4.4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<double>(1.1, 2.2, 3.3).Is().Equal().To(1.1, 2.2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<double>(1.1, 2.2).Is().Equal().To(1.1, 2.2, 3.3));
    }

    [Fact]
    public void ThrowsOnDecimalSequenceEqualityMismatch()
    {
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<decimal>(1.1m, 2.2m, 3.3m).Is().Equal().To(1.1m, 2.2m, 4.4m));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<decimal>(1.1m, 2.2m).Is().Equal().To(3.3m, 4.4m));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<decimal>(1.1m, 2.2m, 3.3m).Is().Equal().To(1.1m, 2.2m));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence<decimal>(1.1m, 2.2m).Is().Equal().To(1.1m, 2.2m, 3.3m));
    }

    [Fact]
    public void DoesNotThrowOnBoolSequenceEquality()
    {
        Expect.That.Sequence(true, true, true).Is().Equal().To(true, true, true);
        Expect.That.Sequence(true, false, true, false).Is().Equal().To(true, false, true, false);
        Expect.That.Sequence<bool>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnStringSequenceEquality()
    {
        Expect.That.Sequence("foo", "bar", "foobar").Is().Equal().To("foo", "bar", "foobar");
        Expect.That.Sequence("single").Is().Equal().To("single");
        Expect.That.Sequence<string>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnByteSequenceEquality()
    {
        Expect.That.Sequence<byte>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<byte>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnSbyteSequenceEquality()
    {
        Expect.That.Sequence<sbyte>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<sbyte>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnShortSequenceEquality()
    {
        Expect.That.Sequence<short>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<short>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnUshortSequenceEquality()
    {
        Expect.That.Sequence<ushort>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<ushort>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnIntSequenceEquality()
    {
        Expect.That.Sequence<int>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<int>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnUintSequenceEquality()
    {
        Expect.That.Sequence<uint>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<uint>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnLongSequenceEquality()
    {
        Expect.That.Sequence<long>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<long>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnUlongSequenceEquality()
    {
        Expect.That.Sequence<ulong>(1, 2, 3).Is().Equal().To(1, 2, 3);
        Expect.That.Sequence<ulong>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnFloatSequenceEquality()
    {
        Expect.That.Sequence<float>(1.1f, 2.2f, 3.3f).Is().Equal().To(1.1f, 2.2f, 3.3f);
        Expect.That.Sequence<float>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnDoubleSequenceEquality()
    {
        Expect.That.Sequence<double>(1.1, 2.2, 3.3).Is().Equal().To(1.1, 2.2, 3.3);
        Expect.That.Sequence<double>().Is().Equal().To();
    }

    [Fact]
    public void DoesNotThrowOnDecimalSequenceEquality()
    {
        Expect.That.Sequence<decimal>(1.1m, 2.2m, 3.3m).Is().Equal().To(1.1m, 2.2m, 3.3m);
        Expect.That.Sequence<decimal>().Is().Equal().To();
    }


    [Fact]
    public void DoesNotThrowOnClassWithEqualImplementedEqualityMatch()
    {
        var actual1 = new SampleClassYesEquals
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

        var actual2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var actual3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };
        var expected1 = new SampleClassYesEquals
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

        var expected2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var expected3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2, expected3);
        Expect.That.Sequence(actual1, null, actual3).Is().Equal().To(expected1, null, expected3);
    }

    [Fact]
    public void DoesNotThrowOnClassWithEqualImplementedEqualityMismatch()
    {
        var actual1 = new SampleClassYesEquals
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

        var actual2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var actual3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        var actual4 = new SampleClassYesEquals
        {
            FloatField = 4.5F,
            IntProperty = 4,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 4.5F,
                IntProperty = 4,
                StringProperty = "different",
            },
        };

        var expected1 = new SampleClassYesEquals
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

        var expected2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var expected3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        var expected4 = new SampleClassYesEquals
        {
            FloatField = 4.5F,
            IntProperty = 4,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 4.5F,
                IntProperty = 4,
                StringProperty = "different",
            },
        };

        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2, expected4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2).Is().Equal().To(expected3, actual4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2).Is().Equal().To(expected1, expected2, expected3));
    }

    [SuppressMessage("Usage", "xUnit1004:Test methods should not be skipped")]
    [Fact(Skip = "XUnit does not support Equal check on classes without an Equals method. This test exists to document that behavior.")]
    public void DoesNotThrowOnClassWithNoEqualImplementedEqualityMatch()
    {
        var actual1 = new SampleClassNoEquals
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

        var actual2 = new SampleClassNoEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var actual3 = new SampleClassNoEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };
        var expected1 = new SampleClassNoEquals
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

        var expected2 = new SampleClassNoEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var expected3 = new SampleClassNoEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassNoEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2, expected3);
        Expect.That.Sequence(actual1, null, actual3).Is().Equal().To(expected1, null, expected3);
    }

    [Fact]
    public void DoesNotThrowOnClassWithNoEqualImplementedEqualityMismatch()
    {
        var actual1 = new SampleClassYesEquals
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

        var actual2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var actual3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        var actual4 = new SampleClassYesEquals
        {
            FloatField = 4.5F,
            IntProperty = 4,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 4.5F,
                IntProperty = 4,
                StringProperty = "different",
            },
        };

        var expected1 = new SampleClassYesEquals
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

        var expected2 = new SampleClassYesEquals
        {
            FloatField = 2.5F,
            IntProperty = 2,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 2.5F,
                IntProperty = 2,
                StringProperty = "different",
            },
        };

        var expected3 = new SampleClassYesEquals
        {
            FloatField = 3.5F,
            IntProperty = 3,
            StringProperty = "another",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 3.5F,
                IntProperty = 3,
                StringProperty = "another",
            },
        };

        var expected4 = new SampleClassYesEquals
        {
            FloatField = 4.5F,
            IntProperty = 4,
            StringProperty = "different",
            NestedClassProperty = new SampleClassYesEquals.NestedClass
            {
                FloatField = 4.5F,
                IntProperty = 4,
                StringProperty = "different",
            },
        };

        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2, expected4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2).Is().Equal().To(expected3, actual4));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2, actual3).Is().Equal().To(expected1, expected2));
        Assert.ThrowsAny<XunitException>(() => Expect.That.Sequence(actual1, actual2).Is().Equal().To(expected1, expected2, expected3));
    }
}
// @formatter:max_line_length restore