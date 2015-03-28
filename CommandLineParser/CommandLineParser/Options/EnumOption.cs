using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public class EnumOption : AbstractOption<string>
    {
        private IEnumerable<string> _values;


        public EnumOption(string id) : base(id)
        {
        }


        public EnumOption SetValues(params string[] values)
        {
            _values = values;
            return this;
        }
    }
}