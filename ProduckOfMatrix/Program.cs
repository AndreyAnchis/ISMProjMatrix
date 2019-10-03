using System;

namespace ProduckOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {1, 1, 3, 4, 5 },
                           {6, 10, 8, -11, 9 },
                           {3, -2, 4, 1, 11},
                           {-12, 1, 5, 4, 1},
            };
            int[,] arr = { { 6, 6, 1, 9 },
                           { -7, 3, -2, 1 },
                           { 3, -6, 1, 5 },
                           { 33, 21, 3, 9 },
                           { 5, 11, 6, 1 }
            };
            int[,] arrCount = new int[array.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int z = 0; z < arr.GetLength(0); z++)
                    {
                        arrCount[i, j] += array[i, z] * arr[z, j];
                    }
                }
            }
            for (int i = 0; i < arrCount.GetLength(0); i++)
            {
                for (int j = 0; j < arrCount.GetLength(1); j++)
                {
                    Console.Write("{0} ", arrCount[i, j]);
                }
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}
