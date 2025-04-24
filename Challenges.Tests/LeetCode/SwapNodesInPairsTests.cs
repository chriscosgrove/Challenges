using LeetCode;

namespace Challenges.Tests.LeetCode
{
    public class SwapNodesInPairsTests
    {
        [Theory]
        [MemberData(nameof(TestListNodes))]
        public void Test1(ListNode input)
        {
          //  var result = SwapNodesInPairs.SwapPairs(input);
        }

        public static IEnumerable<object[]> TestListNodes()
        {
            yield return new[] { new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))) };
        }
    }
}
