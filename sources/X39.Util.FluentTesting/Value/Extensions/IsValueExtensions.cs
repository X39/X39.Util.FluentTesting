using X39.Util.FluentTesting.Value.Asserts;

namespace X39.Util.FluentTesting.Value.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="IsValue{T}"/> type, allowing for testing and assertion operations.
/// </summary>
/// <remarks>
/// The methods in this class are designed to simplify assertion logic by chaining operations directly on the instance
/// of the <see cref="IsValue{T}"/> type. This allows for more readable and concise testing code in value validation scenarios.
/// </remarks>
public static class IsValueExtensions
{
    /// <summary>
    /// Creates an instance of <see cref="EqualValueAssert{T}"/> to perform assertion operations on the value.
    /// </summary>
    /// <typeparam name="T">The type of the value to be asserted.</typeparam>
    /// <param name="self">The <see cref="IsValue{T}"/> instance on which the method is invoked.</param>
    /// <returns>
    /// An instance of <see cref="EqualValueAssert{T}"/> initialized with the value from the <paramref name="self"/> parameter,
    /// allowing further equality assertions.
    /// </returns>
    public static EqualValueAssert<T> Equal<T>(this IsValue<T> self) => new(self.Value);
}