using System;

namespace final05
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inventory, i;
            string IN1, IN2, M;
            Console.Write("");
            Inventory = int.Parse(Console.ReadLine());
            for (i = 0; i <= Inventory; i++)
            {
                Console.Write("Item : ");
                IN1 = Console.ReadLine();
                Console.Write("type : ");
                IN2 = Console.ReadLine();
            }
            Console.Write("Mode : ");
            M = Console.ReadLine();
            if (M == "ShowAll")
            {
                for (i = 0; i <= Inventory; i++)
                {

                }
            }
            else
            {
                Console.WriteLine("End");
            }
            Console.ReadLine();
        }
    }
}
