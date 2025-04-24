using CoderByte;

namespace Challenges.Tests.CoderByte
{
    public class LongestWordTests
    {
        [Theory]
        [InlineData("The Longest word", "Longest")]
        [InlineData("The Long word fiver", "fiver")]
        [InlineData("The Long word 00000", "00000")]
        [InlineData("The Long word! 00000", "00000")]
        [InlineData("The Long word 0000", "Long")]
        [InlineData("The word Chat 0000", "word")]
        public void Test(string input, string expected)
        {
            var result = LongestWordSolution.LongestWord(input);
            Assert.Equal(expected, result);
        }
    }
}
