using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# Program to demonstrate Ternary Operator .......");
            int age;
            Console.Write("\nEnter your Age : ");
            //age = int.Parse(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());
           
            bool output;

            //using ternary operator
            output = (age >= 18) ? true : false;
            {
                if (output)
                {
                    Console.WriteLine("\n\nYou are a legal Voter.");
                }
                else
                {
                    Console.WriteLine("\n\nYou are not a legal Voter.");
                }
            }
                     Console.ReadKey();
        }
    }
}
