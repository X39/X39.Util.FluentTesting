namespace X39.Util.FluentTesting;

/// <summary>
/// Provides a static entry point for creating assertions in the testing framework.
/// This class is primarily used to initiate chains of fluent assertion methods.
/// </summary>
public static class Expect
{
    /// <summary>
    /// Represents a static property that serves as the entry point for initiating assertions.
    /// Used to construct fluent assertion chains for verifying test conditions.
    /// </summary>
    public static ThatValue That => new();
}