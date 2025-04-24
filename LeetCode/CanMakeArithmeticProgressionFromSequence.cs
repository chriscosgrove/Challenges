using System;
using System.Linq;
using System.Net.Http.Headers;

namespace LeetCode
{
    public static class CanMakeArithmeticProgressionFromSequence
    {
        public static bool CanMakeArithmeticProgression(int[] arr)
        {

            Array.Sort(arr);
            int diff = arr[1] - arr[0];

            for (int i = 2; i < arr.Length; i++)
                if (diff != arr[i] - arr[i - 1]) 
                    return false;

            return true;

            arr = arr.OrderByDescending(e => e).ToArray();

            foreach (var r in arr)
            {
                Console.WriteLine(r);
            }
            

            int gap = arr[1] - arr[0];
            var arithSeq = arr.TakeWhile((a, i) => i + 1 < arr.Length && arr[i + 1] - a == gap);
            return arithSeq.Count() == arr.Length - 1 ? true : false;

            //var orderedList = arr.OrderByDescending(i => i).ToArray();
            //foreach (var i in orderedList)
            //{
            //    Console.WriteLine(i);
            //}
            //var difference = 0;
            //var arithmeticProgression = false;

            //for (var i = 0; i < orderedList.Length; i++)
            //{

            //    if (orderedList.Length == 2)
            //    {
            //        arithmeticProgression = true;
            //        break;
            //    }

            //    if (i + 1 > orderedList.Length - 1)
            //        break;

            //    var nextDifference = orderedList[i] - orderedList[i + 1];

            //    if (i == 0)
            //    {
            //        difference = nextDifference;
            //        continue;
            //    }

            //    if (nextDifference == difference)
            //    {
            //        arithmeticProgression = true;
            //        break;
            //    }

            //    difference = nextDifference;
            //}

            //return arithmeticProgression;
        }
    }
}
