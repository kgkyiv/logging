using System.Text;
using Kg.Kyiv.Logging.Formatting;

namespace Kg.Kyiv.Logging.Console;

public sealed class ConsoleLogBuilder : ILogBuilder
{
    private readonly StringBuilder _sb = new();
    private readonly Stack<ConsoleColor> _colorStack = [];
    private ConsoleColor _startColor;

    public void Begin()
    {
        _startColor = System.Console.ForegroundColor;

        _sb.Clear();

        if (_colorStack.Count > 0)
        {
            // TODO maybe throw exception instead?
            _colorStack.Clear();
        }
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
        if (_sb.Length > 0)
        {
            System.Console.Write(_sb.ToString());
            _sb.Clear();
        }

        ConsoleColor oldColor = System.Console.ForegroundColor;
        System.Console.ForegroundColor = color;
        System.Console.Out.Write(value);
        System.Console.ForegroundColor = oldColor;
    }

    public void PushColor(ConsoleColor color)
    {
        ConsoleColor oldColor = _colorStack.Count > 0 ? _colorStack.Peek() : _startColor;
        if (oldColor != color && _sb.Length > 0)
        {
            System.Console.ForegroundColor = oldColor;
            System.Console.Write(_sb.ToString());
            _sb.Clear();
        }

        System.Console.ForegroundColor = color;
        _colorStack.Push(color);
    }

    public void PopColor()
    {
        if (_colorStack.Count <= 0) return;
        ConsoleColor oldColor = _colorStack.Pop();
        ConsoleColor color = _colorStack.Count > 0 ? _colorStack.Peek() : _startColor;

        if (oldColor != color && _sb.Length > 0)
        {
            System.Console.ForegroundColor = oldColor;
            System.Console.Write(_sb.ToString());
            _sb.Clear();
        }

        System.Console.ForegroundColor = color;
    }

    public void End()
    {
        if (_sb.Length > 0)
        {
            System.Console.WriteLine(_sb.ToString());
        }
        else System.Console.WriteLine();
    }
}