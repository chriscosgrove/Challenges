using CodeWars;

namespace Challenges.Tests.CodeWars
{
    public class YourOrderPleaseTests
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal("Thi1s is2 3a T4est", YourOrderPlease.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople",
                YourOrderPlease.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("", YourOrderPlease.Order(""));
        }
    }
}