using X39.Util.FluentTesting.Sequence.Asserts;

namespace X39.Util.FluentTesting.Sequence.Extensions;

/// <summary>
/// Provides extension methods to perform assertions on sequences.
/// </summary>
/// <remarks>
/// The methods in this class are designed to simplify assertion logic by chaining operations directly on the instance
/// of the <see cref="IsSequence{T}"/> type. This allows for more readable and concise testing code in value validation scenarios.
/// </remarks>
public static class IsSequenceExtensions
{
    /// <summary>
    /// Creates an instance of <see cref="EqualSequenceAssert{T}"/> to verify
    /// that the sequence matches the expected sequence in both order and value.
    /// </summary>
    /// <typeparam name="T">The type of elements in the sequence.</typeparam>
    /// <param name="self">
    /// The instance of <see cref="IsSequence{T}"/> representing the sequence to be validated.
    /// </param>
    /// <returns>
    /// An instance of <see cref="EqualSequenceAssert{T}"/> for asserting equality of the sequence.
    /// </returns>
    public static EqualSequenceAssert<T> Equal<T>(this IsSequence<T> self) => new(self.Values);
}