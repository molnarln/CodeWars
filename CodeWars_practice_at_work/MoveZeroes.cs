using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class MoveZeroes
    {
        public static int[] MoveZeroesFunction(int[] input)
        {
            List<int> zerosList = new List<int>();
            List<int> notZerosList = new List<int>();
            foreach (var item in input)
            {
                if (item == 0)
                {
                    zerosList.Add(item);
                }
                else
                {
                    notZerosList.Add(item);
                }
            }
            notZerosList.AddRange(zerosList);
            return notZerosList.ToArray();
        }
    }
}
