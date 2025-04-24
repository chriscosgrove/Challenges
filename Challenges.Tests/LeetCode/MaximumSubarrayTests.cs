using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class MaximumSubarrayTests
    {

        [Theory]
        [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] input, int expected)
        {
            var result = MaximumSubarray.MaxSubArray(input);
            Assert.Equal(expected, result);
        }
    }
}
