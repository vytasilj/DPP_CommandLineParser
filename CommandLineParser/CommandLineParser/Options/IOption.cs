using System.Collections.Generic;
using CommandLineParser.Synonyms;

namespace CommandLineParser.Options
{
    /// <summary>
    /// Non-generic option interface
    /// </summary>
    public interface IOption
    {
        /// <summary>
        /// Identifier of option
        /// </summary>
        string Id { get; }

        /// <summary>
        /// All choices (synonyms), which can be used in cmd.
        /// </summary>
        IEnumerable<ISynonym> Synonyms { get; }

        /// <summary>
        /// Option will be required.
        /// Default is optional.
        /// </summary>
        /// <returns></returns>
        IOption IsRequired();

        /// <summary>
        /// Set synonyms.
        /// </summary>
        /// <param name="synonyms">Array of names</param>
        /// <returns></returns>
        IOption SetSynonyms(params string[] synonyms);

        /// <summary>
        /// Try set value from arguments.
        /// </summary>
        /// <param name="value">value to set</param>
        /// <returns>Succes => true, otherwise => false</returns>
        bool TrySetValue(object value);

        /// <summary>
        /// Check option.
        /// </summary>
        /// <returns>Option is in correct state.</returns>
        /// <example>
        /// Option is required, but value is not set => false;
        /// </example>
        bool CheckOption();
    }


    /// <summary>
    /// Generic interface for options
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOption<T> : IOption
    {
        /// <summary>
        /// All choices (synonyms), which can be used in cmd.
        /// </summary>
        new IEnumerable<ISynonym<T>> Synonyms { get; }

        /// <summary>
        /// Option will be required.
        /// Default is optional.
        /// </summary>
        /// <returns></returns>
        new IOption<T> IsRequired();

        /// <summary>
        /// Set synonyms.
        /// </summary>
        /// <param name="synonyms">Array of names</param>
        /// <returns></returns>
        new IOption<T> SetSynonyms(params string[] synonyms);

        /// <summary>
        /// Try set value from arguments.
        /// </summary>
        /// <param name="value">value to set</param>
        /// <returns>Succes => true, otherwise => false</returns>
        new bool TrySetValue(T value);
    }
}