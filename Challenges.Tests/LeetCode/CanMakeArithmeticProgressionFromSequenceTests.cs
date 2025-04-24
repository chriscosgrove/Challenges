using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class CanMakeArithmeticProgressionFromSequenceTests
    {
        [Theory]
        [InlineData(new[] { 3, 5, 1 }, true)]
        [InlineData(new[] { 0, 0, 1,4 }, false)]
        [InlineData(new[] { 2, 4, 6, 10 }, true)]
        [InlineData(new[] { 1, 3, 4, 5 }, true)]
        [InlineData(new[] { 13, 12, -12, 9, 9, 16, 7, -10, -20, 0, 18, -1, -20, -10, -8, 15, 15, 16, 2, 15 }, false)]
        public void CanMakeArithmeticProgressionTest(int[] input, bool expected)
        {
            var result = CanMakeArithmeticProgressionFromSequence.CanMakeArithmeticProgression(input);
            Assert.Equal(expected, result);
        }
    }
}
