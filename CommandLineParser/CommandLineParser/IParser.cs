using System.Collections.Generic;
using CommandLineParser.Options;
using CommandLineParser.Synonyms;

namespace CommandLineParser
{
    public interface IParser
    {
        /// <summary>
        /// List of parsed options.
        /// </summary>
        IEnumerable<IOption> Options { get; }

        /// <summary>
        /// Add definied options.
        /// Throw exception, if <see cref="ISynonym.Name"/> are not unique.
        /// </summary>
        /// <param name="options">options</param>
        void AddKnownPreference(params IOption[] options);

        /// <summary>
        /// Parse cmd arguments.
        /// Error => throw exception with list of wrong options.
        /// </summary>
        void Parse();
    }
}