namespace LeetCode.Problem_35;

public class Problem35
{
    public static int SearchInsertPosition(int[] nums, int target)
    {
        var low = 0;
        var high = nums.Length - 1;
        var guess = 0;
        while (low <= high)
        {

            var midIndex = (low + high) / 2;
            guess = nums[midIndex];

            if (guess == target)
            {
                return midIndex;
            }

            if (guess < target)
            {
                low = midIndex + 1;
            }

            if (guess > target)
            {
                high = midIndex - 1;
            }
        }

        return low;
    }
}
