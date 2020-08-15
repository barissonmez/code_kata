using System;
using System.Linq;

namespace Kata.DisemvowelTrolls
{
    public class Solution4
    {
        public static string Disemvowel(string str)
        {
            return string.Concat(str.Split(new [] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' }));
        }
    }
}
