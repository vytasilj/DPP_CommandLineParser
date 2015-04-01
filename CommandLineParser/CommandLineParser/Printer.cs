using System;
using System.Collections.Generic;
using System.IO;
using CommandLineParser.Options;

namespace CommandLineParser
{
    public class Printer : IDisposable
    {
        private readonly TextWriter _writer;

        public Printer(TextWriter writer)
        {
            _writer = writer;
        }


        public void WriteOptions(IEnumerable<IOption> options)
        {
            
        }


        public void Dispose()
        {
            if (_writer != null)
            {
                _writer.Close();
                _writer.Dispose();
            }
        }
    }
}