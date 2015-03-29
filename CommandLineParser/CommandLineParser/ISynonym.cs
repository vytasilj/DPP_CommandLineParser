using CommandLineParser.Options;

namespace CommandLineParser
{
    public interface ISynonym
    {
        IOption MainOption { get; }

        string Name { get; }
    }

    public interface ISynonym<T> : ISynonym
    {
        new IOption<T> MainOption { get; }
    }
}