using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_32_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC# program to print the following pattern ........\n");
            int i, j, rows;
            Console.Write("\nEnter the number of rows (i.e 5) : ");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=rows; i++)
            { 
                for(j=1; j<=i; j++)
                {
                    Console.Write("\t"+j);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
