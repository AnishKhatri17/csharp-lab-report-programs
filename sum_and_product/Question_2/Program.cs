using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, product;
            Console.WriteLine("Enter the value of First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            product = a * b;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("The Sum of two numbers is :" + sum);
            Console.WriteLine("The Product of two numbers is :" + product);
            Console.ReadKey();  
        }
    }
}
