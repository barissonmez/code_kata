using System;
using Xunit;

namespace Test.PrinterErrors
{
    public class PrinterErrorsTests
    {
        [Fact]
        public void PrinterErrorsSolution3Tests()
        {
            const string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.Equal("3/56", Kata.PrinterErrors.Solution3.PrinterError(s));
        }

        [Fact]
        public void PrinterErrorsSolution2Tests()
        {
            const string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.Equal("3/56", Kata.PrinterErrors.Solution2.PrinterError(s));
        }

        [Fact]
        public void PrinterErrorsSolution1Tests()
        {
            const string s="aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.Equal("3/56", Kata.PrinterErrors.Solution1.PrinterError(s));
        }
    }
}
