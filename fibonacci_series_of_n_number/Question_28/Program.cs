using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# Program to find Fibonacci Series of n terms.......... ");
            int a, b, c, i, n;
            Console.Write("\nEnter a positve integer number to find fibonacci series : ");
            n = int.Parse(Console.ReadLine());

            /* Initializing the initial values ..... */
            a = 0;
            b = 1;
            c = 0;

            Console.WriteLine("\n\n\nFibonacci Terms are : \n");
            for(i= 0; i < n; i++)
            {
                Console.Write(c+"\t");
                a = b;     // copy n-1 to n-2
                b = c;     // copy current to n-1
                c = a + b; // new term
            }
            Console.ReadKey();
        }
    }
}
