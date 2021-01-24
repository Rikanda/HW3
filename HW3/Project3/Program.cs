using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";
            for (int i=(text.Length-1); i>=0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
