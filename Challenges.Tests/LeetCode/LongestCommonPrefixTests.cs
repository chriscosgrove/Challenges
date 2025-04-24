using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class LongestCommonPrefixTests
    {
        [Test]
        [TestCase(new [] {"flower", "flow", "flight"}, "fl")]
        [TestCase(new [] {"Horn", "Beep", "Toot"}, "")]
        [TestCase(new [] {"Barry", "Bar", "Barf"}, "Bar")]
        [TestCase(new [] {"a"}, "a")]
        [TestCase(new[] { "" }, "")]
        [TestCase(new[] { "cir", "car" }, "c")]
        public void Test1(string[] input, string expected)
        {
            var result = LongestCommonPrefix.Solution(input);
            Assert.AreEqual(expected, result);
        }
    }
}
