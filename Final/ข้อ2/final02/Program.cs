using System;

namespace final02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            int[] NumSort = new int[99];
            Console.Write("NumSort : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("inputNum " + i + ":");
                NumSort[i] = int.Parse(Console.ReadLine());
            }
            /////////////01
            int[] a = new int[30];
            for (i = 1; i <= n; i++)
            {
                a[i] = NumSort[i];
            }
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("First Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("\n");

            //02   
            Console.Write("Secound Sort : ");
            int[] b = new int[30];
            for (i = 1; i <= n; i++)
            {
                b[i] = NumSort[i];
            }
            ////////////////////////////////////////
            for (i = 1; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (b[i] > b[j])
                    {
                        int temp = b[j];
                        b[j] = b[i];
                        b[i] = temp;
                    }
                }
            }
            //////////////////////////////////////////
            /*Print*/
            for (i = 1; i <= n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.Write("\n");
            //03
            Console.Write("Third Sort : ");
            int[] c = new int[30];
            for (i = 1; i <= n; i++)
            {
                c[i] = NumSort[i];
            }
            Array.Sort(c);           
            /*Print*/
            int count = c.Length;
            for (i = count - n; i < count; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.Write("\n");
            //02   
            Console.Write("Secound Sort : ");
            int[] d = new int[30];
            for (i = 1; i <= n; i++)
            {
                d[i] = NumSort[i];
            }
            ////////////////////////////////////////
            for (i = 1; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (d[i] > d[j])
                    {
                        int temp = d[j];
                        d[j] = d[i];
                        d[i] = temp;
                    }
                }
            }
            //////////////////////////////////////////
            /*Print*/
            for (i = 1; i <= n; i++)
            {
                Console.Write(d[i] + " ");
            }
            Console.Write("\n");


            Console.ReadLine();

        }
    }
}