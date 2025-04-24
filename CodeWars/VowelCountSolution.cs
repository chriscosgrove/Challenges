namespace CodeWars
{
    using System.Linq;
    /*
        https://www.codewars.com/kata/vowel-count/csharp
        Return the number (count) of vowels in the given string.
        We will consider a, e, i, o, and u as vowels for this Kata.
        The input string will only consist of lower case letters and/or spaces.
    */
    public static class VowelCountSolution
    {
        public static int GetVowelCount(string str)
        {
            if (str is null)
            {
                return 0;
            }

            var vowelCount = 0;

            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            // Your code goes here
            var characters = str.ToCharArray();

            for (var i = 0; i < characters.Count(); i++)
            {
                var character = characters[i];

                for (var j = 0; j < vowels.Count(); j++)
                {
                    var vowel = vowels[j];
                    if (character == vowel)
                    {
                        vowelCount++;
                    }
                }

            }

            return vowelCount;
        }

        public static int BestPracticeSolution(string str)
        {
            return str?.Count(i => "aeiou".Contains(i)) ?? 0;
        }
    }
}
