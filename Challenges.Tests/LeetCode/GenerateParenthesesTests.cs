using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class GenerateParenthesesTests
    {
        [Theory]
        [InlineData(3)]
        public void GenerateParenthesesTest(int combinations)
        {
            var sut = new GenerateParentheses();
            sut.GenerateParenthesis(combinations);
        }
    }
}
