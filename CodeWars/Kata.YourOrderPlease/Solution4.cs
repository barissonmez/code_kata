using System.Collections.Generic;
using System.Linq;

namespace Kata.YourOrderPlease
{
    public class Solution4
    {
        public static string Order(string words)
        {
            return string.Join(" ", words
                                                    .Split(' ')
                                                    .OrderBy(a => a.SingleOrDefault(char.IsDigit)));
        }
    }
}
