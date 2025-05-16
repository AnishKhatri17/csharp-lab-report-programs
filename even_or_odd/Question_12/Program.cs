using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# Program to check whether a given number is even or odd.......");
            int number;
            Console.Write("\nEnter an integer number to check even or odd : ");
            number = Convert.ToInt32(Console.ReadLine());

            if(number%2 == 0)
            {
                Console.WriteLine("\n\nThe Given Number is Even.");
            }
            else
            {
                Console.WriteLine("\n\nThe Given Number is Odd.");
            }
                     Console.ReadKey();
        }
    }
}
