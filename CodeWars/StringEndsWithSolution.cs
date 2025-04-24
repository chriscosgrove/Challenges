namespace CodeWars
{
    /// <summary>
    /// https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp
    /// Complete the solution so that it returns true if the first argument(string)
    /// passed in ends with the 2nd argument (also a string).
    /// </summary>
    public static class StringEndsWithSolution
    {
        public static bool Solution(string str, string ending)
        {
            // Better solution => return str.EndsWith(ending);
            return str.Length >= ending.Length && str.Substring(str.Length - ending.Length) == ending;
        }
    }
}