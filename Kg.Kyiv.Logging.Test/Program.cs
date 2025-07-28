// See https://aka.ms/new-console-template for more information

using Kg.Kyiv.Logging;
using Kg.Kyiv.Logging.Console;
using Kg.Kyiv.Logging.IO;

Log.Logger = new DefaultLogger([new ConsoleLogBuilder(), new FileLogBuilder("test.log")]);
Log.Verbose("test -1");
Log.Debug("test 0");
Log.Information("test 1");
Log.Warning("test 2");
Log.Error("test 3");
try
{
    throw new InvalidOperationException("toiled clogged");
}
catch (Exception e)
{
    Log.Error(e, "test 3.5");
}
Log.Fatal("test 4");
try
{
    throw new EndOfStreamException("toilet exploded");
}
catch (Exception e)
{
    Log.Fatal(e, "test 4.5");
}
