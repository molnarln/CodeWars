using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    public static class MissingCharFinder
    {
        public static char FindMissingChar(char[] input)
        {
            var alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            char[] charArrayAlphabet = alphabet.Split(' ').Select(x => char.Parse(x)).ToArray();
            char result = new char();
            var indexOfChar = Array.IndexOf(charArrayAlphabet, char.ToUpper(input[0]));
            char[] subArray = charArrayAlphabet.Skip(indexOfChar).Take(input.Length).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.ToUpper(input[i]) != char.ToUpper(subArray[i]) && char.IsLower(input[i]))
                {
                    result = char.ToLower(subArray[i]);
                    break;
                }
                if (char.ToUpper(input[i]) != char.ToUpper(subArray[i]) && !char.IsLower(input[i]))
                {
                    result = char.ToUpper(subArray[i]);
                    break;
                }
            }

            return result;
        }
    }
}
