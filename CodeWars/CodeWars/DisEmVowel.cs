using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    public class DisEmVowel
    {
        public static string Disemvowel(string str)
        {

            string[] vowels = { "a", "e", "i", "o", "u" };

            for (int i = 0; i < vowels.Length; i++)
            {
                str = str.Replace(vowels[i], string.Empty);
            }

            return str;
        }

    }
}
