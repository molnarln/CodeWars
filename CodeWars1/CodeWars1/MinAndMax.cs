using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    public class MinAndMax
    {
        public static string HighAndLow(string numbers)
        {

            string[] stringArray = numbers.Split(new char[] { ' ' });
            int i;
            List<int> intList = new List<int>();

            foreach (var item in stringArray)
            {
                i = int.Parse(item);
                intList.Add(i);
            }
            int min = intList.Min();
            int max = intList.Max();

            //int[] intArray = int.Parse
            // Code here or
            return $"{max} {min}";
        }

    }
}
