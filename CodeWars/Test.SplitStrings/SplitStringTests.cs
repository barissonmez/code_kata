using System;
using Xunit;

namespace Test.SplitStrings
{
    public class SplitStringTests
    {

        [Fact]
        public void SplitStringSolution1Tests()
        {

            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution1.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution1.Solution("abcdef"));
        }

        [Fact]
        public void SplitStringSolution2Tests()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution2.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution2.Solution("abcdef"));
        }

        [Fact]
        public void SplitStringSolution3Tests()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution3.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution3.Solution("abcdef"));
        }

        [Fact]
        public void SplitStringSolution4Tests()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution4.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution4.Solution("abcdef"));
        }

        [Fact]
        public void SplitStringSolution5Tests()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution5.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution5.Solution("abcdef"));
        }

        [Fact]
        public void SplitStringSolution6Tests()
        {
            Assert.Equal(new string[] { "ab", "c_" }, Kata.SplitStrings.Solution6.Solution("abc"));
            Assert.Equal(new string[] { "ab", "cd", "ef" }, Kata.SplitStrings.Solution6.Solution("abcdef"));
        }
    }
}
