using CodeWars.CoderByte;
using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.CoderByte
{
    class LongestWordTests
    {
        [Test]
        [TestCase("The Longest word", "Longest")]
        [TestCase("The Long word fiver", "fiver")]
        [TestCase("The Long word 00000", "00000")]
        [TestCase("The Long word! 00000", "00000")]
        [TestCase("The Long word 0000", "Long")]
        [TestCase("The word Chat 0000", "word")]
        public void Test(string input, string expected)
        {
            var result = LongestWordSolution.LongestWord(input);
            Assert.AreEqual(expected, result);
        }
    }
}
