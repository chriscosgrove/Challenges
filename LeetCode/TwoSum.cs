using System.Collections.Generic;
using System.Linq;

namespace CodeWars.LeetCode
{
    public static class TwoSum
    {
        public static int[] Resolve(int[] nums, int target)
        {
            var first = 0;
            var second = 0;
            var found = false;
            LinkedListNode<int> d = new LinkedListNode<int>(2);
            
            for (var i = 0; i < nums.Length; i++)
            {
                first = i;
                for (var j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        second = j;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            return new[]
            {
                first, 
                second
            }.OrderBy(s => s).ToArray();
        }
    }
}
