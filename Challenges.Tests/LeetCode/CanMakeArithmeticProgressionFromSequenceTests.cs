using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class CanMakeArithmeticProgressionFromSequenceTests
    {
        [Test]
        [TestCase(new[] { 3, 5, 1 }, true)]
        [TestCase(new[] { 0, 0, 1,4 }, false)]
        [TestCase(new[] { 2, 4, 6, 10 }, true)]
        [TestCase(new[] { 1, 3, 4, 5 }, true)]
        [TestCase(new[] { 13, 12, -12, 9, 9, 16, 7, -10, -20, 0, 18, -1, -20, -10, -8, 15, 15, 16, 2, 15 }, false)]
        public void Test1(int[] input, bool expected)
        {
            var result = CanMakeArithmeticProgressionFromSequence.CanMakeArithmeticProgression(input);
            Assert.AreEqual(expected, result);
        }
    }
}
