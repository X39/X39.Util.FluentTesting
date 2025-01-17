using System.Collections.Immutable;

namespace X39.Util.FluentTesting.Sequence;

/// <summary>
/// Represents a wrapper for a sequence of values of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the elements in the sequence.</typeparam>
public readonly record struct IsSequence<T>(ImmutableArray<T> Values);