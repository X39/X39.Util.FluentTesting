using System.Diagnostics.CodeAnalysis;
using X39.Util.FluentTesting.Value.Extensions;

namespace X39.Util.FluentTesting.Value.Asserts;

/// <summary>
/// Represents a value assertion that validates whether a given value equals an expected value.
/// </summary>
/// <typeparam name="T">The type of the value being asserted.</typeparam>
/// <remarks>
/// This struct is used to perform equality checks between two values during testing. It ensures
/// that the actual value matches the provided expected value using the assertion framework.
/// </remarks>
/// <seealso cref="IsValueExtensions"/>
public readonly record struct EqualValueAssert<T>(T Value)
{
    /// <summary>
    /// Asserts whether the current value equals the specified expected value.
    /// </summary>
    /// <param name="expected">The expected value to compare against the current value.</param>
    /// <returns>The original value, allowing for method chaining.</returns>
    public T To([SuppressMessage("ReSharper", "ParameterOnlyUsedForPreconditionCheck.Global")] T expected)
    {
        Xunit.Assert.Equal(expected, Value);
        return Value;
    }
}