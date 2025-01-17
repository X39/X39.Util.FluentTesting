using X39.Util.FluentTesting.Sequence;
using X39.Util.FluentTesting.Value;

namespace X39.Util.FluentTesting;

/// <summary>
/// Provides extension methods for the <see cref="ThatValue"/> struct, enabling simplified
/// creation of testing-related constructs such as value and sequence-based wrappers.
/// </summary>
/// <remarks>
/// The <see cref="ThatExtensions"/> class acts as a central hub for extending the <see cref="ThatValue"/> struct
/// to streamline the process of constructing testing structures.
/// </remarks>
public static class ThatExtensions
{
    /// <summary>
    /// Creates a new <see cref="ValueValue{T}"/> instance with the specified value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="_">The <see cref="ThatValue"/> instance, providing the context for the extension method.</param>
    /// <param name="value">The value to wrap in a <see cref="ValueValue{T}"/> instance.</param>
    /// <returns>A <see cref="ValueValue{T}"/> instance containing the specified value.</returns>
    public static ValueValue<T> Value<T>(this ThatValue _, T value) => new(value);

    /// <summary>
    /// Creates a new <see cref="SequenceSequence{T}"/> instance using the specified sequence of values.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="_">The <see cref="ThatValue"/> instance, providing the context for the extension method.</param>
    /// <param name="values">The sequence of values to wrap in a <see cref="SequenceSequence{T}"/> instance.</param>
    /// <returns>A <see cref="SequenceSequence{T}"/> instance containing the specified sequence of values.</returns>
    public static SequenceSequence<T> Sequence<T>(this ThatValue _, params Span<T> values) => new([..values]);
}