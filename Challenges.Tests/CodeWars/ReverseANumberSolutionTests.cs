using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class KataTest
    {
        [Fact]
        public void ReverseTests()
        {
            Assert.Equal(321, Kata.ReverseNumber(123));
            Assert.Equal(-321, Kata.ReverseNumber(-123));
            Assert.Equal(0, Kata.ReverseNumber(0));
        }
    }
}
