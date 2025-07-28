namespace Kg.Kyiv.Logging.Formatting;

public interface ILogProcessor
{
    void Write(ILogBuilder builder, LogLevel level, ReadOnlySpan<char> message, string memberName, string filePath, int lineNumber);
    void Write(ILogBuilder builder, LogLevel level, string format, ReadOnlySpan<object?> args, string memberName, string filePath, int lineNumber);
    void Write(ILogBuilder builder, LogLevel level, Exception exception, ReadOnlySpan<char> message, string memberName, string filePath, int lineNumber);
    void Write(ILogBuilder builder, LogLevel level, Exception exception, string format, ReadOnlySpan<object?> args, string memberName, string filePath, int lineNumber);
}