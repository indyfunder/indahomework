using System;

namespace final01
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            int[,] N = new int[3, 3];

            for (int i = 0; i < N.Length; i++)
            {
                for (int j = 0; j < N.Length; j++)
                {
                    N[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
