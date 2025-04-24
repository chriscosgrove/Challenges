using System.Linq;

namespace CodeWars
{
    public class FindTheOddInt
    {
        /// <summary>
        /// https://www.codewars.com/kata/54da5a58ea159efa38000836/solutions/csharp/all/newest
        /*
         * Description:
            Given an array of integers, find the one that appears an odd number of times.

            There will always be only one integer that appears an odd number of times.

            Examples
            [7] should return 7, because it occurs 1 time (which is odd).
            [0] should return 0, because it occurs 1 time (which is odd).
            [1,1,2] should return 2, because it occurs 1 time (which is odd).
            [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
            [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
         */
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int find_it(int[] seq)=>
            seq.Distinct()
                .ToList()
                .Single(distinctValue => seq.Count(i => i == distinctValue) % 2 == 1);
    }
}
