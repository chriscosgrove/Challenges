using CodeWars.Katas;
using NUnit.Framework;

namespace CodeWars.Tests.Katas
{
    [TestFixture]
    internal class FindTheOddIntTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5}));
        }
    }
}