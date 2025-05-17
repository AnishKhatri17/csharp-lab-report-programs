using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n C# program to find Biggest AAmong Three Numbers ......");
            int num1, num2, num3 ;
            Console.Write("\nEnter the First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third Number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("\n\nThe Biggest Number is : "+num1);
            }
                else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("\n\nThe Biggest Number is : "+num2);
            }
            else if (num3>num1 && num3>num2)
            {
                Console.WriteLine("\n\nThe biggest number is : "+num3);
            }
                    else
            {
                Console.WriteLine("\n\nAll 3 numbers are equal, neither of them is biggest .");
            }
        }
    }
}
