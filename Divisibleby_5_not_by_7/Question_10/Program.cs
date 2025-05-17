using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# to display a number divisible by 5 but not by 11 .......\n");
            int num;
            Console.Write("\nEnter a integer number to check : ");
            num = Convert.ToInt32(Console.ReadLine());
                if (num %5==0 && num %11 !=0)
            {
                Console.WriteLine ("\n\nThe given number "+num+" is divisible by 5 but not by 11.");
            }
            else
            {
                Console.WriteLine("\n\nPlease enter another number !!");
            }
                Console.ReadKey();
        }
    }
}
