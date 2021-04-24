using System;

namespace ข้อ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            float filmBackWidth;
            Console.Write("String = ");
            mode = Console.ReadLine();
            int run = 1;
            while (run == 1)
            {
                Console.Write("filmBackWidth : ");
                filmBackWidth = float.Parse(Console.ReadLine());
                if (filmBackWidth > 0)
                {
                    double fLength, fov;
                    if (mode == "fLength")
                    {
                        run = 1;
                        while (run == 1)
                        {
                            Console.Write("fLength = ");
                            fLength = double.Parse(Console.ReadLine());
                            if (fLength > 0)
                            {
                                fov = 2 * (Math.Atan(filmBackWidth / (2 * fLength)));

                                Console.Write("fLength = {0},fov = {1}", fLength, fov);
                                run = 2;
                            }
                            else
                            {
                                Console.Write("Invalid fLength. Please input again");
                            }
                        }
                    }
                    else
                    {
                        if (mode == "fov")
                        {
                            run = 1;
                            while (run == 1)
                            {
                                Console.Write("fov = ");
                                fov = float.Parse(Console.ReadLine());
                                if (fov > 0.1 && fov < 6.28)
                                {
                                    fLength = filmBackWidth / (2 * Math.Tan(fov / 2));
                                    Console.Write("fLength = {0},fov = {1}", fLength, fov);
                                    run = 2;
                                }
                                else
                                {
                                    Console.Write("Invalid fov.Please input again");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Invalid filmBackWidth. Please input again\n");
                }
            }
            Console.ReadLine();
        }
    }
}
