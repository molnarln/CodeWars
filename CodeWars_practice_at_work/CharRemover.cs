using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    public static class CharRemover
    {
        public static string RemoveFirstAndLastChar(string input)
        {
            return input.Substring(1, input.Length - 2);
        }
    }
}
