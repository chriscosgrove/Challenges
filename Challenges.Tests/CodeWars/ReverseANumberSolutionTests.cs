using CodeWars.Katas;
using NUnit.Framework;

namespace CodeWars.Tests.Katas
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void ReverseTests()
        {
            Assert.AreEqual(321, Kata.ReverseNumber(123));
            Assert.AreEqual(-321, Kata.ReverseNumber(-123));
            Assert.AreEqual(0, Kata.ReverseNumber(0));
        }
    }
}
