using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class AlphaNumericChecker
    {
        public static bool CheckAlphaNumeric(string input)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            bool output = true;
            if (input.Length == 0)
            {
                output = false;
            }
            foreach (var item in input)
            {
                if (input.Length == 0 || regex.Match(item.ToString()).Success != false)
                {
                    output = false;
                    break;
                }

            }
            return output;
        }
    }
}
