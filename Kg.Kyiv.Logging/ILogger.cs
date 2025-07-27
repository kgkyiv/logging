using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Kg.Kyiv.Logging;

public interface ILogger
{
    void Write(LogLevel level, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Write(LogLevel level, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Verbose(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Verbose([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Debug(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Debug([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Information(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Information([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Warning(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Warning([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Error(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Error([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Error(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Error(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Fatal(ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Fatal([StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Fatal(Exception exception, ReadOnlySpan<char> message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
    void Fatal(Exception exception, [StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format, ReadOnlySpan<object?> args, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0);
}