using System.Diagnostics;
using NUnit.Framework;
using static CodeWars.Katas.VowelCountSolution;

namespace CodeWars.Tests.Katas
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        [TestCase(5, "abracadabra")]
        [TestCase(6, "aie oi  e")]
        [TestCase(0, null)]
        [TestCase(0, "")]
        public void MySolutionTests(int expectedVowelCount, string sentence)
        {
            var sw = new Stopwatch();
            sw.Start();
            Assert.AreEqual(expectedVowelCount, GetVowelCount(sentence));
            var timeSpent = sw.ElapsedMilliseconds;
            Debug.Print(timeSpent.ToString());
            sw.Stop();
        }

        [Test]
        [TestCase(5, "abracadabra")]
        [TestCase(6, "aie oi  e")]
        [TestCase(0, null)]
        [TestCase(0, "")]
        public void BestPracticeTests(int expectedVowelCount, string sentence)
        {
            var sw = new Stopwatch();
            sw.Start();
            Assert.AreEqual(expectedVowelCount, BestPracticeSolution(sentence));
            var timeSpent = sw.ElapsedMilliseconds;
            Debug.Print(timeSpent.ToString());
            sw.Stop();
        }
    }
}