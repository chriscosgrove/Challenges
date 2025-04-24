using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new[] { 3, 3}, 6,new[] { 0,1 } )]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 } )]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0,1 } )]
        [InlineData(new[] { 2, 5, 5, 11 }, 10, new[] { 1,2 } )]
        public void Test1(int[] nums, int target, int[] expected)
        {
            var result = TwoSum.Resolve(nums, target).OrderBy( s => s);
            Assert.True(result.SequenceEqual(expected));
        }
    }
}
