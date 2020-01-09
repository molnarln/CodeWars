using System;
using System.Linq;

namespace CodeWars
{
    public static class MinimumSum
    {

        public static int MinimumSumFunction(int[] input)
        {
            if (input.Length == 0)
            {
                return 0;
            }
            int returnValue = 0;
            int[] inputCopy = new int[input.Length];
            input.CopyTo(inputCopy, 0);

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (inputCopy.Length != 0)
                {
                    returnValue += inputCopy.ToList().Min() * inputCopy.ToList().Max();

                    Array.Sort(inputCopy);
                    inputCopy = inputCopy.Skip(1).ToArray();
                    Array.Reverse(inputCopy);
                    inputCopy = inputCopy.Skip(1).ToArray();

                }
            }
            return returnValue;
        }
    }
}
