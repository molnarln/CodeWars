using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test DisEmVowel class and method
            string input = "valamidfawqfheiuwqhf8923hrkjfsdiu";
            string a = DisEmVowel.Disemvowel(input);
            Console.WriteLine(a);

            //Test MinAndMax method
            Console.WriteLine(MinAndMax.HighAndLow("1 2 3 4 5"));  // return "5 1"
            Console.WriteLine(MinAndMax.HighAndLow("1 2 -3 4 5")); // return "5 -3"
            Console.WriteLine(MinAndMax.HighAndLow("1 9 3 4 -5")); // return "9 -5"

            //Test AddBinaryMethod
            Console.WriteLine(AddBinary.AddBinaryFunction(3, 5));

            //Test IQ.Test
            Console.WriteLine(IQ.Test("2 4 7 8 10"));

            //Test CountBitsMethod
            Console.WriteLine(CountBits.CountBitsMethod(11));

            //Test IsogramMethod
            Console.WriteLine(Isogram.IsogramMethod("Alma"));

            //Test XOMethod
            Console.WriteLine(XO.XOMethod("xxOOOoo"));

            //Test ValidParenthesesMethod

            Console.WriteLine(ValidParentheses.ValidParenthesesMain("((dfadsfa)((fdsafdsa))"));

            //Test DrawDiamonds PrintMethod
            Console.WriteLine(DrawDiamond.PrintMethod(7));

            //Test XBonacciFunction
            XBonacci xBonacci = new XBonacci() { };
            double[] result = xBonacci.XBonacciFunction(new double[] { 0, 0, 1 }, 34);
            result.ToList().ForEach(x => Console.Write(x + " "));

            Console.ReadKey();
        }
    }
}
