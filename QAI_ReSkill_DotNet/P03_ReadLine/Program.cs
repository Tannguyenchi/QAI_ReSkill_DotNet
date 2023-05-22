using System;
namespace P03_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string? number = Console.ReadLine();
            Console.WriteLine(number);
            Console.Write("Enter true or false: ");
            string? logic = Console.ReadLine();
            Console.WriteLine(logic);
            Console.Write("Enter a string: ");
            string? message = Console.ReadLine();
            Console.WriteLine(message);
            Console.Write("Press enter to quit");
            Console.ReadLine(); // dừng màn hình chờ ấn enter
        }
    }
}