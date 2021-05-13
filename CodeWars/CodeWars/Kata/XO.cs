using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class XO
    {
        public static bool XOMethod(string input)
        {
            var x = input.ToLower().ToCharArray().Where(i => i == 'x').Count();
            var y = input.ToLower().ToCharArray().Where(i => i == 'o').Count();


            return x == y ? true : false;

        }
    }
}
