namespace Kg.Kyiv.Logging.Formatting;

public interface ILogBuilder
{
    void Begin();
    void Append(ReadOnlySpan<char> value);
    void Append(char value);
    void AppendColored(ReadOnlySpan<char> value, ConsoleColor color);
    void PushColor(ConsoleColor color);
    void PopColor();
    void End();
}