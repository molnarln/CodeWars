using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(StringAverage.CountStringAverage("zero nine five two"));
            Console.WriteLine(PhoneNumberValidator.ValidatePhoneNumber("(1111)555 2345"));
            Console.WriteLine(NeedleFinder.FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
            Console.WriteLine(MissingFinder.FindMissing(new List<int>() { 1040, 1220, 1580 }));
            Console.WriteLine(MissingCharFinder.FindMissingChar(new[] { 'a', 'b', 'c', 'd', 'f' }));
            //SecondCounter.CountSeconds("5");
            MoveZeroes.MoveZeroesFunction(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine(IPv4Converter.ConvertToIPv4(654654));
            Console.WriteLine(OddFinder.FindOdd(new List<int> { 2, 4, 6, 7, 10 }));
            Console.WriteLine(StringSummer.SumStrings("123", "456"));
            PermutationMaker.CreatePermutations("aabb")
                .ToList()
                .ForEach(c => c.ToList().ForEach(x => Console.Write(x)));
            Console.WriteLine("\n" + CharRemover.RemoveFirstAndLastChar("alma"));
            Console.WriteLine(SnakeCamelCaseMaker.ConvertToSnakeCamelCase("CamelCaseString"));
            Console.WriteLine(Faktorio.FaktorioCounter(500));
            Console.WriteLine(AlphaNumericChecker.CheckAlphaNumeric(""));
            Lottery l = new Lottery(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(Lotto.LotteryFunction(new Lottery[] {
                new Lottery(new int[] { 1, 2, 3, 4, 5 }),
                new Lottery(new int[] { 6, 7, 8, 9, 10 }),
                new Lottery(new int[] { 11, 12, 13, 14, 15 })
                }, 100000)[0].Numbers);
            Console.WriteLine(WordCounter.CountWords("  , e   .. "));
            Console.WriteLine("\n" + DiceHistogram.CreateHistogram(new int[] { 7, 3, 10, 1, 0, 5 }));
            Console.WriteLine(FindMostFrequent.FindMostFrequentFunction("alma"));
        }
    }
}
