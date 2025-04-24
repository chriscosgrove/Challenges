using CodeWars;
using System.Diagnostics;

namespace Challenges.Tests.CodeWars
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(5, "abracadabra")]
        [InlineData(6, "aie oi  e")]
        [InlineData(0, null)]
        [InlineData(0, "")]
        public void MySolutionTests(int expectedVowelCount, string sentence)
        {
            var sw = new Stopwatch();
            sw.Start();
            Assert.Equal(expectedVowelCount, VowelCountSolution.GetVowelCount(sentence));
            var timeSpent = sw.ElapsedMilliseconds;
            Debug.Print(timeSpent.ToString());
            sw.Stop();
        }

        [Theory]
        [InlineData(5, "abracadabra")]
        [InlineData(6, "aie oi  e")]
        [InlineData(0, null)]
        [InlineData(0, "")]
        public void BestPracticeTests(int expectedVowelCount, string sentence)
        {
            var sw = new Stopwatch();
            sw.Start();
            Assert.Equal(expectedVowelCount, VowelCountSolution.BestPracticeSolution(sentence));
            var timeSpent = sw.ElapsedMilliseconds;
            Debug.Print(timeSpent.ToString());
            sw.Stop();
        }
    }
}