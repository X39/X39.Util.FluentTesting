using System.Collections.Immutable;

namespace X39.Util.FluentTesting.Sequence;

/// <summary>
/// Represents a sequence of values of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the elements in the sequence.</typeparam>
/// <remarks>
/// This struct is used for working with immutable sequences of values. Its primary purpose
/// is to provide structured and type-safe encapsulation for sequences of values through records.
/// </remarks>
public readonly record struct SequenceSequence<T>(ImmutableArray<T> Values);