using System;
using System.Linq;

namespace _2x2_squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int count = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {


                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == matrix[row, col - 1])
                    {
                        string character = matrix[row, col];

                        if (character == matrix[row + 1, col] && character == matrix[row + 1, col - 1])
                        {
                            count++;
                        }
                    }

                }
            }

            Console.WriteLine(count);
        }
    }
}
