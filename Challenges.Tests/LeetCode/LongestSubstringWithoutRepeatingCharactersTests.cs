using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("pwwkew", 3)]
        [InlineData("fkdjf", 4)]
        public void LengthOfLongestSubstringTest(string input, int lengthOfLongestSubstring)
        {
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(input);
            Assert.Equal(lengthOfLongestSubstring, result);
        }
    }
}
