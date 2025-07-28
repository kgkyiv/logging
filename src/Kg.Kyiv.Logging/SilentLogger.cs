namespace Kg.Kyiv.Logging;

public sealed class SilentLogger : ILogger
{
    public void Write(LogLevel level, ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Write(LogLevel level, string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "",
        int lineNumber = 0)
    {
    }

    public void Verbose(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Verbose(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Debug(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Debug(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Information(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Information(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Warning(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Warning(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Error(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Error(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Error(Exception exception, ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Error(Exception exception, string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "",
        int lineNumber = 0)
    {
    }

    public void Fatal(ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Fatal(string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Fatal(Exception exception, ReadOnlySpan<char> message, string memberName = "", string filePath = "", int lineNumber = 0)
    {
    }

    public void Fatal(Exception exception, string format, ReadOnlySpan<object?> args, string memberName = "", string filePath = "",
        int lineNumber = 0)
    {
    }
}