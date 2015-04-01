using System.Collections.Generic;
using CommandLineParser.Synonyms;

namespace CommandLineParser.Options
{
    /// <summary>
    /// Negenericky interface, aby se dalo pristupovat ke vsem
    /// </summary>
    public interface IOption
    {
        /// <summary>
        /// Jednoznacne identifikator, ktery se pouzije i ve vystupu
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Synonyma (kratke a dlouhe volby), ktera mohou byt pouzita v cmd
        /// </summary>
        IEnumerable<ISynonym> Synonyms { get; }

        /// <summary>
        /// Nastavi tuto volbu jako povinnou.
        /// Default je nepovinny.
        /// </summary>
        /// <returns></returns>
        IOption IsRequired();

        /// <summary>
        /// Nastavi synonyma
        /// </summary>
        /// <param name="synonyms"></param>
        /// <returns></returns>
        IOption SetSynonyms(params string[] synonyms);

        /// <summary>
        /// Priradi hodnotu.
        /// </summary>
        /// <param name="value">hodnota</param>
        /// <returns>Vraci true, pokud uspeje, jinak false</returns>
        bool TrySetValue(object value);

        /// <summary>
        /// Zkontkroluje, zda je volba korektni.
        /// Povinna volba musi mit hodnotu.
        /// </summary>
        /// <returns></returns>
        bool CheckOption();
    }


    public interface IOption<T> : IOption
    {
        /// <summary>
        /// Synonyma (kratke a dlouhe volby), ktera mohou byt pouzita v cmd
        /// </summary>
        new IEnumerable<ISynonym<T>> Synonyms { get; }

        /// <summary>
        /// Nastavi tuto volbu jako povinnou.
        /// Default je nepovinny.
        /// </summary>
        /// <returns></returns>
        new IOption<T> IsRequired();

        /// <summary>
        /// Nastavi synonyma
        /// </summary>
        /// <param name="synonyms"></param>
        /// <returns></returns>
        new IOption<T> SetSynonyms(params string[] synonyms);

        /// <summary>
        /// Priradi hodnotu.
        /// </summary>
        /// <param name="value">hodnota</param>
        /// <returns>Vraci true, pokud uspeje, jinak false</returns>
        new bool TrySetValue(T value);
    }
}