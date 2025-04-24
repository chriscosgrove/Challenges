using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData(new [] {"flower", "flow", "flight"}, "fl")]
        [InlineData(new [] {"Horn", "Beep", "Toot"}, "")]
        [InlineData(new [] {"Barry", "Bar", "Barf"}, "Bar")]
        [InlineData(new [] {"a"}, "a")]
        [InlineData(new[] { "" }, "")]
        [InlineData(new[] { "cir", "car" }, "c")]
        public void LongestCommonPrefixTest(string[] input, string expected)
        {
            var result = LongestCommonPrefix.Solution(input);
            Assert.Equal(expected, result);
        }
    }
}
