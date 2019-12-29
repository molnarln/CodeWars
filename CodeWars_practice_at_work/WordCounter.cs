using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public static class WordCounter
    {
        public static List<string> CountWords(string input)
        {
            int counter = 0;
            Regex regex = new Regex("[^/.,']+");
            List<string> listOfWords = input.ToLower().Split(null).ToList();
            var listOfMostFrequent = listOfWords
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count())
                .OrderByDescending(x => x.Value);

            List<string> outputList = new List<string>();
            foreach (var item in listOfMostFrequent)
            {
                if (counter < 3 && regex.Match(item.Key).Success)
                {
                    outputList.Add(item.Key);
                    counter++;
                }
            }
            return outputList;
        }
    }
}