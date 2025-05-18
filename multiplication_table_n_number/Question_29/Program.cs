using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nMultiplication Table upto N terms : ");
            int n, m, i;
            Console.Write("\n\nEnter the number you want the Multiplication Table of : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0 && n < 0)
            {
                Console.WriteLine("\n\nSorry! Negative numbers and 0 don't have multiplication table !!!!!.");
            }
            else
            {
                Console.WriteLine("\n\n\nThe multiplication table of "+n+" is : \n");
                for (i = 1; i <= 10; i++)
                {
                    m = n * i;
                    Console.WriteLine("\t" + n + " * " + i + " \t= " +m);
                }
            }
            Console.ReadKey();
        }
    }
}
