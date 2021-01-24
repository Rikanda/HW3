using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Sp = new string[5, 2];
            {
                for(int i=0; i<Sp.GetLength(0);i++)
                {
                    Console.Write($"Введите ФИО для {i+1} контакта: ");
                    Sp[i, 0] = Console.ReadLine();
             
                    Console.Write($"Введите телефон или email для {i+1} контакта: ");
                    Sp[i, 1] = Console.ReadLine();
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("Справочник контактов:");
            {
                for (int i = 0; i < Sp.GetLength(0); i++)
                {
                    Console.Write($"ФИО: {Sp[i,0]}; Контактные данные: {Sp[i,1]}");
                    Console.WriteLine();
                }
            }
     
        }
    }
}
