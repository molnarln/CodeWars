using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class SmallestIntegerFinder
    {
        public static int FindSmallest(int[] input)
        {
            int output = input[0];
            foreach (var item in input)
            {
                if (item < output)
                {
                    output = item;
                }
            }
            return output;
        }
    }
}
