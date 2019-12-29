using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class OddFinder
    {
        public static int FindOdd(List<int> input)
        {
            int indexOfOdd = -1;
            foreach (var item in input)
            {
                if (item % 2 != 0)
                {
                    indexOfOdd = input.IndexOf(item);
                }
            }
            return indexOfOdd;
        }
    }
}