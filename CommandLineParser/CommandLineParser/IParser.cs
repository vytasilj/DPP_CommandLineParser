using System.Collections.Generic;
using CommandLineParser.Options;

namespace CommandLineParser
{
    public interface IParser
    {
        IEnumerable<IOption> Options { get; }

        /// <summary>
        /// Pridam povolene volby
        /// </summary>
        /// <param name="preferences"></param>
        void AddKnownPreference(params IOption[] preferences);

        /// <summary>
        /// Rozparsuji argumenty.
        /// </summary>
        void Parse();
    }
}