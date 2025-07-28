using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Kg.Kyiv.Logging.Formatting;

namespace Kg.Kyiv.Logging;

public sealed class DefaultLogger(IEnumerable<ILogBuilder> builders, ILogProcessor processor) : ILogger
{
    public DefaultLogger(ILogBuilder builder, ILogProcessor processor)
        : this([builder], processor)
    {
    }

    public DefaultLogger(IEnumerable<ILogBuilder> builders)
        : this(builders, new DefaultLogProcessor())
    {
    }

    public DefaultLogger(ILogBuilder builder)
        : this([builder], new DefaultLogProcessor())
    {
    }

    public void Write(LogLevel level, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, level, message, memberName, filePath, lineNumber);
        }
    }

    public void Write(LogLevel level, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, level, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Verbose(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Verbose, message, memberName, filePath, lineNumber);
        }
    }

    public void Verbose([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Verbose, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Debug(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Debug, message, memberName, filePath, lineNumber);
        }
    }

    public void Debug([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Debug, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Information(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Information, message, memberName, filePath, lineNumber);
        }
    }

    public void Information([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Information, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Warning(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Warning, message, memberName, filePath, lineNumber);
        }
    }

    public void Warning([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Warning, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Error(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Error, message, memberName, filePath, lineNumber);
        }
    }

    public void Error([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Error, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Error(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Error, exception, message, memberName, filePath, lineNumber);
        }
    }

    public void Error(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Error, exception, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Fatal(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Fatal, message, memberName, filePath, lineNumber);
        }
    }

    public void Fatal([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args,
        [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Fatal, format, args, memberName, filePath, lineNumber);
        }
    }

    public void Fatal(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "",
        [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Fatal, exception, message, memberName, filePath, lineNumber);
        }
    }

    public void Fatal(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format,
        ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "",
        [CallerLineNumber] int lineNumber = 0)
    {
        foreach (ILogBuilder builder in builders)
        {
            processor.Write(builder, LogLevel.Fatal, exception, format, args, memberName, filePath, lineNumber);
        }
    }
}