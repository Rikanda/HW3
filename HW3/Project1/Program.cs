using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте количество строк массива: ");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте количество столбцов массива: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] Ar = new int[a, b];
            Random rand = new Random();
            
            Console.WriteLine("Выполняется генерация массива из случайных чисел от 10 до 99:");
            { for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Ar[i, j] = rand.Next(10, 100);
                        Console.Write($"{Ar[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Значения по диагонали:");
            int l = Math.Min(a, b);
            {
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if (i == j)
                        {
                            Console.Write($"{Ar[i, j]} ");
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.Write("На сколько позиций сдвинуть диагональ вправо? ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >(b - 1))
            {
                Console.WriteLine("Значение находится за пределами массива");
            }

            else
                Console.WriteLine("Значения по диагонали:");
            {
                int lx = Math.Min(a, b-x);
                {
                    for (int i = 0; i < lx; i++)
                    {
                        for (int j = 0; j < lx; j++)
                        {
                            if (i == j)
                            {
                                Console.Write($"{Ar[i, j+x]} ");
                            }
                        }
                    }
                }

            }

            Console.WriteLine();
            Console.Write("На сколько позиций сдвинуть диагональ вниз? ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y > (a - 1))
            {
                Console.WriteLine("Значение находится за пределами массива");
            }

            else
                Console.WriteLine("Значения по диагонали:");
            {
                int ly = Math.Min(a-y, b);
                {
                    for (int i = 0; i < ly; i++)
                    {
                        for (int j = 0; j < ly; j++)
                        {
                            if (i == j)
                            {
                                Console.Write($"{Ar[i+y, j]} ");
                            }
                        }
                    }
                }

            }

        }
    }
}
