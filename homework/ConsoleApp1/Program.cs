using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string mode; double x, y;
            Console.Write("time/price : ");
            mode = Console.ReadLine();
            Console.Write("x : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y : ");
            y = double.Parse(Console.ReadLine());

            if (mode == "time")
            {
                if (x! > 0)
                {
                    y = (x - 1) * (x - 1);
                    Console.WriteLine("{0}, {1}", x, y);
                }
                else { Console.WriteLine("Invalid mouse position"); }

            }
            else if (mode == "price")
            {
                if (x! > 0)
                {
                    x = Math.Sqrt(y) + 1;
                    Console.WriteLine("{0}, {1}", x, y);
                }
                else { Console.WriteLine("Invalid mouse position"); }
            }
            else { Console.WriteLine("Invalid mode"); }
            Console.ReadLine();

        }   
    }
}
