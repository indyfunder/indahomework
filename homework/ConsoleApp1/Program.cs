using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string agency;
            int pass,one,ten,hun,k,tenk,hunk;
            Console.Write("input password :");
            pass = int.Parse(Console.ReadLine());
            Console.Write("input Agency :");
            agency = Console.ReadLine();
            one = pass % 10;
            ten = (pass % 100) / 10;
            hun = (pass % 1000) / 100;
            k = (pass % 10000) / 1000;
            tenk = (pass % 100000) / 10000;
            hunk= (pass % 1000000) / 100000;
            if (agency == "CIA")
            {
                if (one % 3 == 0)
                {
                    if (ten != 1 && ten != 3 && ten != 5) 
                    {
                        if (k >= 6 && k != 8)
                        { Console.WriteLine("True"); }
                        else { Console.WriteLine("False"); }
                    }
                    else { Console.WriteLine("False"); }
                }
                else { Console.WriteLine("False"); }                
            }
            if (agency == "FBI")
            {
                if (hunk >= 4 && hunk <= 7)
                {
                    if ( hun % 2 == 0 && hun != 6 )
                    {
                        if (tenk % 2 != 0)
                        { Console.WriteLine("True"); }
                        else { Console.WriteLine("False"); }
                    }
                    else { Console.WriteLine("False"); }
                }
                else { Console.WriteLine("False"); }
            }
            if (agency == "NSA")
            {
                if (30%one == 0)
                {
                    if (hun % 3 == 0 && hun % 2 != 0)
                    {
                        if (one==7 || ten==7 || hun==7 || k==7 || tenk==7 || hunk==7)
                        { Console.WriteLine("True"); }
                        else { Console.WriteLine("False"); }
                    }
                    else { Console.WriteLine("False"); }
                }
                else { Console.WriteLine("False"); }
            }
            else { Console.WriteLine("False"); }
            Console.ReadLine();
        }
    }
}
