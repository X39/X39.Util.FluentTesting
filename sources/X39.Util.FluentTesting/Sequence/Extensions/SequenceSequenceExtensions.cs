namespace X39.Util.FluentTesting.Sequence.Extensions;

/// <summary>
/// Contains extension methods for working with instances of <see cref="SequenceSequence{T}"/>.
/// </summary>
/// <remarks>
/// These extensions simplify operations and transformations on <see cref="SequenceSequence{T}"/> objects.
/// </remarks>
public static class SequenceSequenceExtensions
{
    /// <summary>
    /// Converts a <see cref="SequenceSequence{T}"/> instance to an <see cref="IsSequence{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="self">The <see cref="SequenceSequence{T}"/> instance to convert.</param>
    /// <returns>An <see cref="IsSequence{T}"/> instance containing the sequence from the input <see cref="SequenceSequence{T}"/>.</returns>
    public static IsSequence<T> Is<T>(this SequenceSequence<T> self) => new(self.Values);
}