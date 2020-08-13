using System.Collections.Generic;
using System.Linq;

namespace Kata.YourOrderPlease
{
    public class Solution3
    {
        public static string Order(string words)
        {
            var orderedWords = new Dictionary<byte,string>();

            string chars = null;
            byte idx = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsWhiteSpace(words[i]))
                {
                    orderedWords.Add(idx, chars);
                    chars = null;
                    continue;
                }
                    
                chars += words[i];

                if (char.IsDigit(words[i]))
                    idx = (byte)char.GetNumericValue(words[i]);

                if (i == words.Length -1)
                    orderedWords.Add(idx, chars);
            }

            return string.Join(" ", orderedWords.OrderBy(a => a.Key).Select(a => a.Value));
        }
    }
}
