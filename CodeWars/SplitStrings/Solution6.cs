using System;

namespace Kata.SplitStrings
{
    public class Solution6
    {
        public static string[] Solution(string str)
        {
            var result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                    result += str[i - 1].ToString() + str[i].ToString() + ",";
                else if (i == str.Length - 1)
                    result += str[i].ToString() + "_";
            }

            return result.Split(new [] { "," }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}