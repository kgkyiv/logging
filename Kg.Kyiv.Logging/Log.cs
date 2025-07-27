using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Kg.Kyiv.Logging;

public static class Log
{
    private static ILogger _logger = new SilentLogger();
    public static ILogger Logger
    {
        get => _logger;
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            _logger = value;
        }
    }
    
    public static void Write(LogLevel level, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Write(level, message, memberName, filePath, lineNumber);
    }

    public static void Write(LogLevel level, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Write(level, format, args, memberName, filePath, lineNumber);
    }

    public static void Verbose(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Verbose(message, memberName, filePath, lineNumber);
    }

    public static void Verbose([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Verbose(format, args, memberName, filePath, lineNumber);
    }

    public static void Debug(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Debug(message, memberName, filePath, lineNumber);
    }

    public static void Debug([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Debug(format, args, memberName, filePath, lineNumber);
    }

    public static void Information(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Information(message, memberName, filePath, lineNumber);
    }

    public static void Information([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Information(format, args, memberName, filePath, lineNumber);
    }

    public static void Warning(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Warning(message, memberName, filePath, lineNumber);
    }

    public static void Warning([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Warning(format, args, memberName, filePath, lineNumber);
    }

    public static void Error(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Error(message, memberName, filePath, lineNumber);
    }

    public static void Error([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Error(format, args, memberName, filePath, lineNumber);
    }

    public static void Error(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Error(exception, message, memberName, filePath, lineNumber);
    }

    public static void Error(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Error(exception, format, args, memberName, filePath, lineNumber);
    }

    public static void Fatal(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Fatal(message, memberName, filePath, lineNumber);
    }

    public static void Fatal([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Fatal(format, args, memberName, filePath, lineNumber);
    }

    public static void Fatal(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Fatal(exception, message, memberName, filePath, lineNumber);
    }

    public static void Fatal(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        _logger.Fatal(exception, format, args, memberName, filePath, lineNumber);
    }
}