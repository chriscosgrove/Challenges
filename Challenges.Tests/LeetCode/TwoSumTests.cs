using CodeWars.LeetCode;
using NUnit.Framework;
using System.Linq;

namespace CodeWars.Tests.LeetCode
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        [TestCase(new[] { 3, 3}, 6,new[] { 0,1 } )]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 } )]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0,1 } )]
        [TestCase(new[] { 2, 5, 5, 11 }, 10, new[] { 1,2 } )]
        public void Test1(int[] nums, int target, int[] expected)
        {
            var result = TwoSum.Resolve(nums, target).OrderBy( s => s);
            Assert.IsTrue(result.SequenceEqual(expected));
        }
    }
}
