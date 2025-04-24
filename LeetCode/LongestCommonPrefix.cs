using System;
using System.Linq;

namespace CodeWars.LeetCode
{
    public class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;

            var orderedStrings = strs.OrderBy(s => s.Length).ToArray();
            var smallestWord = orderedStrings[0];
            var foundSubString = string.Empty;

            if (orderedStrings.Length == 1 && smallestWord != string.Empty)
                return smallestWord
                    .ToCharArray()
                    .First()
                    .ToString();

            for (var i = 0; i <= smallestWord.Length; i++)
            {
                var smallestWordSubstring = smallestWord.Substring(0, i);

                var substrings = orderedStrings.Select(@string => @string.Substring(0, i));

                if (substrings.Distinct().Count() == 1)
                {
                    foundSubString = smallestWordSubstring;
                    continue;
                }
                break;
            }
            return foundSubString;
        }
    }
}
