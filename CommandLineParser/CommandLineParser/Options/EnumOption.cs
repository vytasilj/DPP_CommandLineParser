using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public class EnumOption : IOption
    {
        private readonly string _id;
        private bool _required;
        private IEnumerable<Synonym> _synonyms;
        private IEnumerable<string> _values;


        public EnumOption(string id)
        {
            _id = id;
        }


        public string Id
        {
            get { return _id; }
        }

        public IOption IsRequired()
        {
            _required = true;
            return this;
        }

        public IOption SetSynonyms(params string[] synonyms)
        {
            _synonyms = synonyms.Select(s => new Synonym(this, s));
            return this;
        }

        public EnumOption SetValues(params string[] values)
        {
            _values = values;
            return this;
        }
    }
}