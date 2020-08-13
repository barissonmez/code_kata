using System.Collections.Generic;

namespace Kata.SplitStrings
{
    public class Solution5
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();

            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                    result.Add(str[i - 1].ToString() + str[i].ToString());
                else if (i == str.Length - 1)
                    result.Add(str[i].ToString() + "_");
            }

            return result.ToArray();
        }
    }
}