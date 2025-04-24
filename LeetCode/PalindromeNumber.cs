using System;

namespace CodeWars.LeetCode
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            var reversed = x.ToString().ToCharArray();
            Array.Reverse(reversed);
            if (x.ToString() == new string(reversed))
            {
                return true;
            }

            return false;
        }
    }
}
