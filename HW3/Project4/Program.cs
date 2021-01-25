using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            int[,] Ar = new int[10, 10];
            Random rand = new Random();

            Console.WriteLine("Выполняется генерация массива кораблей");
            

            int n = 0;
           

            while (n<12)
            {
               
                int x = rand.Next(0, 7);
                int y = rand.Next(0, 7);
                int o = rand.Next(2);
                

                if (Ar[x, y] != 1)
                {
                    n++;

                    if (o == 0)
                        //&& Ar[x + 1, y] == 0 && Ar[x + 1, y + 1] == 0 && Ar[x + 1, y + 2] == 0 && Ar[x, y + 1] == 0 && Ar[x, y + 2] == 0 && Ar[x - 1, y] == 0 && Ar[x - 1, y + 1] == 0 && Ar[x - 1, y + 2] == 0)
                    {
                        for (int i = y; i < y + 3; i++)
                        {
                            Ar[i, x] = 1; //вертикальное положение

                        }

                    }
                    else
                    {

                        if (o == 1)
                           // && Ar[x, y + 1] == 0 && Ar[x + 1, y + 1] == 0 && Ar[x + 2, y + 1] == 0 && Ar[x + 1, y] == 0 && Ar[x + 2, y] == 0 && Ar[x, y - 1] == 0 && Ar[x + 1, y - 1] == 0 && Ar[x + 2, y - 1] == 0)
                        {
                            for (int j = x; j < x + 3; j++)
                            {
                                Ar[y, j] = 1; //горизонтальное положение

                            }
                        }
                    }
                }

                
                }


            { for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (Ar[i, j] == 1)
                        { 
                        Console.Write("X ");
                        }
                        else
                        {
                            Console.Write("O ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
