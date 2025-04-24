using NUnit.Framework;
using CodeWars.Katas;

namespace CodeWars.Tests.Katas
{
    [TestFixture]
    public class DoubleColaSolutionTests
    {
        [Test]
        public void Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon",DoubleColaSolution.WhoIsNext(names, n));
        }

        [Test]
        public void Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon",DoubleColaSolution.WhoIsNext(names, n));
        }
    }
}