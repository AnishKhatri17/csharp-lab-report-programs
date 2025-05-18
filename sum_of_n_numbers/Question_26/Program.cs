using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n;
            Console.WriteLine("\n\nC# Program to display sum of numbers between 1 to 50 .......");

            Console.Write("\nEnter the max number you want the sum of : ");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\n\n\nThe sum of numbers from 1 to 50 is : "+sum) ;
            Console.ReadKey();
        }
    }
}
