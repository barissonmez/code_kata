using System;
using System.Linq;

namespace Kata.DisemvowelTrolls
{
    public class Solution1
    {
        public static string Disemvowel(string str)
        {
            var vowels = new [] { "a", "e", "i", "o", "u" };

            string result = null;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i].ToString().ToLowerInvariant()))
                    continue;

                result += str[i].ToString();

            }

            return result;
        }
    }
}
