using System;
using System.Linq;

namespace Kata.DisemvowelTrolls
{
    public class Solution3
    {
        public static string Disemvowel(string str)
        {
            var decimalCodesOfVowels = new [] { 65, 69, 73, 79, 85, 97, 101, 105, 111, 117}; // A=65, E=69, I=73, O=79, U=85, a=97, e=101, i=105, o=111, u=117

            return string.Concat(str.Where(a => !decimalCodesOfVowels.Contains(a)));
        }
    }
}
