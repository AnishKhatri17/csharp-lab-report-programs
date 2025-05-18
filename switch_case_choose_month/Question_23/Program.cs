using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# program to print name of twelve months.......\n");
            int month;
            Console.Write("Based on order of the month, Enter a number (1 -12) : ");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            { 
                case 1:
                    Console.WriteLine("\n\n\nYou choosed January");
                    break;
                case 2:
                    Console.WriteLine("\n\n\nYou choosed February");
                    break;
                case 3:
                    Console.WriteLine("\n\n\nYou choosed March");
                    break;
                case 4:
                    Console.WriteLine("\n\n\nYou choosed April");
                    break;
                case 5:
                    Console.WriteLine("\n\n\nYou choosed May");
                    break;
                case 6:
                    Console.WriteLine("\n\n\nYou choosed June");
                    break;
                case 7:
                    Console.WriteLine("\n\n\nYou choosed July");
                    break;
                case 8:
                    Console.WriteLine("\n\n\nYou choosed August");
                    break;
                case 9:
                    Console.WriteLine("\n\n\nYou choosed September");
                    break;
                case 10:
                    Console.WriteLine("\n\n\nYou choosed October");
                    break;
                case 11:
                    Console.WriteLine("\n\n\nYou choosed November");
                    break;
                case 12:
                    Console.WriteLine("\n\n\nYou choosed December");
                    break;
                default:
                    Console.WriteLine("\n\n\nInvalid choice !!!! Please try again and choose number between (1 -12) : ");
                    break;
            }
                    Console.ReadKey();
        }
    }
}
