using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class SortTheOddTests
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(new int[] { 1, 3, 2, 8, 5, 4 }, SortTheOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.Equal(new int[] { 1, 3, 5, 8, 0 }, SortTheOdd.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.Equal(new int[] { }, SortTheOdd.SortArray(new int[] { }));
        }
    }
}
