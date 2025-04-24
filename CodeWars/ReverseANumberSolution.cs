using System;
using System.Linq;

namespace CodeWars
{
    public class Kata
    {
        public static int ReverseNumber(int n)
        {
            return int.Parse(string.Concat(Math.Abs(n).ToString().Reverse())) * (n < 0 ? -1 : 1);
        }
    }
}

