using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# Program to find Factorial of a given number n .........");
            int n,i,  fact=1;
            Console.Write("\nEnter the number you want the factorial of : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            if(n == 0 && n<0)
            {
                Console.WriteLine("\n\n\nError!!! Factorial of a negative number doesn't exist ...");
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    fact *= i;

                }
                Console.WriteLine("\n\n\nThe factorial of the given number " + n + " is : " + fact);
            }
            Console.ReadKey();
        }
                      
    }
}
