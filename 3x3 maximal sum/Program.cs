using System;
using System.Linq;

namespace _3x3_maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum = 0;
            int bestSum = 0;
            int[,] best3x3 = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 2; col < matrix.GetLength(1); col++)
                {
                    for (int squareRow = row; squareRow <= row + 2; squareRow++)
                    {
                        for (int squareCol = col - 2; squareCol <= col; squareCol++)
                        {
                            sum += matrix[squareRow, squareCol];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        int threeRow = 0;
                        int threeCol = 0;
                        for (int squareRow = row; squareRow <= row + 2; squareRow++)
                        {
                            for (int squareCol = col - 2; squareCol <= col; squareCol++)
                            {
                                best3x3[threeRow, threeCol] = matrix[squareRow, squareCol];
                                threeCol++;
                            }
                            threeRow++;
                            threeCol = 0;
                        }
                    }
                    sum = 0;
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int row = 0; row < best3x3.GetLength(0); row++)
            {

                for (int col = 0; col < best3x3.GetLength(1); col++)
                {
                    Console.Write($"{best3x3[row, col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
