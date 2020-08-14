using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.PrinterErrors
{
    public class Solution2
    {
        public static string PrinterError(String s)
        {
            var decimalCodesRangeOfValidLetters = Enumerable.Range(97, 13); //a...m => Decimal Value in ASCII Table => 97...109
            
            var errors = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var decimalCode = (byte)s[i];

                if (!decimalCodesRangeOfValidLetters.Contains(decimalCode))
                    errors.Add(s[i]);
            }


            return $"{errors.Count}/{s.Length}";
        }
    }
}
