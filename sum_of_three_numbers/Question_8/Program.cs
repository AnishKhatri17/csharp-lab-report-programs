using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram to perform Arithmetic Operations .....");
            int num1, num2, num3, sum;
            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third Number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3;
            Console.WriteLine("\n\n\nThe sum of Three Number is : "+ sum);
            Console.ReadKey();      


        }
    }
}
