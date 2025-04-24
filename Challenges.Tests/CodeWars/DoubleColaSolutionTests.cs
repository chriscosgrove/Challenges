using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class DoubleColaSolutionTests
    {
        [Fact]
        public void Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.Equal("Sheldon",DoubleColaSolution.WhoIsNext(names, n));
        }

        [Fact]
        public void Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.Equal("Sheldon",DoubleColaSolution.WhoIsNext(names, n));
        }
    }
}