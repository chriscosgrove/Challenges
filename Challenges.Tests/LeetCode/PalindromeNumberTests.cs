using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class PalindromeNumberTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(1234, false)]
        [InlineData(1222222221, true)]
        public void IsPalindromeTest(int input, bool expected)
        {
            var result = PalindromeNumber.IsPalindrome(input);
            Assert.Equal(result,expected);
        }
    }
}
