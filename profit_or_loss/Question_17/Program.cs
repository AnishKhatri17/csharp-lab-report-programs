using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Question_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nC# program to find out Profit or Loss Amount ......");
            int cp, sp, profit, loss;
            Console.Write("\n\nEnter the Cost Price of the Product : ");
            cp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Sales Price of the Product : ");
            sp = Convert.ToInt32(Console.ReadLine());

                  if(sp > cp)
            {
                Console.WriteLine("\n\n\nCongratulations !! You have gained Profit .");
                profit = sp - cp;
                Console.WriteLine("\nThe profit Amount is :"+profit);
            }
                  else 
            { 
                    Console.WriteLine("\n\n\nNooooo !! You have beared Loss .");
                loss = cp - sp;
                Console.WriteLine("\nThe loss Amount is :"+loss);
            }
                        Console.ReadKey();
        }
    }
}
