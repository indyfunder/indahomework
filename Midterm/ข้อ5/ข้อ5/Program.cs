using System;

namespace ข้อ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, time, run = 1;
            string menu;
            int bset = 5, wset = 3, coffee = 3;
            Console.Write("We have Menu Breakfast_Set,Weekend_Set,Coffee\n");
            Console.Write("Please Select Day&time\n");
            Console.Write("Day (1-7): ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Time (8-18): "); 
            time = int.Parse(Console.ReadLine());
            while (run == 1)
            {
                Console.Write("Breakfast_Set = {0}, Weekend_Set = {1},Coffee = {2}\n", bset, wset, coffee);
                Console.Write("Menu : ");
                menu = Console.ReadLine();
                if (menu == "end")
                {
                    run = 2;
                }
                else if (menu =="Breakfast_Set")
                {
                    Console.Write("u select breakfast\n");
                    if (bset == 0)
                    {
                        Console.Write("Sorry your order is out of stock\n");
                    }
                    else
                    {
                        if (time > 11)
                        {
                            Console.Write("Sorry your order is out of stock\n");
                        }
                        else
                        {
                            bset -= 1;
                        }
                    }
                }
                else if (menu == "Weekend_Set")
                {
                    Console.Write("u select weekend\n");
                    if (wset == 0)
                    {
                        Console.Write("Sorry your order is out of stock\n");
                    }
                    else
                    {
                        if (day <= 5)
                        {
                            Console.Write("Sorry your order is out of stock\n");
                        }
                        else
                        {
                            wset -= 1;
                        }
                    }
                }
                else if (menu == "Coffee")
                {
                    Console.Write("u select coffee\n");
                    if (coffee == 0)
                    {
                        Console.Write("Sorry your order is out of stock\n");
                    }
                    coffee -= 1;
                }
                else
                {
                    Console.Write("Plese enter a valid menu\n");
                }
            }
            Console.ReadLine();
        }
    }
}
