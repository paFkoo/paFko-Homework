using System;

namespace Print_Numbers
//Write a program to print the numbers 1, 101 and 1001, each at a separate line.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("101");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1001");
        }
    }
}
