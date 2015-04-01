using System.Collections.Generic;
using System.Linq;
using CommandLineParser.Options;

namespace CommandLineParser
{
    public class Parser : IParser
    {
        private readonly Dictionary<string, IOption> _synonyms;
        private string[] _arguments;


        public Parser(string[] commandLineArgs)
        {
            _synonyms = new Dictionary<string, IOption>();
            _arguments = commandLineArgs;
        }


        public IEnumerable<IOption> Options
        {
            get { return _synonyms.Values.Distinct(); }
        }


        public void AddKnownPreference(params IOption[] options)
        {
            foreach (var synonym in options.SelectMany(option => option.Synonyms))
            {
                _synonyms.Add(synonym.Name, synonym.MainOption);
            }
        }

        public void Parse()
        {
        }
    }
}