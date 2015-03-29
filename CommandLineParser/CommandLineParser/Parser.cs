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

        public void AddKnownPreference(params IOption[] preferences)
        {
            foreach (var synonym in preferences.SelectMany(option => option.Synonyms))
            {
                _synonyms.Add(synonym.Name, synonym.MainOption);
            }
        }

        public void Parse()
        {
        }
    }
}