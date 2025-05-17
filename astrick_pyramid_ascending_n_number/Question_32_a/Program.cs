using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_32_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nC# program to print the following pattern ....... \n\n");
            int i, j, rows;
            Console.Write("Enter the number of rows you want to print : ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            for(i=1; i<=rows; i++)
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
