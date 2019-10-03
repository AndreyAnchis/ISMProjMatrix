using System;

namespace MaxValueInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose matrix (1, 2)");
                Console.WriteLine("3 - close");
                int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            int[,] array = { { 1, 6, 3, -12 },
                                             { 1, 10, -2, 1 },
                                             { 3, 8, 4, 5 },
                                             { 4, -11, 1, 4 },
                                             { 5, 9, 11, 1 }
                            };
                            int max1 = array[0, 0];
                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    if (max1 < array[i, j])
                                    {
                                        max1 = array[i, j];
                                    }
                                }
                            }
                            Console.WriteLine("Max: " + max1);
                            break;
                        case 2:
                            int[,] arr = { { 6, 6, 1, 9 },
                                           { -7, 3, -2, 1 },
                                           { 3, -6, 1, 5 },
                                           { 33, 21, 3, 9 },
                                           { 5, 11, 6, 1 }
                            };
                            int max2 = arr[0, 0];
                            for (int i = 0; i < arr.GetLength(0); i++)
                            {
                                for (int j = 0; j < arr.GetLength(1); j++)
                                {
                                    if (max2 < arr[i, j])
                                    {
                                        max2 = arr[i, j];
                                    }
                                }
                            }
                            Console.WriteLine("Max: " + max2);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }              
            } while (true);
        }
    }
}