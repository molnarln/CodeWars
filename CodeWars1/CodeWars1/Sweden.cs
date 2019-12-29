using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    class Sweden
    {
        public int Sum(int a)
        {
            var sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += a;
                a++;
            }
            if (sum < 0)
            {
                throw new Exception("Return value must be positive!");
            }
            return sum;
        }

        public int Sum2(int a)
        {
            var sum = Enumerable.Range(a, a + 9).Sum();
            if (sum < 0)
            {
                throw new Exception("Return value must be positive!");
            }
            return sum;
        }
    }
}
