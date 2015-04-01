using CommandLineParser.Options;

namespace CommandLineParser.Synonyms
{
    public interface ISynonym
    {
        /// <summary>
        /// Volba, ke ktere je toto synonymum prirazeno
        /// </summary>
        IOption MainOption { get; }

        /// <summary>
        /// Nazev synonyma, ktery bude pouzit v prikazove radce
        /// </summary>
        string Name { get; }
    }

    public interface ISynonym<T> : ISynonym
    {
        /// <summary>
        /// Volba, ke ktere je toto synonymum prirazeno
        /// </summary>
        new IOption<T> MainOption { get; }
    }
}