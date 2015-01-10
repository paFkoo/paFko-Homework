using System;
namespace Ageafter10Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int MyAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be:{0}", MyAge + 10);
        }
    }
}
