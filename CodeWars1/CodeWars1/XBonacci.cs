using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    class XBonacci
    {
        public double[] XBonacciFunction(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[0];
            }
            int numberOfAdd = signature.Length;
            double[] xBonacci = new double[n];

            for (int i = 0; i < signature.Length; i++)
            {
                xBonacci[i] = signature[i];
            }

            for (int i = signature.Length; i < n; i++)
            {
                xBonacci[i] = xBonacci[i - 3] + xBonacci[i - 2] + xBonacci[i - 1];
            }
            return xBonacci;
        }
    }
}
