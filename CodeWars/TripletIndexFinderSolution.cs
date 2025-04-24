using System;
using System.Linq;

namespace CodeWars.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/find-the-middle-element/csharp
    /// </summary>
    public class TripletIndexFinderSolution
    {
        public static int Gimme(double[] inputArray)
        {
            return Array.IndexOf(inputArray, inputArray.OrderBy(itself => itself).ToArray()[1]);
        }
    }
}