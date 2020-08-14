using System;
using System.Linq;

namespace Kata.PrinterErrors
{
    public class Solution3
    {
        public static string PrinterError(String s)
        {
            return $"{s.ToLowerInvariant().Count(c => !Enumerable.Range(97, 13).Contains(c))}/{s.Length}";
        }
    }
}
