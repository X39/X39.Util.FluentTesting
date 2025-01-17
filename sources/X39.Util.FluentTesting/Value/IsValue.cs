namespace X39.Util.FluentTesting.Value;

/// <summary>
/// Represents a wrapper for a value of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of the value being wrapped.</typeparam>
public readonly record struct IsValue<T>(T Value);