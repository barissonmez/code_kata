using System;
using System.Collections.Generic;

namespace Kata.PrinterErrors
{
    public class Solution1
    {
        public static string PrinterError(String s)
        {
            //a...m => Decimal Value in ASCII Table => 97...109
            //n...z => Decimal Value in ASCII Table => 110...122
            
            var errors = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var decimalCode = (byte)s[i];

                if (decimalCode >= 110 || decimalCode < 97)
                    errors.Add(s[i]);
            }


            return $"{errors.Count}/{s.Length}";
        }
    }
}
