using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public abstract class AbstractOption<T> : IOption<T>
    {
        private readonly string _id;
        private IEnumerable<Synonym<T>> _synonyms;
        private bool _required;
        private T _value;

        protected AbstractOption(string id)
        {
            _id = id;
        }


        public string Id
        {
            get { return _id; }
        }

        public IEnumerable<ISynonym<T>> Synonyms
        {
            get { return _synonyms; }
        }

        public IOption<T> SetSynonyms(params string[] synonyms)
        {
            _synonyms = synonyms.Select(s => new Synonym<T>(this, s));
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

        IEnumerable<ISynonym> IOption.Synonyms
        {
            get { return Synonyms; }
        }

        public bool TrySetValue(object value)
        {
            if (value is T)
                return TrySetValue((T) value);
            return false;
        }

        public bool TrySetValue(T value)
        {
            if (CheckValue(value))
            {
                _value = value;
                return true;
            }
            return false;
        }


        protected abstract bool CheckValue(T value);
    }
}