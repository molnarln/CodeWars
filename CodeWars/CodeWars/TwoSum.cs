using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    class TwoSum
    {
        public static int[] TwoSumFunction(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target && i != j)
                    {
                        result[0] = j;
                        result[1] = i;
                    }
                }
            }
            return result;
        }

    }
}
