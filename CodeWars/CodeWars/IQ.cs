using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{


    public class IQ
    {
        public static int Test(string numbers)
        {
            List<int> numbersToInt = numbers.Split().Select(int.Parse).ToList();
            int odds = 0;
            int evens = 0;
            int indexOfDifferent = 0;
            foreach (var item in numbersToInt)
            {
                if (item % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    odds++;
                }
            }
            if (evens > odds)
            {
                for (int i = 0; i < numbersToInt.Count; i++)
                {
                    if (numbersToInt[i] % 2 != 0)
                    {
                        indexOfDifferent = i;
                    }
                }
            }
            if (evens < odds)
            {
                for (int i = 0; i < numbersToInt.Count; i++)
                {
                    if (numbersToInt[i] % 2 == 0)
                    {
                        indexOfDifferent = i;
                    }
                }
            }
            return indexOfDifferent + 1;
        }
    }
}
