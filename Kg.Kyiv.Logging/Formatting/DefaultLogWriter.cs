using System.Runtime.CompilerServices;

namespace Kg.Kyiv.Logging.Formatting;

// formats log message to
// [<level>] [@<fileName>:<lineNumber>] [<HH:MM:ss>] <message>
public readonly struct DefaultLogProcessor : ILogProcessor
{
    private static readonly string[] LogLevelTable =
    [
        "[VRB]",
        "[DBG]",
        "[INF]",
        "[WRN]",
        "[ERR]",
        "[FTL]"
    ];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void PushLevelColor(ILogBuilder builder, LogLevel level)
    {
        builder.PushColor(level switch
        {
            LogLevel.Verbose => ConsoleColor.DarkGray,
            LogLevel.Debug => ConsoleColor.Magenta,
            LogLevel.Information => ConsoleColor.White,
            LogLevel.Warning => ConsoleColor.Yellow,
            LogLevel.Error => ConsoleColor.Red,
            LogLevel.Fatal => ConsoleColor.DarkRed,
        });
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void WriteHeader(ILogBuilder builder, LogLevel level, string filePath, int lineNumber)
    {
        builder.Append(LogLevelTable[(int)level]);
        builder.Append($" [@{Path.GetFileName(filePath)}:{lineNumber}]");
        builder.Append($" [{DateTime.Now:HH:mm:ss}] ");
    }
    
    public void Write(ILogBuilder builder, LogLevel level, ReadOnlySpan<char> message, string memberName, string filePath,
        int lineNumber)
    {
        builder.Begin();
        PushLevelColor(builder, level);
        WriteHeader(builder, level, filePath, lineNumber);
        builder.Append(message);
        builder.PopColor();
        builder.End();
    }

    public void Write(ILogBuilder builder, LogLevel level, string format, ReadOnlySpan<object?> args, string memberName,
        string filePath, int lineNumber)
    {
        // TODO maybe colorize formatted value like in serilog?
        Write(builder, level, string.Format(format, args), memberName, filePath, lineNumber);
    }

    public void Write(ILogBuilder builder, LogLevel level, Exception exception, ReadOnlySpan<char> message, string memberName,
        string filePath, int lineNumber)
    {
        Write(builder, level, message, memberName, filePath, lineNumber);
        
        builder.Begin();
        PushLevelColor(builder, level);
        builder.Append(exception.ToString());
        builder.PopColor();
        builder.End();
    }

    public void Write(ILogBuilder builder, LogLevel level, Exception exception, string format, ReadOnlySpan<object?> args,
        string memberName, string filePath, int lineNumber)
    {
        Write(builder, level, format, args, memberName, filePath, lineNumber);
        
        builder.Begin();
        PushLevelColor(builder, level);
        builder.Append(exception.ToString());
        builder.PopColor();
        builder.End();
    }
}