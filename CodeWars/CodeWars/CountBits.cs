using System;
using System.Linq;

namespace CodeWars1
{
    class CountBits
    {
        public static int CountBitsMethod(int n)
        {
            var str = Convert.ToString(n, 2).ToCharArray().Count(i=>i.Equals('1'));

            return str;
        }
    }
}
