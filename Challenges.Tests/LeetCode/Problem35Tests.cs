using LeetCode.Problem_35;

namespace Challenges.Tests.LeetCode
{
    public class Problem35Tests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, 8)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5, 4)]
        public void SearchInsertPosition(int [] numbers, int target ,int expectedResult) 
        { 
            var result = Problem35.SearchInsertPosition(numbers, target);
            Assert.Equal(expectedResult, result);
        }
    }
}
