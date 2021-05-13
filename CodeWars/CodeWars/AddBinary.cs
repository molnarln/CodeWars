using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{

    public static class AddBinary
    {
        public static string AddBinaryFunction(int a, int b)
        {
            int sum = a + b;
            string binary = Convert.ToString(sum, 2);

            return binary;
        }
    }
}
