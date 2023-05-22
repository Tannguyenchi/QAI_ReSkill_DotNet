using System;
using static System.Console;
namespace P03_ColorfulConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Colorful Console";
            ForegroundColor = ConsoleColor.Magenta;
            Write("Your name: ");
            ResetColor();
            var name = ReadLine();
            BackgroundColor = ConsoleColor.Blue;
            Write(name);
            ReadLine();
        }
    }
}