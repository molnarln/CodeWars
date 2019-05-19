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
            Console.WriteLine();

            //Test MultiplyMatrixFunction 
            //Actually this is not a codewars exercise, just random practice...
            int[][] inputMatrix = new int[4][];
            inputMatrix[0] = new int[] { 1, 3, 6, 2, 3 };
            inputMatrix[1] = new int[] { 7, 5, 6, 1 };
            inputMatrix[2] = new int[] { 3, 3, 1, 5 };
            inputMatrix[3] = new int[] { 9, 0, 5, 3 };

            Console.WriteLine($"The second row thrird item is: {inputMatrix[1][2]}");

            MultiplyMatrix mm = new MultiplyMatrix();
            int[][] outputMatrix = mm.MultiplyMatrixFunction(inputMatrix);
            foreach (var row in outputMatrix)
            {
                Console.Write("|");
                foreach (var element in row)
                {
                    Console.Write(element + "|");
                }
                Console.WriteLine();
            }

            //Test MultiplyMatrixFunctionWithMultiDimensionalArray
            Console.WriteLine("Same test with multidimensional array:");
            int[,] inputMatrix2 = new int[4, 4] {
                { 1, 3, 6, 2 },
                { 7, 5, 6, 1 },
                { 3, 3, 1, 5 },
                { 9, 0, 5, 3 }
            };

            MultiplyMatrix mm2 = new MultiplyMatrix();
            int[,] outputmatrix2 = mm2.MultiplyMatrixFunctionWithMultiDimensionalArray(inputMatrix2);
            for (int i = 0; i < outputmatrix2.GetLength(0); i++)
            {
                int[] row = Enumerable.Range(0, outputmatrix2.GetLength(1)).Select(x => outputmatrix2[i, x]).ToArray();

                Console.Write("|");
                foreach (var item in row)
                {
                    Console.Write(item + "|");
                }
                Console.WriteLine();
            }

            Delayer d = new Delayer();

            Task.Run(async () => await d.DelayFunction()).GetAwaiter().GetResult();

            //Test TwoSumFunction
            int[] inputForTwoSumFunction = new int[] { 2, 2, 3 };
            int target = 4;
            TwoSum.TwoSumFunction(inputForTwoSumFunction, target).ToList().ForEach(x => Console.WriteLine(x));




            //Console.Read();
        }
    }
}
