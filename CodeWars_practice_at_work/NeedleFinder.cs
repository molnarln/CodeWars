using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class NeedleFinder
    {
        public static string FindNeedle(object[] input)
        {
            string output = string.Empty;
            if (input.Length == 0)
            {
                return "n/a";
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != null && input[i].Equals("needle"))
                {
                    output += $"found the needle at position {i}";
                }
            }
            return output;
        }
    }
}
