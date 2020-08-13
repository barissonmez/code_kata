using System;
using System.Linq;

namespace Kata.YourOrderPlease
{
    public class Solution2
    {
        public static string Order(string words)
        {
            var orderedWords = words
                                            .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                                            .ToDictionary(v => (byte)char.GetNumericValue(v.ToCharArray().Single(c => char.IsDigit(c))), v => v)
                                            .OrderBy(a => a.Key)
                                            .Select(v => v.Value);

            return string.Join(" ", orderedWords);
        }
    }
}
