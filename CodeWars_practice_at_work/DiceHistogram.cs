using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    public static class DiceHistogram
    {
        public static string CreateHistogram(int[] input)
        {
            List<string> stringList = new List<string>()
            {
            "1|",
            "2|",
            "3|",
            "4|",
            "5|",
            "6|"
            };
            for (int i = 0; i < stringList.Count; i++)
            {
                for (int j = 0; j < input[i]; j++)
                {
                    stringList[i] += "#";
                }
                if (input[i] != 0)
                {
                stringList[i] += " " + input[i].ToString() + "\n";
                }
                else
                {
                    stringList[i] += "\n";
                }
            }
            string output = String.Empty;
            stringList.Reverse();
            return String.Join(null, stringList);
        }
    }
}
