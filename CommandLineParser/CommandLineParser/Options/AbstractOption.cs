using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public abstract class AbstractOption<T> : IOption<T>
    {
        private readonly string _id;
        private IEnumerable<GenericSynonym<T>> _synonyms;
        private bool _required;

        protected AbstractOption(string id)
        {
            _id = id;
        }


        public string Id
        {
            get { return _id; }
        }

        public IOption<T> SetSynonyms(params string[] synonyms)
        {
            _synonyms = synonyms.Select(s => new GenericSynonym<T>(this, s));
            return this;
        }

        public IOption<T> IsRequired()
        {
            _required = true;
            return this;
        }

        IOption IOption.IsRequired()
        {
            return IsRequired();
        }

        IOption IOption.SetSynonyms(params string[] synonyms)
        {
            return SetSynonyms(synonyms);
        }
    }
}