using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("pwwkew", 3)]
        [TestCase("fkdjf", 4)]
        public void Test1(string input, int lengthOfLongestSubstring)
        {
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.AreEqual(lengthOfLongestSubstring, result);
        }
    }
}
