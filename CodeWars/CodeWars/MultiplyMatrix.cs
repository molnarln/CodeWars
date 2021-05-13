using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars1
{
    class MultiplyMatrix
    {
        public int[][] MultiplyMatrixFunction(int[][] input)
        {
            int[][] output = new int[input.Length][];

            for (int i = 0; i < input.Length; i++)
            {
                int[] row = new int[input[i].Length];

                for (int j = 0; j < input[i].Length; j++)
                {
                    row[j] = input[i][j] * 2;
                }

                output[i] = row;
            }
            return output;
        }

        public int[,] MultiplyMatrixFunctionWithMultiDimensionalArray(int[,] input)
        {
            int[,] output = new int[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    output[i, j] = input[i, j] * 2;
                }
            }
            return output;
        }
    }
}
