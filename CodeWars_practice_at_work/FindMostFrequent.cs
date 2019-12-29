using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    static class FindMostFrequent
    {
        public static char FindMostFrequentFunction(string input)
        {
            var charDictionary = input
                .GroupBy(e => e)
                .ToDictionary(e => e.Key, e => e.Count());

            return charDictionary.Where(e => e.Value == charDictionary.Values.Max()).First().Key;
        }
    }
}
