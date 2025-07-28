using System.Text;
using Kg.Kyiv.Logging.Formatting;

namespace Kg.Kyiv.Logging.IO;

public class StreamLogBuilder(StreamWriter writer) : ILogBuilder, IDisposable, IAsyncDisposable
{
    private readonly StringBuilder _sb = new();

    public StreamLogBuilder(Stream stream, bool leaveOpen = false)
        : this(new StreamWriter(stream, leaveOpen: leaveOpen))
    {
    }

    public void Begin()
    {
        _sb.Clear();
    }

    public void Append(ReadOnlySpan<char> value)
    {
        _sb.Append(value);
    }

    public void Append(char value)
    {
        _sb.Append(value);
    }

    public void AppendColored(ReadOnlySpan<char> value, ConsoleColor color)
    {
        // colors aren't supported in streams
        _sb.Append(value);
    }

    public void PushColor(ConsoleColor color)
    {
        // colors aren't supported in streams
    }

    public void PopColor()
    {
        // colors aren't supported in streams
    }

    public void End()
    {
        writer.WriteLine(_sb.ToString());
        writer.Flush();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            writer.Dispose();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual async ValueTask DisposeAsyncCore()
    {
        await writer.DisposeAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeAsyncCore();
        GC.SuppressFinalize(this);
    }
}