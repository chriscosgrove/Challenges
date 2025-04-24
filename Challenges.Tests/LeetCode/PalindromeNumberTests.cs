using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    class PalindromeNumberTests
    {
        [Test]
        [TestCase(121, true)]
        [TestCase(1234, false)]
        [TestCase(1222222221, true)]
        public void Test1(int input, bool expected)
        {
            var result = PalindromeNumber.IsPalindrome(input);
            Assert.AreEqual(result,expected);
        }
    }
}
