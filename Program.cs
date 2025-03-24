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

            Console.WriteLine($"Hello, {name}! Welcome to the C# world.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

