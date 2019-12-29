using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class StringAverage
    {
        public static Dictionary<string, int> Inventory { get; set; }
        static StringAverage()
        {
            Inventory = new Dictionary<string, int>()
            {
                {"zero", 0 },
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
                {"five", 5 },
                {"six", 6 },
                {"seven", 7 },
                {"eight", 8 },
                {"nine", 9 }
            };

        }

        public static string CountStringAverage(string input)
        {
            var stringArray = input.Split(' ');
            int sum = 0;
            if (stringArray.Length == 0)
            {
                return "n/a";
            }
            foreach (var item in stringArray)
            {
                if (Inventory.ContainsKey(item))
                {
                    sum += Inventory[item];
                }
                else
                {
                    return "n/a";
                }
            }
            var average = sum / stringArray.Length;
            return Inventory.FirstOrDefault(x => x.Value == average).Key;
        }
    }
}