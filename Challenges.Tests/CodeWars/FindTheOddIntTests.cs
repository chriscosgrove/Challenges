using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class FindTheOddIntTests
    {
        [Fact]
        public void Tests()
        {
            Assert.Equal(5, FindTheOddInt.find_it(new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5}));
        }
    }
}