namespace X39.Util.FluentTesting.Value.Extensions;

/// <summary>
/// Contains extension methods for working with instances of <see cref="ValueValue{T}"/>.
/// </summary>
/// <remarks>
/// These extensions simplify operations and transformations on <see cref="ValueValue{T}"/> objects.
/// </remarks>
public static class ValueValueExtensions
{
    /// <summary>
    /// Converts a <see cref="ValueValue{T}"/> instance to an <see cref="IsValue{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value being wrapped.</typeparam>
    /// <param name="self">The <see cref="ValueValue{T}"/> instance to convert.</param>
    /// <returns>An <see cref="IsValue{T}"/> instance containing the value from the input <see cref="ValueValue{T}"/>.</returns>
    public static IsValue<T> Is<T>(this ValueValue<T> self) => new(self.Value);
}