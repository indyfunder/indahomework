using System;

namespace ข้อ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,n, i = 0, winner = 0;
            char pick;

            Console.Write("InputFirst Tank : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("InputSecond Tank : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("InputThird Tank : ");
            c = int.Parse(Console.ReadLine());
            while (i == 0) 
            {
                if (a <= 0 && b <= 0 && c <= 0)
                {
                    i = 1;
                    if (winner % 2 == 0) 
                    { 
                        Console.WriteLine("Player A win!!!");
                        break;
                    }
                    else 
                    { 
                        Console.WriteLine("Player B win!!!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Tank_A = {0} Tank_B = {1} Tank_C = {2}",a,b,c);
                    if (winner % 2 == 0)
                    {
                        Console.Write("what player_A gonna pick? : ");
                        pick = char.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("what player_B gonna pick? : ");
                        pick = char.Parse(Console.ReadLine());
                    }
                   
                    Console.Write("how many box u  pick? : ");
                    n = int.Parse(Console.ReadLine());
                    winner++;
                    if (n == 1 || n == 2)
                    {
                        if (pick == 'A')
                        {
                            a -= n;
                        }
                        else if (pick == 'B')
                        {
                            b -= n;                           
                        }
                        else if (pick == 'C')
                        {
                            c -= n;
                        }
                    }
                    else 
                    { 
                        Console.WriteLine("You can pick only 1/2 box!!! Input again!!!\n"); 
                    }
                }
            }
            Console.ReadLine();        
        }
    }
}
