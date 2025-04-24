using CodeWars.Katas;
using NUnit.Framework;

namespace CodeWars.Tests.Katas
{
    [TestFixture]
    public class TripletIndexFinderSolutionTests
    {
        [Test]
        public void FindTheMiddleNumberIndex()
        {
            Assert.AreEqual(0, TripletIndexFinderSolution.Gimme(new double[] {2, 3, 1}));
            Assert.AreEqual(1, TripletIndexFinderSolution.Gimme(new double[] {5, 10, 14}));
        }
    }
}
