using System;

namespace MyConsoleapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = args[0];
            var age = args[1];

            Console.WriteLine("Hello world");

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("What is your name?");

            Console.ResetColor();

            //var userName = Console.ReadLine();

            //Console.WriteLine($"Hello {userName}.");

            Console.WriteLine($"Hello {name} of age {age}");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Nice to meet you.");

            Console.ResetColor();

            var resetKey  = Console.ReadKey();

            if (resetKey.Key == ConsoleKey.Delete)
            {
                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
