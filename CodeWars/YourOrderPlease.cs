using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /*
     * Your task is to sort a given string. Each word in the string will contain a single number.
     * This number is the position the word should have in the result.
     * Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
     * If the input string is empty, return an empty string.
     * The words in the input String will only contain valid consecutive numbers.
    */

    public static class YourOrderPlease
    {
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return string.Empty;

            var wordsList = words.Split(" ").ToList();

            var dictionary = new Dictionary<int, string>();
            wordsList.ForEach(word =>
            {
                var number = int.Parse(
                    word.ToCharArray()
                        .Single(char.IsDigit)
                        .ToString());

                dictionary.Add(number, word);
            });
            return string.Join(' ', dictionary.OrderBy(x => x.Key).Select(s => s.Value));
        }
    }
}