using System;

namespace Kata.SplitStrings
{
    public class Solution2
    {
        public static string[] Solution(string str)
        {
            var result = new string[] { };

            var ind = 0;

            for (int i = 0; i < str.Length; i = i + 2)
            {

                if (i + 1 < str.Length)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[ind] = string.Concat(str[i], str[i + 1]);
                }
                else
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[ind] = string.Concat(str[i], "_");
                }

                ind++;
            }

            return result;
        }
    }
}