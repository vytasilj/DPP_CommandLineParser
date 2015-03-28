namespace CommandLineParser.Options
{
    public interface IOption
    {
        string Id { get; }
        
        IOption IsRequired();

        IOption SetSynonyms(params string[] synonyms);
    }


    public interface IOption<T> : IOption
    {
        new IOption<T> IsRequired();

        new IOption<T> SetSynonyms(params string[] synonyms);
    }
}