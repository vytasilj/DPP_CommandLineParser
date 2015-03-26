using CommandLineParser.Options;

namespace CommandLineParser
{
    public class GenericSynonym<T> : ISynonym<T>
    {
        private readonly IOption<T> _mainOption;
        private readonly string _name;


        public GenericSynonym(IOption<T> main, string name)
        {
            _mainOption = main;
            _name = name;
        }


        IOption ISynonym.MainOption
        {
            get { return MainOption; }
        }

        public IOption<T> MainOption
        {
            get { return _mainOption; }
        }
    }

    public class Synonym : ISynonym
    {
        private readonly IOption _mainOption;
        private readonly string _name;


        public Synonym(IOption main, string name)
        {
            _mainOption = main;
            _name = name;
        }


        IOption ISynonym.MainOption
        {
            get { return _mainOption; }
        }
    }
}