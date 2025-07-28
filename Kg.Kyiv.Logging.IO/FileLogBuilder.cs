using Kg.Kyiv.Logging.Formatting;

namespace Kg.Kyiv.Logging.IO;

public class FileLogBuilder(FileStream stream, bool leaveOpen = false) : StreamLogBuilder(stream, leaveOpen)
{
    public FileLogBuilder(string path, bool append = true)
        : this(File.Open(path, append ? FileMode.Append : FileMode.OpenOrCreate, FileAccess.Write))
    {
    }
}