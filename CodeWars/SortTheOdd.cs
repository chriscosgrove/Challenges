using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            var odds = new Queue<int>(array.Where(number => number % 2 != 0).OrderBy(o => o));
            var correctOrder = array.Select(number => number % 2 != 0 ? odds.Dequeue() : number);
            
            return correctOrder.ToArray();
        }
    }
}
