using CommandLineParser.Options;
using NUnit.Framework;

namespace CommandLineParser.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test01()
        {
            var boolOption = new BoolOption("verbose").IsRequired().SetSynonyms("-v", "--verbose");

            var intRange = new RangeOption<int>("size").SetMinValue(10).SetMaxValue(100).IsRequired().SetSynonyms("-s", "--size");

            var enumOption = new EnumOption("enum").SetValues("aaa", "bbb", "ccc").IsRequired().SetSynonyms("-e", "--enumerate");

            var parser = new Parser("--verbose -s=20 -e aaa".Split(' '));
            parser.AddKnownPreference(boolOption, intRange, enumOption);
            parser.Parse();
        }
    }
}