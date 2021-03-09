using CodingChallenge.ReversingString;
using NUnit.Framework;

namespace CodingChallengUnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            var value = "BarBazQux";
            var expectedValue = "xuQzaBraB";
            var result = StringUtilities.Reverse(value);
            Assert.AreEqual(expectedValue, result);
        }
    }
}