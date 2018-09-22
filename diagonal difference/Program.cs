using System;
using System.Linq;

namespace diagonal_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sumLeftDiagonal = 0;
            int sumRightDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }


                sumLeftDiagonal = sumLeftDiagonal + matrix[row, row];
                sumRightDiagonal = sumRightDiagonal + matrix[row, matrix.GetLength(1) - 1 - row];


            }

            int diff = Math.Abs(sumRightDiagonal - sumLeftDiagonal);

            Console.WriteLine(diff);

        }
    }
}
