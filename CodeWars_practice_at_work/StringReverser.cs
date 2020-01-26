using System;
using System.Linq;

namespace CodeWars
{
    public static class StringReverser
    {
        public static string ReverseString(string input)
        {
            string output = String.Empty;
            var charList = input.ToList();
            charList.Reverse();
            charList.ForEach(e => output += e);
            return output;
        }
    }
}
