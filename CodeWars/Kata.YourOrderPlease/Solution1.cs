using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.YourOrderPlease
{
    public class Solution1
    {
        public static string Order(string words)
        {
            var wordArr = words.Split(new [] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var wordsDict = new Dictionary<byte, string>();

            foreach (var w in wordArr)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    if (char.IsDigit(w[i]))
                        wordsDict.Add(Convert.ToByte(w[i].ToString()), w);
                }
            }

            return string.Join(" ", wordsDict.OrderBy(a=> a.Key).Select(a=> a.Value));
        }
    }
}
