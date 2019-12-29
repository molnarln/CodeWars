using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    public static class ArrayInArray
    {
        public static int FindPlaceOfArray(object[][] input, object[] query)
        {
            if (query.Length != 2)
            {
                throw new Exception();
            }
            foreach (var item in input)
            {
                if (!item.GetType().IsArray)
                {
                    throw new Exception();
                }
                if (item.Length != 2)
                {
                    throw new Exception();
                }

            }
            int returnValue = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].SequenceEqual(query))
                {
                    returnValue = i;
                    break;
                }
            }
            return returnValue;
        }
    }
}
