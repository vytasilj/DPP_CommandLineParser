using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public class BoolOption : IOption<bool>
    {
        private bool _required;
        private IEnumerable<ISynonym<bool>> _synonyms;
        private readonly string _id;

        public BoolOption(string id)
        {
            _id = id;
        }


        public string Id
        {
            get { return _id; }
        }


        //public bool IsRequired
        //{
        //    get { return m_required; }
        //}

        //IEnumerable<ISynonym> IOption.Synonyms
        //{
        //    get { return Synonyms; }
        //}

        public IOption<bool> SetSynonyms(params string[] synonyms)
        {
            _synonyms = synonyms.Select(s => new GenericSynonym<bool>(this, s));
            return this;
        }

        public IOption<bool> IsRequired()
        {
            _required = true;
            return this;
        }

        IOption IOption.SetSynonyms(params string[] synonyms)
        {
            return SetSynonyms(synonyms);
        }
        
        IOption IOption.IsRequired()
        {
            return IsRequired();
        }

        //public IEnumerable<ISynonym<bool>> Synonyms
        //{
        //    get { return m_synonyms; }
        //}


        //public void SetValue(bool value)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void SetValue(object value)
        //{
        //    if (value is bool)
        //        SetValue((bool) value);

        //    throw new InvalidCastException();
        //}

        //public bool IsValid()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}