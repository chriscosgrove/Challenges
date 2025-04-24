using System.Collections.Generic;
using System.Linq;

namespace CodeWars.LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var foundSubStringsLengths = new List<int>();
            var characters = s.ToCharArray();
            var foundCharacters = new List<char>();

            for (var i = 0; i < characters.Length; i++)
            {
                foundCharacters.Add(characters[i]);

                var nextItem = i+1;
                if (nextItem > characters.Length)
                    break;
                    
                for (var j = nextItem; j <= characters.Length; j++)
                {
                    if (j == characters.Length)
                    {
                        foundSubStringsLengths.Add(foundCharacters.Count);
                        foundCharacters.Clear();
                        break;
                    }

                    if (!foundCharacters.Contains(characters[j]))
                    {
                        foundCharacters.Add(characters[j]);
                        continue;
                    }

                    foundSubStringsLengths.Add(foundCharacters.Count);
                    foundCharacters.Clear();
                    break;
                }
            }

            return foundSubStringsLengths.Max();
        }
    }
}
