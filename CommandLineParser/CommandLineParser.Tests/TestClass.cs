using System;
using System.Linq;
using CommandLineParser.Options;
using Moq;
using NUnit.Framework;

namespace CommandLineParser.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void DefaultUsingTest()
        {
            var factory = new MockFactory(MockBehavior.Loose);

            // Bool option
            var mockBoolOption = factory.Create<BoolOption>("verbose");
            var boolOption = mockBoolOption.Object.IsRequired().SetSynonyms("-v", "--verbose");

            // Int option
            const int minValue = 10;
            const int maxValue = 100;
            var mockIntOption = factory.Create<RangeOption<int>>("size");
            var intOption = mockIntOption.Object.SetMinValue(minValue).SetMaxValue(maxValue).SetSynonyms("-s", "--size");

            // Enum Option
            var mockEnumOption = factory.Create<EnumOption>("enumerate");
            var enumOption = mockEnumOption.Object.SetValues("first", "second", "third").IsRequired().SetSynonyms("-e", "--enumerate");
            Assert.That(enumOption.Synonyms.Count(), Is.EqualTo(2));

            // Parser
            string[] cmdArguments = "--verbose -s=20 -e aaa".Split(' ');
            var parser = factory.Create<IParser>(cmdArguments).Object;
            parser.AddKnownPreference(boolOption, intOption, enumOption);
            parser.Parse();

            // Printer
            using (var printer = new Printer(Console.Out))
            {
                printer.WriteOptions(parser.Options);
            }
        }
    }
}