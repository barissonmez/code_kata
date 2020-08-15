using System;
using Xunit;

namespace Test.DisemvowelTrolls
{
    public class DisemvowelTrollsTests
    {
        [Fact]
        public void DisemvowelTrollsSolution4Tests()
        {
            Assert.Equal("Ths wbst s fr lsrs LL!", Kata.DisemvowelTrolls.Solution4.Disemvowel("This website is for losers LOL!"));
        }

        [Fact]
        public void DisemvowelTrollsSolution3Tests()
        {
            Assert.Equal("Ths wbst s fr lsrs LL!", Kata.DisemvowelTrolls.Solution3.Disemvowel("This website is for losers LOL!"));
        }

        [Fact]
        public void DisemvowelTrollsSolution2Tests()
        {
            Assert.Equal("Ths wbst s fr lsrs LL!", Kata.DisemvowelTrolls.Solution2.Disemvowel("This website is for losers LOL!"));
        }

        [Fact]
        public void DisemvowelTrollsSolution1Tests()
        {
            Assert.Equal("Ths wbst s fr lsrs LL!", Kata.DisemvowelTrolls.Solution1.Disemvowel("This website is for losers LOL!"));
        }
    }
}
