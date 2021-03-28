using System;

namespace ข้อ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y,i;
            Console.Write("input a :");
            a = int.Parse(Console.ReadLine());
            Console.Write("input b :");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            i = 0;
            
            while (i>=0)
            {
                if (x == y)
                {
                    Console.WriteLine(x);
                    break;
                }
                else
                {
                    if (x < y)
                    {
                        x = x + a;
                    }
                    else
                    {
                        y = y + b;
                    }
                }
                i++;
            }




        }
    }
}
