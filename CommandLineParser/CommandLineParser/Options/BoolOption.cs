﻿using System.Collections.Generic;
using System.Linq;

namespace CommandLineParser.Options
{
    public class BoolOption : AbstractOption<bool>
    {
        public BoolOption(string id) : base(id)
        {
        }
    }
}