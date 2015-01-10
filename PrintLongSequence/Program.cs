using System;
namespace PrintLongSequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int a = 2; a < 1002; a++)
        if (a % 2 == 0)
        Console.Write("{0},", a);
        else
        Console.Write("{0},", -a);
        Console.WriteLine();
        }
    }
}
