namespace P02_ColorfulConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P02_ColorfulConsole";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Your Name:");
            Console.ResetColor();
            var name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ReadLine();

        }
    }
}
