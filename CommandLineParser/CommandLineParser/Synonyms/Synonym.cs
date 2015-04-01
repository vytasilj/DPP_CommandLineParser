using CommandLineParser.Options;

namespace CommandLineParser.Synonyms
{
    public class Synonym<T> : ISynonym<T>
    {
        private readonly IOption<T> _mainOption;
        private readonly string _name;


        public Synonym(IOption<T> main, string name)
        {
            _mainOption = main;
            _name = name;
        }


        IOption ISynonym.MainOption
        {
            get { return MainOption; }
        }

        public string Name
        {
            get { return _name; }
        }

        public IOption<T> MainOption
        {
            get { return _mainOption; }
        }
    }
}