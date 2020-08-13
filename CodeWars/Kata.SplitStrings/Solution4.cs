using System.Collections.Generic;

namespace Kata.SplitStrings
{
    public class Solution4
    {
        public static string[] Solution(string str)
        {
            var result = new List<string>();

            string pair = null;

            for (var i = 0; i < str.Length; i++)
            {
                pair += str[i];

                if (pair.Length == 2)
                {
                    result.Add(pair);
                    pair = null;
                }
                else
                if (i == str.Length - 1)
                    result.Add(pair + "_");

            }

            return result.ToArray();
        }
    }
}