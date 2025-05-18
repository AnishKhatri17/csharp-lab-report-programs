using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Program to find and display all prime numbers from 1 to 100...");

            for (int num = 2; num <= 100; num++) // Start from 2 since 1 isn't prime number ....
            {
                bool isPrime = true;

                for (int i = 2; i * i <= num; i++) // Check divisibility up to sqrt(num)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break; // No need to check further ....
                    }
                }

                if (isPrime)
                    Console.Write(num + " ");
            }

            Console.WriteLine("\n\nPrime numbers printed successfully!");
            Console.ReadLine();
        }
        
    }
}
