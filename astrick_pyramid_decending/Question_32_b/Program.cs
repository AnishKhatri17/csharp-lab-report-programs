using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_32_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC# program to print the following pattern ......\n");
            int i, j, rows;
            Console.Write("\nEnter the number of rows (1-10) :");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for(i = rows; i>=1; i--) 
            {
                for(j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
           }
            Console.ReadKey();

        }
    }
}
