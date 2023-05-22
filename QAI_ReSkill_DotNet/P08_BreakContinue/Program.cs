using System;
namespace P04_BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (true)
            {
                if (i == 10)
                    break;
                Console.Write($"{i}\t");
                i++;
            }
            var j = 0;
            do
            {
                j++;
                if (j == 5) continue;
                Console.Write($"{j}\t");
            } while (j < 10);
            Console.ReadKey();
        }
    }
}