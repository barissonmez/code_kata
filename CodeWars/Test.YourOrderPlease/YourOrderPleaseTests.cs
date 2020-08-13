using System;
using Xunit;

namespace Test.YourOrderPlease
{
    public class YourOrderPleaseTests
    {
        [Fact]
        public void YourOrderPleaseSolution4Tests()
        {
            Assert.Equal("Thi1s is2 3a T4est", Kata.YourOrderPlease.Solution4.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Kata.YourOrderPlease.Solution4.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("", Kata.YourOrderPlease.Solution4.Order(""));
        }

        [Fact]
        public void YourOrderPleaseSolution3Tests()
        {
            Assert.Equal("Thi1s is2 3a T4est", Kata.YourOrderPlease.Solution3.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Kata.YourOrderPlease.Solution3.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("", Kata.YourOrderPlease.Solution3.Order(""));
        }

        [Fact]
        public void YourOrderPleaseSolution2Tests()
        {
            Assert.Equal("Thi1s is2 3a T4est", Kata.YourOrderPlease.Solution2.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Kata.YourOrderPlease.Solution2.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("", Kata.YourOrderPlease.Solution2.Order(""));
        }

        [Fact]
        public void YourOrderPleaseSolution1Tests()
        {
            Assert.Equal("Thi1s is2 3a T4est", Kata.YourOrderPlease.Solution1.Order("is2 Thi1s T4est 3a"));
            Assert.Equal("Fo1r the2 g3ood 4of th5e pe6ople", Kata.YourOrderPlease.Solution1.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.Equal("", Kata.YourOrderPlease.Solution1.Order(""));
        }
    }
}
