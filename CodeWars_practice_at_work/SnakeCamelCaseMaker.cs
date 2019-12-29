using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeWars
{
    public static class SnakeCamelCaseMaker
    {
        public static string ConvertToSnakeCamelCase(string input)
        {
            List<char> stringList = input.ToList();
            List<char> snakeList = new List<char>();
            
            foreach (var item in stringList)
            {
                if (Char.IsUpper(item))
                {
                    snakeList.Add('_');
                    snakeList.Add(item);
                }
                else
                {
                    snakeList.Add(item);
                }
            }
            return new string(snakeList.ToArray()).Substring(1, snakeList.Count-1).ToLower();
        }

        public static string ConvertToSnakeCamelCase(int input)
        {

            return input.ToString();
        }

    }
}
