using System;
namespace P04_ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ReadKey";
            Console.Write("Press any key: ");
            var key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(key.KeyChar);
            Console.WriteLine(key.Modifiers);
            if (key.Key == ConsoleKey.H)
                Console.WriteLine("Hello!");
            Console.ReadKey();
        }
    }
}