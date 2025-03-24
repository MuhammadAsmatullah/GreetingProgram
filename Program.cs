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
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello, {name} You are  {age} years old ! And Welcome to the C# Programming World .");
            Console.WriteLine("Now you need to work hard to become successful in this field!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

