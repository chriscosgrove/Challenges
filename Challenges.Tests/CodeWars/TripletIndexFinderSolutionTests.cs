using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class TripletIndexFinderSolutionTests
    {
        [Fact]
        public void FindTheMiddleNumberIndex()
        {
            Assert.Equal(0, TripletIndexFinderSolution.Gimme(new double[] {2, 3, 1}));
            Assert.Equal(1, TripletIndexFinderSolution.Gimme(new double[] {5, 10, 14}));
        }
    }
}
