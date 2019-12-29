using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class MissingFinder
    {
        public static int FindMissing(List<int> input)
        {
            
            var diff1 = input[1] - input[0];
            var diff2 = input[2] - input[1];
            int cdiff;
            int missing = 0;
            if (diff1 > diff2)
            {
                cdiff = diff2;
            }
            else
            {
                cdiff = diff1;
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (i > 0 && input[i] != input[i - 1] + cdiff)
                {
                    missing += input[i - 1] + cdiff;
                }
            }
            
            return missing;
        }
    }
}
