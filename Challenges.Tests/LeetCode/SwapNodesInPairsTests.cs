using System.Collections.Generic;
using CodeWars.LeetCode;
using NUnit.Framework;

namespace CodeWars.Tests.LeetCode
{
    public class SwapNodesInPairsTests
    {
        [Test]
        [TestCaseSource(nameof(TestListNodes))]
        public void Test1(ListNode input)
        {
          //  var result = SwapNodesInPairs.SwapPairs(input);
        }

        private static IEnumerable<ListNode> TestListNodes()
        {
            yield return new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        }
    }
}
