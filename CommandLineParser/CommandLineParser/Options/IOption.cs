namespace CommandLineParser.Options
{
    public interface IOption
    {
        string Id { get; }
        //bool IsValid(object o);
        //bool IsRequired { get; }

        //IEnumerable<ISynonym> Synonyms { get; }


        //void SetValue(object value);

        //bool IsValid();

        string ToString();


        IOption IsRequired();

        IOption SetSynonyms(params string[] synonyms);
    }


    public interface IOption<T> : IOption
    {
        //new IEnumerable<ISynonym<T>> Synonyms { get; }

        new IOption<T> IsRequired();

        new IOption<T> SetSynonyms(params string[] synonyms);


        //void SetValue(T value);
    }

    public interface ISynonym
    {
        IOption MainOption { get; }
    }


    public interface ISynonym<T> : ISynonym
    {
        new IOption<T> MainOption { get; } 
    }
}