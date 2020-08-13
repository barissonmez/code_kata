using System;
using System.Collections.Generic;

namespace Kata.SplitStrings
{
    public class Solution1
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();

            for (int i = 0; i < str.Length; i = i + 2)
            {

                if (i + 1 < str.Length)
                {
                    Console.WriteLine(string.Concat(str[i], str[i + 1]));

                    result.Add(string.Concat(str[i], str[i + 1]));
                }
                else
                {
                    Console.WriteLine(string.Concat(str[i], "_"));
                    result.Add(string.Concat(str[i], "_"));
                }
            }

            return result.ToArray();
        }
    }
}