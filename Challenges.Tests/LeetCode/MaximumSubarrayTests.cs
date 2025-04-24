using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class MaximumSubarrayTests
    {

        [Test]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void Test1(int[] input, int expected)
        {
            var result = MaximumSubarray.MaxSubArray(input);
            Assert.AreEqual(expected, result);
        }
    }
}
