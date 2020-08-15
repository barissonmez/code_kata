using System;
using System.Linq;

namespace Kata.DisemvowelTrolls
{
    public class Solution2
    {
        public static string Disemvowel(string str)
        {
            return string.Concat(str.Where(a => !new [] { "a", "e", "i", "o", "u" }.Contains(a.ToString().ToLowerInvariant())));
        }
    }
}
