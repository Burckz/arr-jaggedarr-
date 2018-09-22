using System;
using System.Linq;

namespace multidimensional_arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            if ( rows + cols > 0 && rows + cols <= 27)
            {
                char character = 'a';
                

                
                

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string element = "";
                    for (int i = 0; i < 3; i++)
                    {
                        element += character.ToString();
                    }

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = element;

                        char[] updates = element.ToCharArray();

                        for(int i = 0; i < updates.Length; i++)
                        {
                            if (i == 1)
                            {
                                updates[i] = (char)(Convert.ToUInt16(updates[i]) + 1);
                            }
                        }

                        string newElement = string.Empty;
                        foreach (char c in updates)
                        {
                            newElement += c;
                            
                        }
                        
                        element = newElement;
                        
                    }
                    character = (char)(Convert.ToUInt16(character) + 1);
                }


                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
