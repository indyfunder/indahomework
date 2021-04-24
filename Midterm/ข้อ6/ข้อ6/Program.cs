using System;

namespace ข้อ6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char s;
                int width, height, step, i, t, j;
                
                Console.Write("String = ");
                s = char.Parse(Console.ReadLine());
                Console.Write("Width = ");
                width = int.Parse(Console.ReadLine());
                int realwidth = width;
                Console.Write("Height = ");
                height = int.Parse(Console.ReadLine());
                Console.Write("Step = ");
                step = int.Parse(Console.ReadLine());
                
                for (j = 0; j < step; j++)
                {
                    for (t = 0; t < height; t++)
                    {
                        for (i = 0; i < width; i++)
                        {
                          Console.Write("{0}", s);
                        }
                        Console.Write("\n");
                    }
                    width += realwidth;
                }
                Console.ReadLine();
            }
        }
    }
}
