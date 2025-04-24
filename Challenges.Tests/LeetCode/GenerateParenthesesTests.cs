using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class GenerateParenthesesTests
    {
        [Test]
        [TestCase(3)]
        public void Test1(int combinations)
        {
            var sut = new GenerateParentheses();
            sut.GenerateParenthesis(combinations);
        }
    }
}
