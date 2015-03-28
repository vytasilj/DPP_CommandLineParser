using CommandLineParser.Options;

namespace CommandLineParser
{
    public interface IParser
    {
        void AddKnownPreference(params IOption[] preferences);

        void Parse();
    }
}