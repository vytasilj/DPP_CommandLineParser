using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public class RangeOption<T> : IOption<T>
    {
        private readonly string _id;
        private IEnumerable<GenericSynonym<T>> _synonyms;
        private bool _required;

        private T _minValue;
        private T _maxValue;
        private bool _hasMin;
        private bool _hasMax;


        public RangeOption(string id)
        {
            _id = id;

            _hasMin = false;
            _hasMax = false;
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

        public RangeOption<T> SetMinValue(T minValue)
        {
            _minValue = minValue;
            _hasMin = true;
            return this;
        }
        
        public RangeOption<T> SetMaxValue(T maxValue)
        {
            _maxValue = maxValue;
            _hasMax = true;
            return this;
        }
    }
}