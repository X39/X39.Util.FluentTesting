using System.Collections.Immutable;

namespace X39.Util.FluentTesting.Sequence.Asserts;

/// <summary>
/// Provides assertion methods to verify that a sequence of values matches
/// an expected sequence in both order and value.
/// </summary>
/// <typeparam name="T">
/// The type of elements contained in the sequence.
/// </typeparam>
public readonly record struct EqualSequenceAssert<T>(ImmutableArray<T> Values)
{
    /// <summary>
    /// Compares the current sequence of values with the expected sequence and asserts
    /// that all elements in both sequences are equal in order and value.
    /// </summary>
    /// <param name="expected">
    /// The expected sequence of values to compare against the current sequence.
    /// </param>
    /// <returns>
    /// The current sequence of values.
    /// </returns>
    public ImmutableArray<T> To(params ImmutableArray<T> expected)
    {
        Xunit.Assert.Collection(Values,
            expected.Select<T, Action<T>>(t => (value) => Xunit.Assert.Equal(t, value)).ToArray());
        return Values;
    }
}