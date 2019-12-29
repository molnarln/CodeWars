using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace CodeWars
{
    public static class Faktorio
    {
        //----------------------------Need to finish!!----------------------------------------
        public static double FaktorioCounter(int input)
        {
            double firstPart = ((double)1 / (double)Factorial(input));
            double secondPart = 0;

            for (int i = 1; i <= input; i++)
            {
                secondPart += (double)Factorial(i);
            }
            double output = Math.Round((double)firstPart * (double)secondPart, 6);
            return (double)output;
        }

        public static double Factorial(int input)
        {
            double output = 1;

            for (int i = 1; i <= input; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}