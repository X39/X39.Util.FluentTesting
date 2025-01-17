namespace X39.Util.FluentTesting.Value;

/// <summary>
/// Represents a generic wrapper for a single value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the value being wrapped.</typeparam>
/// <remarks>
/// This record struct is used to encapsulate a value into a unified structure which can then
/// be consumed by extensions or other utility functions within testing frameworks.
/// </remarks>
public readonly record struct ValueValue<T>(T Value)
{
}