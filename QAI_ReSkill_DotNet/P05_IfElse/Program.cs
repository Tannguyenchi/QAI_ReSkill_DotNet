using System;
using System.Text;
namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập nhiệt độ (oC): ");
            var input = Console.ReadLine();
            var temperature = int.Parse(input);
            if (temperature <= 5)
            {
                Console.WriteLine("Lạnh quá!");
            }
            else
            {
                if (temperature <= 15)
                {
                    Console.WriteLine("Mát mẻ, dễ chịu!");
                }
                else
                {
                    if (temperature <= 25)
                    {
                        Console.WriteLine("Ấm áp!");
                    }
                    else
                    {
                        Console.WriteLine("Nóng quá!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

/*using System;
using System.Text;

namespace P01_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập nhiệt độ (oC): ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature <= 5)
                Console.WriteLine("Lạnh quá!");
            else if (temperature <= 15)
                Console.WriteLine("Mát mẻ, dễ chịu!");
            else if (temperature <= 25)
                Console.WriteLine("Ấm áp!");
            else
                Console.WriteLine("Nóng quá!");

            Console.ReadKey();
        }
    }
}
*/