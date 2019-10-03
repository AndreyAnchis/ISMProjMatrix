using System;

namespace MinValueInLineOfMatrix
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
                int line = 0;
                switch (menu)
                {
                    case 1:
                        int[,] array = { { 1, 6, 3, -12 },
                                         { 1, 10, -2, 1 },
                                         { 3, 8, 4, 5 },
                                         { 4, -11, 1, 4 },
                                         { 5, 9, 11, 1 }
                            };
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            int min = int.MaxValue;
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (min > array[i, j])
                                {
                                    min = array[i, j];
                                    line = i;
                                }
                            }
                            Console.WriteLine("Line {0} Min = {1}", line, min);
                        }
                        break;
                    case 2:
                        int[,] arr = { { 6, 6, 1, 9 },
                                       { -7, 3, -2, 1 },
                                       { 3, -6, 1, 5 },
                                       { 33, 21, 3, 9 },
                                       { 5, 11, 6, 1 }
                        };
                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            int min = int.MaxValue;
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                if (min > arr[i, j])
                                {
                                    min = arr[i, j];
                                    line = i;

                                }
                            }
                            Console.WriteLine("Line {0} Min = {1}", line, min);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
