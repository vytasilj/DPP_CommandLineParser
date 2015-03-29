using System.Collections.Generic;

namespace CommandLineParser.Options
{
    public interface IOption
    {
        string Id { get; }

        IEnumerable<ISynonym> Synonyms { get; }

        IOption IsRequired();

        IOption SetSynonyms(params string[] synonyms);

        bool TrySetValue(object value);
    }


    public interface IOption<T> : IOption
    {
        new IEnumerable<ISynonym<T>> Synonyms { get; }

        new IOption<T> IsRequired();

        new IOption<T> SetSynonyms(params string[] synonyms);

        new bool TrySetValue(T value);
    }
}