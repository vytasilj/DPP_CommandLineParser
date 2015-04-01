using CommandLineParser.Options;

namespace CommandLineParser.Synonyms
{
    /// <summary>
    /// Non-generic interface of synonym (choice)
    /// </summary>
    public interface ISynonym
    {
        /// <summary>
        /// Option, that own this synonym.
        /// </summary>
        IOption MainOption { get; }

        /// <summary>
        /// Name of synonym.
        /// Used in cmd.
        /// </summary>
        string Name { get; }
    }

    public interface ISynonym<T> : ISynonym
    {
        /// <summary>
        /// Option, that own this synonym.
        /// </summary>
        new IOption<T> MainOption { get; }
    }
}