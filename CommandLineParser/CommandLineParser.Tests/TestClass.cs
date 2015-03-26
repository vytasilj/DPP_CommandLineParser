using CommandLineParser.Options;
using Moq;
using NSubstitute;
using NSubstitute.Core;
using NUnit.Framework;

namespace CommandLineParser.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test01()
        {
            //var test = NSubstitute.Substitute.For<ITest>();
            //ConfiguredCall configuredCall = test.A(1).Returns("aaaa");

            //Mock<ITest> mock = new Mock<ITest>();
            //mock.Setup(test1 => test1.A(It.IsAny<int>())).Returns("aaa");

            var boolOption = new BoolOption("verbose").IsRequired().SetSynonyms("-v", "--verbose");

            var intRange = new RangeOption<int>("size").SetMinValue(10).SetMaxValue(100).IsRequired().SetSynonyms("-s", "--size");

            var enumOption = new EnumOption("enum").SetValues("aaa", "bbb", "ccc").IsRequired().SetSynonyms("-e", "--enumerate");
        }
    }
}