// See https://aka.ms/new-console-template for more information
using System;

namespace UserGreetingProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Welcome to the C# Programming World .");
            Console.WriteLine("Now you need to work hard to become successful in this field!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

