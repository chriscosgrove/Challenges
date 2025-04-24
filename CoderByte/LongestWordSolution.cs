using System.Linq;

namespace CodeWars.CoderByte
{
    public static class LongestWordSolution
    {
        public static string LongestWord(string sen)
        {
            // code goes here  

            var words = sen.Split(" ");

            var sortedWords = words.OrderByDescending(
                word => new string(
                    word.ToCharArray()
                        .Where(c => !char.IsPunctuation(c))
                        .ToArray()).Length);

            return sortedWords.First();
        }
    }
}
