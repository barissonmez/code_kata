using System.Linq;

namespace Kata.SplitStrings
{
    public class Solution3
    {
        public static string[] Solution(string str)
        {
            return str.Select((c, i) => i > 0 ? i % 2 == 1 ? str.Substring(i - 1, 2) : i == str.Length - 1 ? str.Substring(i, 1) + "_" : null : null).Where(a => a != null).ToArray();
        }
    }
}